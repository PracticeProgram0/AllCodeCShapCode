using Entity_framework_insert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Entity_framework_insert
{
    public class datalayer
    {

        public void Index(Student data)
        {
            using (var btpsContext = new btpsEntities())         //btps (database) ka object
            {
                var entity = new Entity                    //table (Entity) ka object
                {
                    name = data.name,
                    age = data.age,
                    phone = data.phone,
                };
                btpsContext.Entities.Add(entity);
                int result = btpsContext.SaveChanges();

     
            }

        }
    }
}