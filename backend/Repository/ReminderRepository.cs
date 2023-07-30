using backend.Data;
using backend.Models;
using backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class ReminderRepository : IReminderRepository
    {
        private readonly ConnectionDBContext _dbContext;

        public ReminderRepository(ConnectionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Reminder> GetReminderById(int id)
        {
            return await _dbContext.Reminders.FirstOrDefaultAsync(r => r.Id == id);
        }
        public async Task<List<Reminder>> GetAllReminders()
        {
            return await _dbContext.Reminders.Where(r => !r.Is_Deleted).ToListAsync();
        }

        public async Task<Reminder> AddReminder(Reminder reminder)
        {
            reminder.Created_At = DateTime.Now;
            await _dbContext.Reminders.AddAsync(reminder);
            await _dbContext.SaveChangesAsync();

            return reminder;
        }

        public async Task<Reminder> UpdateReminder(Reminder reminder, int id)
        {
            Reminder reminderById = await GetReminderById(id);

            if (reminderById == null)
            {
                throw new Exception($"Lembrete para o ID: {id} não foi encontrado.");
            }

            if (!string.IsNullOrEmpty(reminder.Name))
            {
                reminderById.Name = reminder.Name;
            }

            reminderById.Date = reminder.Date;

            reminderById.Updated_At = DateTime.Now;

            _dbContext.Reminders.Update(reminderById);

            await _dbContext.SaveChangesAsync();

            return reminderById;
        }

        public async Task<Reminder> SoftDeleteReminder(int id)
        {
            Reminder reminderById = await GetReminderById(id);

            if (reminderById == null)
            {
                throw new Exception($"Lembrete para o ID: {id} não foi encontrado.");
            }

            reminderById.Deleted_At = DateTime.Now;
            reminderById.Is_Deleted = true;

            _dbContext.Reminders.Update(reminderById);

            await _dbContext.SaveChangesAsync();

            return reminderById;
        }
    }
}