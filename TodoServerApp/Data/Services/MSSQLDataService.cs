//Реализация асинхронного заполнения базы данных
using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        //Метод извлечения всех значений свойств из класса TaskItem, описывающий структуру таблицы
        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return await context.TaskItems.ToArrayAsync(); //возвращение набора коллекции объектов TaskItems,
                                                           //выполнение SQL-запроса SELECT * FROM TaskItems и преобразование полученных строк в массив объектов TaskItem
        }

        //Метод сохранения и обновления задачи
        public async Task SaveAsync(TaskItem taskItem)
        {
            if (taskItem.Id == 0) // Проверка: это новая запись?
            {
                taskItem.CreatedDate = DateTime.Now; // Установка даты создания
                await context.TaskItems.AddAsync(taskItem); // Добавление  новой записи
            }
            else
            {
                context.TaskItems.Update(taskItem); // Обновление существующей записи
            }

            await context.SaveChangesAsync(); //Фиксация данных в базе данных
        }

        //Метод извлечения данных 1-ой задачи по её Id
        public async Task <TaskItem> GetTaskAsync(int id)
        {
            return await context.TaskItems.FirstAsync(x => x.Id == id); //SQL - запрос с условием WHERE Id = @id. Он возвращает первую сущность(таблицу),
                                                                        //которая соответствует условию
        }

        //Метод удаления задачи
        public async Task DeleteAsync(int id)
        {
            var taskItem = await context.TaskItems.FirstAsync(x => x.Id == id); //SQL - запрос с условием WHERE Id = @id. Он возвращает первую сущность(таблицу),
                                                                                //которая соответствует условию
            context.TaskItems.Remove(taskItem); //Удаление записи
            await context.SaveChangesAsync(); //Фиксация данных в базе данных
        }
    }
}
