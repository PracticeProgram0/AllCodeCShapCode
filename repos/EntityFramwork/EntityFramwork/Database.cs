using EntityFramwork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramwork
{
    public class Database
    {
        // insert data in database  
        public int DataInsert(Student data)
        {
            using (var DbContext = new VIVEKEntities())
            {
                var entityData = new MVCBatch()
                {
                    Name = data.Name,
                    Age = data.Age,
                    Phone = data.Phone,
                };
                DbContext.MVCBatches.Add(entityData);
                int result = DbContext.SaveChanges();
                return result;
            }
        }
        // Accessing All data  in table

        public List<MVCBatch> SelectAllData()
        {

            using (var DbContext = new VIVEKEntities())
            {
                var data = DbContext.MVCBatches.ToList();
                return data;
            }
        }
        // Accessing only one data through id in table
        public MVCBatch SelectData(int id)
        {
            using (var DbContext =new VIVEKEntities())
            {
                var data= DbContext.MVCBatches.Where(x=>x.ID==id).FirstOrDefault();
                return data;
            }
        }
        public int UpdateData(MVCBatch userData)
        {
            using (var DbContext =new VIVEKEntities())
            {
                var data=SelectData(userData.ID);   
                if (data != null)
                {
                    data.Name = userData.Name;
                    data.Age = userData.Age;    
                    data.Phone = userData.Phone;
                    DbContext.MVCBatches.AddOrUpdate(data);
                    int i=DbContext.SaveChanges();
                    return i;
                }
            }
                return 0;
        }
        public int DeleteData(int id)
        {
            using (var DbContext = new VIVEKEntities())
            {
                var data = DbContext.MVCBatches.Find(id);
                if (data != null)
                {
                    DbContext.MVCBatches.Remove(data); 
                }
                return DbContext.SaveChanges();
            } 
        }
    }


}