<template>
  <div class="container mt-4">
    <div class="row">
      <div class="col-lg-6 mt-3 mt-lg-0">
        <ReminderForm :selectedReminder="selectedReminder" :id="selectedReminder ? selectedReminder.id : null" @update="fetchReminders" />
      </div>
      <div class="col-lg-6">
        <ReminderList :reminders="reminders" @edit-reminder="handleEditReminder" />
      </div>
    </div>
  </div>
</template>

<script>
import AllReminderService from "@/services/AllReminderService";
import ReminderServiceById from "@/services/ReminderServiceById";
import ReminderList from "@/components/ReminderList.vue";
import ReminderForm from "@/components/ReminderForm.vue";

export default {
  name: 'App',
  components: {
    ReminderList,
    ReminderForm,
  },
  data() {
    return {
      reminders: [],
      selectedReminder: null,
    };
  },
  async mounted() {
    await this.fetchReminders();
  },
  methods: {
    async fetchReminders() {
      try {
        const reminderService = new AllReminderService();
        this.reminders = await reminderService.getReminders();
      } catch (error) {
        console.error("Erro ao obter lembretes:", error);
      }
    },
    async handleEditReminder(reminderId) {
      const reminderServiceById = new ReminderServiceById();
      try {
        const selectedReminder = await reminderServiceById.getReminderById(reminderId);
        this.selectedReminder = selectedReminder;
      } catch (error) {
        console.error("Erro ao obter lembrete por ID:", error);
      }
    },
  },
};
</script>
