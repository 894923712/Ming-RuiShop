using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MRShop.EntityFramework.Repositories
{
    public abstract class MRShopRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MRShopDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MRShopRepositoryBase(IDbContextProvider<MRShopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MRShopRepositoryBase<TEntity> : MRShopRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MRShopRepositoryBase(IDbContextProvider<MRShopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
