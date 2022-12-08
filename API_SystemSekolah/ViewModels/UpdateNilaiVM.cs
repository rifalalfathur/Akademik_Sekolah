namespace API_SystemSekolah.ViewModels
{
    public class UpdateNilaiVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public  int Id_jadwal { get; set; }
        public int Id_Matpel { get; set; }
        public int Id_Nilai { get; set; }
        //public int Kelas { get; set; }
        public int Nilai_Harian { get; set; }
        public int Nilai_UTS { get; set; }
        public int Nilai_UAS { get; set; }
        public int Nilai_rata_rata { get; set; }

    }
}
