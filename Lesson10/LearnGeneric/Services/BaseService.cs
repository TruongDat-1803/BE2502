using LearnGeneric.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGeneric.Services
{
    public abstract class BaseService<TCreateVm, TUpdateVm, TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        public abstract void Add(TCreateVm model);
        public abstract void Update(TUpdateVm model);
        public abstract void Delete(TKey id);
        public abstract List<TEntity> Search(string keyWord);
    }
}
