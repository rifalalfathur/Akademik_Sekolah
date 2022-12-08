using API_SystemSekolah.Models;
using API_SystemSekolah.ViewModels;

namespace API_SystemSekolah.Repositories.Interface
{
    public interface IAccountSiswaRepository
    {
        public Siswa Login(LoginSiswaViewModel login);
        //public int Register(string fullName, string email, string password, DateTime birthDate);
        public int ChangePassword(LoginSiswaViewModel login, string baru);
        public int ForgotPassword(LoginSiswaViewModel login, string baru);
    }
}
