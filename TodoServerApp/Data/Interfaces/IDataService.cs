//Интерфейс работы с таблицами
namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        //Получение всех значений
        Task<IEnumerable<TaskItem>> GetAllAsync();

        //Сохранение\обновление задачи
        Task SaveAsync(TaskItem item);

        //Извлечение задачи по её идентификатору Id
        Task<TaskItem> GetTaskAsync(int id);

        //Удаление задачи
        Task DeleteAsync(int id);
    }
}
