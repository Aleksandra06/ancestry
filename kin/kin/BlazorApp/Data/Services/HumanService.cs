using kin.BlazorApp.PageModels;
using kin.TreeDB;
using kin.TreeDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kin.BlazorApp.Data.Services
{
    public class HumanService
    {
        private EFRepository<Human> repo;

        public HumanService(TreeDbContext _context)
        {
            repo = new EFRepository<Human>(_context);
        }
        public async Task<List<HumanItemViewModel>> GetAll()
        {
            var result = repo.Get().Select(r => Convert(r)).ToList();
            return await Task.FromResult(result);
        }
        private static HumanItemViewModel Convert(Human r)
        {
            return new HumanItemViewModel(r);
        }
        public void Delete(HumanItemViewModel item)
        {
            var x = repo.FindById(item.IdName);
            repo.Remove(x);
        }
        public void Update(HumanItemViewModel item)
        {
            var x = repo.FindById(item.IdName);
            x.IdName = item.IdName;
            x.MiddleName = item.MiddleName;
            x.Name = item.Name;
            x.Surname = item.Surname;
            repo.Update(x);
        }

        public HumanItemViewModel Create(HumanItemViewModel item)
        {
            var newItem = repo.Create(item.Item);
            return Convert(newItem);
        }
    }
}
