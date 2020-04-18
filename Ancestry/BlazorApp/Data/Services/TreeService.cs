using Ancestry.BlazorApp.PageModels;
using Ancestry.AncestryDB;
using Ancestry.AncestryDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ancestry.BlazorApp.Data.Services
{
    public class TreeService
    {
        private EFRepository<Tree> repo;

        public TreeService(TreeDbContext _context)
        {
            repo = new EFRepository<Tree>(_context);
        }
        public async Task<List<TreeItemViewModel>> GetAll()
        {
            var result = repo.Get().Select(r => Convert(r)).ToList();
            return await Task.FromResult(result);
        }
        private static TreeItemViewModel Convert(Tree r)
        {
            return new TreeItemViewModel(r);
        }
        public void Delete(TreeItemViewModel item)
        {
            var x = repo.FindById(item.IdNode);
            repo.Remove(x);
        }
        public void Update(TreeItemViewModel item)
        {
            var x = repo.FindById(item.IdNode);
            x.MotherId = item.MotherId;
            x.FatherId = item.FatherId;
            x.NodeId = item.NodeId;
            repo.Update(x);
        }

        public TreeItemViewModel Create(TreeItemViewModel item)
        {
            var newItem = repo.Create(item.Item);
            return Convert(newItem);
        }
    }
}
