using backend.Models;

namespace backend.Repository.Interfaces
{
    public interface IReminderRepository
    {
        Task<List<ReminderGroup>> GetAllReminders();
        Task<Reminder> GetReminderById(int id);
        Task<Reminder> AddReminder(Reminder reminder);
        Task<Reminder> UpdateReminder(Reminder reminder, int id);
        Task<Reminder> SoftDeleteReminder(int id);
    }
}