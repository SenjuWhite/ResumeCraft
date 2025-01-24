namespace ResumeCraft_API.Services.IServices
{
    public interface IResumeSectionService<T> where T : class
    {
        Task AddAsync(T item);
        Task DeleteAsync(int itemId);
        Task UpdateAsync(T item );
    }
}
