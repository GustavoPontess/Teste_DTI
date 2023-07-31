import http from "@/http-common";

export default class AllReminderService {
  async getReminders() {
    try {
      const response = await http.get("/api/ReminderApi");
      return response.data;
    } catch (error) {
      console.error("Erro ao obter lembretes:", error);
      throw error;
    }
  }
}
