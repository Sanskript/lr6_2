using System.ComponentModel.DataAnnotations;

namespace lr6_2.Models
{
    public class User
    {
        public int Id { get; set; }
         
        public string Name { get; set; }

        public int Age { get; set; }
          
        public int ProductCount { get; set; }
    }
}
