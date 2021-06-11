using System.Threading.Tasks;

namespace ELSA.Demo.Data
{
    public interface IDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
