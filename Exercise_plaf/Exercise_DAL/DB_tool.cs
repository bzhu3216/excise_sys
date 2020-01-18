using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DAL
{
    public class DB_tool
    {

        public int Addstudent(StudInfo1 student)
        {
            try
            {
                Exercise_ERContainer cn = new Exercise_ERContainer();
                cn.StudInfo1Set.Add(student);
                cn.SaveChanges();
                return 1;
            }
            //catch (DbEntityValidationException ex)
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


     }//endclass
    }
