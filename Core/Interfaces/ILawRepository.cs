using Core.Entity;

namespace Core.Interfaces
{
    public interface ILawRepository
    {
        Task<Law> GetLawByIdAsync(int id);
        Task<IReadOnlyList<Law>> GetLawsAsync();
    }
}