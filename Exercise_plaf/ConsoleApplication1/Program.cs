using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_DAL;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            StudINfo student1 = new StudINfo();
            student1.Id = "33333333333";
           // student1.name = "asdfdsf";
           // student1.pd = "sadfdsf";
            try
            {


                Exercise_ERContainer cn = new Exercise_ERContainer();
                cn.StudINfoSet.Add(student1);
                cn.SaveChanges();
            }

            catch (DbEntityValidationException ex)
            {

                List<string> errorMessages = new List<string>();
                foreach (DbEntityValidationResult validationResult in ex.EntityValidationErrors)
                {
                    string entityName = validationResult.Entry.Entity.GetType().Name;
                    foreach (DbValidationError error in validationResult.ValidationErrors)
                    {
                        errorMessages.Add(entityName + "." + error.PropertyName + ": " + error.ErrorMessage);
                    }
                }
                foreach (string aa in errorMessages)
                {

                    Console.WriteLine(aa);
                    Console.ReadLine();


                }
            }













        }
    }
}
