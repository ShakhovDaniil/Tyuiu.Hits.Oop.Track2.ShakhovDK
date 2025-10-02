//Реализация интерфейса заполнения таблицы
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> tasks =
        [
            new() { Id = 1, Title="Задача 1", Description="Описание задачи 1", CreatedDate=DateTime.Now},
            new() { Id = 2, Title="Задача 2", Description="Описание задачи 2", CreatedDate=DateTime.Now},
            new() { Id = 3, Title = "Задача 3", Description = "Описание задачи 3", CreatedDate = DateTime.Now },
        ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            await Task.Delay(1000); // имитация задержки
            return await Task.FromResult(tasks);
        }

        public async Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
