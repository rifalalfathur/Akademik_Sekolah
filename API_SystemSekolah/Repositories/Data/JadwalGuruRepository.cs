using API_SystemSekolah.Context;
using System.Collections;

namespace API_SystemSekolah.Repositories.Data
{
    public class JadwalGuruRepository
    {
        private MyContext context;
        public JadwalGuruRepository(MyContext context)
        {
            this.context = context;
        }

        public IEnumerable GetJadwal(int IdGuru)
        {
            //var dataId = context.Siswas.Include(x => x.).Include(x => x.Roless));
            //var nilai = new List<string>();
            var query = (
                           //from nilai in context.Nilais
            //             join matpel in context.Matpels on nilai.Id_Matpel equals matpel.Id
            //             join siswa in context.Siswas on nilai.NIS_Siswa equals siswa.NIS
            //             join guru in context.Gurus on matpel.Id_Guru equals guru.Id
            //             join kelas in context.Kelass on matpel.Id_Kelas equals kelas.Id
                         
                         from jadwal in context.JadwalMatpels
                         join matpel in context.Matpels on jadwal.Id_Matpel equals matpel.Id
                         join guru in context.Gurus on matpel.Id_Guru equals guru.Id
                         join kelas in context.Kelass on matpel.Id_Kelas equals kelas.Id
                         
                         //var query = (from sis in context.Siswas
                         //             join kelas in context.Kelass on sis.Id_Kelas equals kelas.Id
                         //             join jadwal in context.JadwalMatpels on kelas.Id equals jadwal.Id_Kelas
                         //             join study in context.Matpels on jadwal.Id equals study.Id_Jadwal
                         //             join guru in context.Gurus on study.Id equals guru.Id_Matpel
                         where guru.Id == IdGuru
                         select new
                         {
                             //nama= sis.Siswas_Name,
                             IdGuru = guru.Id,
                             kelas = kelas.Name,
                             jadwal_day = jadwal.Day,
                             jadwal_hours = jadwal.Hours,
                             matpel = matpel.Name,
                             //nilai_harian = study.Nilai_Harian,
                             //nilai_Uts = study.Nilai_UTS,
                             //nilai_Uas = study.Nilai_UAS,
                             //nilai_ratarata = study.Nilai_rata_rata

                             //table = sis.Siswas_Name,
                             //kelas.Kelas_Name,
                             //jadwal.Day,
                             //jadwal.Hours,
                             //study.Matpel_Name,
                             //study.Nilai_Harian,
                             //study.Nilai_UAS,
                             //study.Nilai_UTS,
                             //study.Nilai_rata_rata
                         }).ToList();

            return query;
        }
    }
}
