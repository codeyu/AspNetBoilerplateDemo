using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CodeYu.AspNetBoilerplateDemo.EntityFramework.Repositories
{
    public abstract class AspNetBoilerplateDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AspNetBoilerplateDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AspNetBoilerplateDemoRepositoryBase(IDbContextProvider<AspNetBoilerplateDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AspNetBoilerplateDemoRepositoryBase<TEntity> : AspNetBoilerplateDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AspNetBoilerplateDemoRepositoryBase(IDbContextProvider<AspNetBoilerplateDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
