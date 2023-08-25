using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _todolistdal;

        public ToDoListManager(IToDoListDal todolistdal)
        {
            _todolistdal = todolistdal;
        }

        public void TAdd(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetList(ToDoList t)
        {
            return _todolistdal.GetList();
        }

        public List<ToDoList>? TGetList()
        {
            return _todolistdal.GetList();
        }

        public List<ToDoList> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDoList t)
        {
            throw new NotImplementedException();
        }
    }
}
