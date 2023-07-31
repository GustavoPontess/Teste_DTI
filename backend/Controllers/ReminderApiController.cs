using backend.Models;
using backend.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReminderApiController : ControllerBase
    {
        private readonly IReminderRepository _reminderRepository;

        public ReminderApiController(IReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ReminderGroup>>> AllReminders()
        {
            var reminderGroups = await _reminderRepository.GetAllReminders();
            return Ok(reminderGroups);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reminder>> ReminderById(int id)
        {

            Reminder reminder = await _reminderRepository.GetReminderById(id);
            return Ok(reminder);
        }

        [HttpPost]
        public async Task<ActionResult<Reminder>> AddReminder([FromBody] Reminder reminderModel)
        {

            Reminder reminder = await _reminderRepository.AddReminder(reminderModel);
            return Ok(reminder);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Reminder>> UpdateReminder([FromBody] Reminder reminderModel, int id)
        {
            reminderModel.Id = id;
            Reminder reminder = await _reminderRepository.UpdateReminder(reminderModel, id);
            return Ok(reminder);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Reminder>> SoftDeleteReminder(int id)
        {
            Reminder reminder = await _reminderRepository.SoftDeleteReminder(id);
            return Ok(reminder);
        }
    }
}