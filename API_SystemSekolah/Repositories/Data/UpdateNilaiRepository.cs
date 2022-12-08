using API_SystemSekolah.Context;
using API_SystemSekolah.Models;
using API_SystemSekolah.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Data;
using System.Security.Claims;

namespace API_SystemSekolah.Repositories.Data
{
    public class UpdateNilaiRepository
    {
        private MyContext context;
        public UpdateNilaiRepository(MyContext context)
        {
            this.context = context;
        }

        public IEnumerable Get(int IdGuru)
        {
            //var dataId = context.Siswas.Include(x => x.).Include(x => x.Roless));
            //var nilai = new List<string>();

            var query = (from nilai in context.Nilais
                         join matpel in context.Matpels on nilai.Id_Matpel equals matpel.Id
                         join siswa in context.Siswas on nilai.NIS_Siswa equals siswa.NIS
                         join guru in context.Gurus on matpel.Id_Guru equals guru.Id
                         join kelas in context.Kelass on matpel.Id_Kelas equals kelas.Id

                         where guru.Id== IdGuru

                         //join kelas in context.Kelass on sis.Id_Kelas equals kelas.Id
                         //join jadwal in context.JadwalMatpels on kelas.Id equals jadwal.Id_Kelas
                         //join study in context.Matpels on jadwal.Id equals study.Id_Jadwal
                         //join guru in context.Gurus on study.Id equals guru.Id_Matpel
                         //where guru.Id == IdGuru
                         select new
                         {
                             nama = siswa.Name,
                             kelas = kelas.Name,
                             id_guru = matpel.Id_Guru,
                             Id_nilai = nilai.Id,
                             Id_siswa = nilai.NIS_Siswa,
                             Id_matpel = nilai.Id_Matpel,
                             matpel = matpel.Name,
                             nilai_harian = nilai.Nilai_Harian,
                             nilai_Uts = nilai.Nilai_UTS,
                             nilai_Uas = nilai.Nilai_UAS,
                             nilai_ratarata = nilai.Nilai_rata_rata

                         }).ToList();

            return query;

        }
        public IEnumerable GetbySiswa(int id, int id_guru)
        {
            var query = (from nilai in context.Nilais
                         join matpel in context.Matpels on nilai.Id_Matpel equals matpel.Id
                         join siswa in context.Siswas on nilai.NIS_Siswa equals siswa.NIS
                         join guru in context.Gurus on matpel.Id_Guru equals guru.Id
                         join kelas in context.Kelass on matpel.Id_Kelas equals kelas.Id

                         where nilai.NIS_Siswa == id && matpel.Id_Guru == id_guru

                         //join kelas in context.Kelass on sis.Id_Kelas equals kelas.Id
                         //join jadwal in context.JadwalMatpels on kelas.Id equals jadwal.Id_Kelas
                         //join study in context.Matpels on jadwal.Id equals study.Id_Jadwal
                         //join guru in context.Gurus on study.Id equals guru.Id_Matpel
                         //where guru.Id == IdGuru
                         select new
                         {
                             nama = siswa.Name,
                             kelas = kelas.Name,
                             id_guru = matpel.Id_Guru,
                             Id_nilai = nilai.Id,
                             Id_siswa = nilai.NIS_Siswa,
                             Id_matpel = nilai.Id_Matpel,
                             matpel = matpel.Name,
                             nilai_harian = nilai.Nilai_Harian,
                             nilai_Uts = nilai.Nilai_UTS,
                             nilai_Uas = nilai.Nilai_UAS,
                             nilai_ratarata = nilai.Nilai_rata_rata

                         }).ToList();

            return query;


        }

    }
    
}
