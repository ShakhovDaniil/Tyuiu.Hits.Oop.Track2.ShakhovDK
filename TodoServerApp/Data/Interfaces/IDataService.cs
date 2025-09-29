//Объявление интерфейса заполнения таблицы
namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
    }
}
