using ResumeCraft_API.Models;
using ResumeCraft_API.Models.Interfaces;

namespace ResumeCraft_API.Services.IServices
{
    public interface IResumeSectionService
    {
        Task AddAsync<T>(T item);
        Task DeleteAsync<T>(int itemId);
        //Task UpdateAsync<T, TDto>(ICollection<T> existingEntities, List<TDto> newEntitiesDto);
        Task UpdateAsync<T, TDto>(ICollection<T> existingEntities, List<TDto> newEntitiesDto) 
            where T : IIdentifiable<int>
            where TDto : IIdentifiable<int?>;

    }
}
