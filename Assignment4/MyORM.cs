using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MyORM<G, T> where T: new()
    {
        private readonly T _t;
        public MyORM()
        {
            _t = new T();
        }
        public void Insert(T item)
        {
            InsertOperation insert = new InsertOperation();
            insert.InsertObjectIntoDb(item, null, null);
        }
        public void Update(T item)
        {
            UpdateOperation update = new UpdateOperation();
            update.UpdateObjectInDb(item, null, null);
        }
        public void Delete(T item)
        {
            DeleteOperation<T> delete = new DeleteOperation<T>(_t);
            delete.DeleteObject(item, null, null);
        }
        public void Delete(G id)
        {
            DeleteOperation<T> delete = new DeleteOperation<T>(_t);
            //delete.DeleteObjectById(id, null);
        }
        public void GetById(G id)
        {
            //DataExtractor.ExtractData(id, null);
        }
        public void GetAll()
        {

        }

    }
}
