import http from "@/http-common";

export default class ReminderCreateService {
  async createReminder(reminderData) {
    try {
      const response = await http.post("/api/ReminderApi", reminderData);
      return response.data;
    } catch (error) {
      console.error("Erro ao criar lembrete:", error);
      throw error;
    }
  }
}
