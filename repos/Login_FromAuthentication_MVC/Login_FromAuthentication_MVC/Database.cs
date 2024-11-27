using Login_FromAuthentication_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace Login_FromAuthentication_MVC
{
    public class Database
    {
        // insert data in database  
        public int DataInsert(Registration data)
        {
            using (var DbContext = new VIVEKEntities())
            {
                var entityData = new RegistrationData()
                {
                    Name = data.Name,
                    Email = data.Email,
                    Phone=data.Phone,
                    Gender=data.Gender,
                    DOB = data.DOB,
                    Address=data.Address,
                    City=data.City,
                    Zip= data.Zip,
                    Password=data.Password,
                };
                DbContext.RegistrationDatas.Add(entityData);
                int result = DbContext.SaveChanges();
                return result;
            }
        }


        public RegistrationData LoginData(Login data)
        {
            using (var DbContext = new VIVEKEntities())
            {
                var user = DbContext.RegistrationDatas.FirstOrDefault(x => x.Email == data.UserName && x.Password ==data.Password);
                return user;
            }
        }


        // Accessing All data  in table

        //public List<MVCBatch> SelectAllData()
        //{

        //    using (var DbContext = new VIVEKEntities())
        //    {
        //        var data = DbContext.MVCBatches.ToList();
        //        return data;
        //    }
        //}
        //Accessing only one data through id in table

        //public int UpdateData(MVCBatch userData)
        //{
        //    using (var DbContext = new VIVEKEntities())
        //    {
        //        var data = SelectData(userData.ID);
        //        if (data != null)
        //        {
        //            data.Name = userData.Name;
        //            data.Age = userData.Age;
        //            data.Phone = userData.Phone;
        //            DbContext.MVCBatches.AddOrUpdate(data);
        //            int i = DbContext.SaveChanges();
        //            return i;
        //        }
        //    }
        //    return 0;
        //}
        //public int DeleteData(int id)
        //{
        //    using (var DbContext = new VIVEKEntities())
        //    {
        //        var data = DbContext.MVCBatches.Find(id);
        //        if (data != null)
        //        {
        //            DbContext.MVCBatches.Remove(data);
        //        }
        //        return DbContext.SaveChanges();
        //    }
        //}
    }
}