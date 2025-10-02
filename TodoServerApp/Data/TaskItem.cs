//Реализация класса для заполнения данных таблицы
using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class TaskItem
    {
        //Идентификатор Id
        public int Id { get; set; }
        [Required]

        //Заголовок Title
        public string? Title { get; set; }
        [Required]

        //Описание Description
        public string? Description { get; set; }

        //Дата создания CreatedDate
        public DateTime? CreatedDate { get; set; }

        //Дата завершения FinishDate
        public DateTime? FinishDate { get; set; }

    }
}
