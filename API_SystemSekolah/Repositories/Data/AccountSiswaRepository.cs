using API.Handlers;
using API_SystemSekolah.Context;
using API_SystemSekolah.Models;
using API_SystemSekolah.Repositories.Interface;
using API_SystemSekolah.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace API_SystemSekolah.Repositories.Data
{
    public class AccountSiswaRepository : IAccountSiswaRepository
    {
        private MyContext context;
        public AccountSiswaRepository(MyContext context)
        {
            this.context = context;
        }
        public int ChangePassword(LoginSiswaViewModel login, string baru)
        {
            var data = context.Siswas.FirstOrDefault(option => option.Email.Equals(login.Email));
            var has = Hashing.validatePassword(login.Password, data.Password);
            if (data != null)
            {
                data.Password = Hashing.HashPassword(baru);
                context.Entry(data).State= EntityState.Modified;
                var result = context.SaveChanges();
                return result;
            }
            return 0;

        }

        public int ForgotPassword(LoginSiswaViewModel login, string baru)
        {
            var data = context.Siswas.FirstOrDefault(option => option.Email.Equals(login.Email) );
            if (data != null && login.Password==baru)
            {
                data.Password = Hashing.HashPassword(login.Password);
                context.Entry(data).State= EntityState.Modified;
                var result = context.SaveChanges();
                return result;


            }
            return 0;
        }

        public Siswa Login(LoginSiswaViewModel login)
        {
            var data = context.Siswas.FirstOrDefault(option =>
            option.Email.Equals(login.Email));
            if (data !=null && Hashing.validatePassword(login.Password, data.Password))
            {
                return data;
            }
            return null;
        }
    }
}
