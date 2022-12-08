using API_SystemSekolah.Context;
using API_SystemSekolah.Models;
using Microsoft.EntityFrameworkCore;

namespace API_SystemSekolah.Repositories.Data
{
    public class NilaiRepository
    {
        private MyContext context;

        public NilaiRepository(MyContext myContext)
        {
            context = myContext;
        }
        public int Delete(int Id)
        {
            var data = context.Nilais.Find(Id);
            if (data != null)
            {
                context.Remove(data);
                var result = context.SaveChanges();
                return result;
            }
            return 0;
        }

        public IEnumerable<Nilai> Get()
        {
            return context.Nilais.ToList();
        }

        public Nilai Get(int Id)
        {
            return context.Nilais.Find(Id);
        }

        public int Create(Nilai nilai)
        {
            context.Nilais.Add(nilai);
            var result = context.SaveChanges();
            return result;
        }

        public int Update(Nilai nilai)
        {
            context.Entry(nilai).State = EntityState.Modified;
            var result = context.SaveChanges();
            return result;
        }
    }
}
