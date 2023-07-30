using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("reminder")]
    public class Reminder
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }
        public bool Is_Deleted { get; set; }

        public Reminder(string name, DateTime date)
        {
            this.Name = name ?? throw new ArgumentNullException("O nome do lembrete não pode ser nulo ou vazio.", nameof(name));
            this.Date = date;
        }
    }
}