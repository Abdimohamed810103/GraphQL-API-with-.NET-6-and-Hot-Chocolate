using System.ComponentModel.DataAnnotations;
using CommanderDb.Model;

namespace CommanderDB.Model
{
    public class Commander
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public ICollection<Macmiilka> Macmiilkas { get; set; } = new List<Macmiilka>();
    }
}