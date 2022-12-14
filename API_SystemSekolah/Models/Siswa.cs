using System.ComponentModel.DataAnnotations;

namespace API_SystemSekolah.Models
{
    public class Siswa
    {
        [Key]
        public int NIS { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Place_Of_Birth { get; set; }

        public string Date_Of_Birth { get; set; }

        public string Address { get; set; }

        public string NoTelp { get; set; }

        public string Email { get; set; }

        public string Mother_Name { get; set; }

        public string Password { get; set; }
    }
}
