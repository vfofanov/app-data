using System.Linq;

namespace Stenn.AppData.Contracts
{
    public interface IAppDataService<in TBaseEntity> : IAppDataService
        where TBaseEntity : IAppDataEntity
    {
        IQueryable<T> Query<T>() where T : class, TBaseEntity;
    }

    public interface IAppDataService
    {
    }
}