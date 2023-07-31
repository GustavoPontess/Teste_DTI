<template>
    <div class="container mt-4">
        <h1 class="text-center">Lista de Lembretes</h1>
        <div v-for="(group, index) in remindersCopy" :key="index" class="card mb-4">
            <div class="card-header">
                <h3>{{ new Date(group.date).toLocaleDateString('pt-BR') }}</h3>
            </div>
            <ul class="list-group list-group-flush">
                <li v-for="reminder in group.reminders" :key="reminder.id"
                    class="list-group-item d-flex justify-content-between">
                    {{ reminder.name }}
                    <div>
                        <button @click="deleteReminder(reminder.id)" class="btn btn-danger btn-sm m-1">Excluir</button>
                        <button @click="editReminder(reminder.id)" class="btn btn-primary btn-sm">Editar</button>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</template>
  
<script>
import ReminderDeleteService from "@/services/ReminderDeleteService";

export default {
    name: 'ReminderList',
    props: {
        reminders: Array,
    },
    data() {
        return {
            remindersCopy: [],
        };
    },
    mounted() {
        this.remindersCopy = this.reminders.map(group => ({ ...group }));
        this.$watch('reminders', () => {
            this.remindersCopy = this.reminders.map(group => ({ ...group }));
        });
    },
    methods: {
        async deleteReminder(reminderId) {
            try {
                const reminderDeleteService = new ReminderDeleteService();
                await reminderDeleteService.deleteReminder(reminderId);

                this.remindersCopy = this.remindersCopy.map(group => ({
                    ...group,
                    reminders: group.reminders.filter(reminder => reminder.id !== reminderId),
                }));
                this.remindersCopy = this.remindersCopy.filter(group => group.reminders.length > 0);
            } catch (error) {
                console.error("Erro ao excluir lembrete:", error);
            }
        },
        editReminder(reminderId) {
            this.$emit('edit-reminder', reminderId);
        },
    },
};
</script>
  
<style>
.card {
    margin-bottom: 20px;
}
</style>
