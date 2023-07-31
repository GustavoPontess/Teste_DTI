import http from "@/http-common";

export default class ReminderServiceById {
  async getReminderById(reminderId) {
    try {
      const response = await http.get(`/api/ReminderApi/${reminderId}`);
      return response.data;
    } catch (error) {
      console.error("Erro ao obter lembrete por ID:", error);
      throw error;
    }
  }
}
