import http from "@/http-common";

export default class ReminderEditService {
  async editReminder(reminderId, reminderData) {
    try {
      const response = await http.put(
        `/api/ReminderApi/${reminderId}`,
        reminderData
      );
      return response.data;
    } catch (error) {
      console.error("Erro ao editar lembrete:", error);
      throw error;
    }
  }
}
