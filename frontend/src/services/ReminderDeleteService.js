import http from "@/http-common";

export default class ReminderDeleteService {
  async deleteReminder(reminderId) {
    try {
      const response = await http.delete(`/api/ReminderApi/${reminderId}`);
      return response.data;
    } catch (error) {
      console.error("Erro ao excluir lembrete:", error);
      throw error;
    }
  }
}
