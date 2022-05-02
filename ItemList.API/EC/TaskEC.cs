using Api.ToDoApplication.Persistence;
using ItemList.API.Database;
using Library.CIS4930.Standard.DTO;
using CIS4930.models;
using CIS4930.services;

namespace ItemList.API.EC
{
    public class TaskEC
    {
        public IEnumerable<TaskDTO> Get()
        {
            return FakeDatabase.Tasks.Select(t => new TaskDTO(t));
            //return Filebase.Current.ToDos.Select(t => new TaskDTO(t));
        }

        public TaskDTO AddOrUpdate(TaskDTO todo)
        {
            if (todo.Id <= 0)
            {
                //CREATE
                todo.Id = ItemService.Current.nextId;
                FakeDatabase.Tasks.Add(new Task(todo));
                //Filebase.Current.AddOrUpdate(new Task(task));
            }
            else
            {
                //UPDATE
                var itemToUpdate = FakeDatabase.Tasks.FirstOrDefault(i => i.Id == todo.Id);
                if (itemToUpdate != null)
                {
                    var index = FakeDatabase.Tasks.IndexOf(itemToUpdate);
                    FakeDatabase.Tasks.Remove(itemToUpdate);
                    FakeDatabase.Tasks.Insert(index, new Task(task));
                }
                else
                {
                    //CREATE -- Fall-Back
                    FakeDatabase.Tasks.Add(new Task(task));
                }
            }

            return todo;
        }

        public TaskDTO Delete(int id)
        {
            var todoToDelete = FakeDatabase.Tasks.FirstOrDefault(i => i.Id == id);
            if (todoToDelete != null)
            {
                FakeDatabase.Tasks.Remove(todoToDelete);
            }

            return new TaskDTO(todoToDelete);
        }
}
