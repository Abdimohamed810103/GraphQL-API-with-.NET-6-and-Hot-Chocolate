using System.ComponentModel.DataAnnotations;
using CommanderDB.Model;

namespace CommanderDb.Model
{
    public class Macmiilka
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CommanderId { get; set; }
        
        public Commander commander { get; set; }
    }
}