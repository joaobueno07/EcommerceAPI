using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        [Key]
        public int Id { get; set; }
        public string Password { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime BirthDay { get; set; }
    }
}
