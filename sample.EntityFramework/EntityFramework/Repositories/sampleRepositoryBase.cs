using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace sample.EntityFramework.Repositories
{
    public abstract class sampleRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<sampleDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected sampleRepositoryBase(IDbContextProvider<sampleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class sampleRepositoryBase<TEntity> : sampleRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected sampleRepositoryBase(IDbContextProvider<sampleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
