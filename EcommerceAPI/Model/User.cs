using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime BirthDay { get; set; }
        public string Identity { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
