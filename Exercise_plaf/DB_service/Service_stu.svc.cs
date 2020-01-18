using Exercise_DAL;
using System;
using System.Collections.Generic;
//using ConsoleApp2;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Validation;

namespace DB_service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService_stu
    {
       public int Addstu(StudInfo1 stud1)
        {
            DB_tool dbtool = new DB_tool();        

             return dbtool.Addstudent(stud1);

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }

    
}
