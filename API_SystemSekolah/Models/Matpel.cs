using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_SystemSekolah.Models
{
    public class Matpel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Id_Kelas { get; set; }

        public int Id_Guru { get; set; }

        [ForeignKey("Id_Kelas")]
        [JsonIgnore]
        public Kelas? Kelass { get; set; }

        [ForeignKey("Id_Guru")]
        [JsonIgnore]
        public Guru? Guru { get; set; }
    }
}
