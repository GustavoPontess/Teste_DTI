<template>
    <form @submit.prevent="handleSubmit" class="container mt-4">
        <h1>{{ isEditing ? 'Editar Lembrete' : 'Novo Lembrete' }}</h1>
        <div class="form-group">
            <label for="name">Nome:</label>
            <input v-model="formData.name" type="text" class="form-control" id="name" required>
        </div>
        <div class="form-group">
            <label for="date">Data:</label>
            <input v-model="formattedDateInput" type="date" class="form-control" id="date" required>
        </div>
        <button type="submit" class="btn btn-primary mt-2 m-1">{{ isEditing ? 'Salvar' : 'Criar' }}</button>
        <button type="button" class="btn btn-secondary mt-2" @click="cancelEdit" v-if="isEditing">Cancelar</button>
    </form>
</template>

<script>
import ReminderCreateService from "@/services/ReminderCreateService";
import ReminderEditService from "@/services/ReminderEditService";

export default {
    props: {
        id: {
            type: Number,
            default: null,
        },
        selectedReminder: {
            type: Object,
            default: null,
        },
    },
    data() {
        return {
            formData: {
                name: '',
                date: '',
            },
            isEditing: false,
        };
    },
    computed: {
        formattedDateInput: {
            get() {
                return this.formData.date ? new Date(this.formData.date).toISOString().slice(0, 10) : '';
            },
            set(value) {
                this.formData.date = value;
            },
        },
        formattedDate: {
            get() {
                return this.selectedReminder ? new Date(this.selectedReminder.date).toLocaleDateString('pt-BR') : '';
            },
        },
    },
    watch: {
        selectedReminder: {
            immediate: true,
            handler(newVal) {
                this.isEditing = !!newVal;
                if (newVal) {
                    this.formData.name = newVal.name;
                    this.formData.date = newVal.date;
                } else {
                    this.formData.name = '';
                    this.formData.date = '';
                }
            },
        },
    },
    methods: {
        async handleSubmit() {
            try {
                // Verificar se o campo "Nome" está preenchido
                if (!this.formData.name) {
                    alert("Por favor, preencha o campo 'Nome'.");
                    return;
                }

                // Verificar se o campo "Data" está preenchido
                if (!this.formData.date) {
                    alert("Por favor, preencha o campo 'Data'.");
                    return;
                }

                // Verificar se a data informada é válida e está no futuro
                const selectedDate = new Date(this.formData.date);
                const currentDate = new Date();
                if (isNaN(selectedDate.getTime()) || selectedDate <= currentDate) {
                    alert("Por favor, selecione uma data válida no futuro.");
                    return;
                }

                if (this.isEditing) {
                    // Editar o lembrete existente
                    const reminderService = new ReminderEditService();
                    await reminderService.editReminder(this.id, this.formData);
                } else {
                    // Criar um novo lembrete
                    const reminderService = new ReminderCreateService();
                    await reminderService.createReminder(this.formData);
                }

                // Limpar os dados do formulário após salvar
                this.formData.name = '';
                this.formData.date = '';

                // Redefinir o valor de isEditing para false
                this.isEditing = false;

                // Emitir o evento para o componente pai (App.vue) informando que o lembrete foi atualizado
                this.$emit('update');
            } catch (error) {
                console.error("Erro ao criar/editar lembrete:", error);
            }
        },
        cancelEdit() {
            // Limpar os dados do formulário
            this.formData.name = '';
            this.formData.date = '';

            // Redefinir o valor de isEditing para false
            this.isEditing = false;
        },
    },
};
</script>
