using System.ComponentModel.DataAnnotations;

namespace MVCDay1.DAL.Entities
{
	public class Employee
	{
        [Key]
        public int ID { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
