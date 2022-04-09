using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoList _todoList;

        public ToDoListManager(IToDoList todoList)
        {
            _todoList = todoList;
        }

        public ToDoList GetByID(int id)
        {
           return _todoList.GetByID(id);    
        }

        public void TAdd(ToDoList t)
        {
            _todoList.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _todoList.Delete(t);
        }

        public List<ToDoList> TGetAll()
        {
            return _todoList.GetAll();
        }

        public List<ToDoList> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDoList t)
        {
            _todoList.Update(t);
        }
    }
}
