using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace FoxReadingSystem.EntityFramework.Repositories
{
    public abstract class FoxReadingSystemRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<FoxReadingSystemDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected FoxReadingSystemRepositoryBase(IDbContextProvider<FoxReadingSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class FoxReadingSystemRepositoryBase<TEntity> : FoxReadingSystemRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected FoxReadingSystemRepositoryBase(IDbContextProvider<FoxReadingSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
