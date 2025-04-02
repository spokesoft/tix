using Tix.Generator.Models;

namespace Tix.Generator.Interfaces;

public interface ISourceCodeService
{
    public IEnumerable<EntityInfo> GetAllEntities();
    public Task<bool> ExistsAsync(string path);
}