using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;
using System.Diagnostics;

namespace Exercise_plaf
{
    /// <summary>
    /// studentinfo.xaml 的交互逻辑
    /// </summary>
    public partial class studentinfo : Window
    {
        ObservableCollection<Student> studentlist;

        public studentinfo()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //导入学生名单
            String dirup = null;
            Process[] procs = Process.GetProcessesByName("EXCEL");
            foreach (Process pro in procs)
            {
                pro.Kill();//没有更好的方法,只有杀掉进程
            }
            GC.Collect();
            /*  FolderBrowserDialog dialog = new FolderBrowserDialog();
              dialog.Description = "请选择文件路径";

              if (dialog.ShowDialog() == DialogResult.OK)
              {
                  string foldPath = dialog.SelectedPath;
                  dirup = foldPath;
                  //button2.Enabled = true;
              }*/

            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.DefaultExt = ".xlsx";
            ofd.Filter = "xlsx file|*.xlsx";
            if (ofd.ShowDialog() == true)
            {
                dirup = ofd.FileName;
               DB_exceltool.getstudentsfromexcel(dirup);
                studentlist = DB_exceltool.studentList;
                if (studentlist.Count != 0)
                  
                // ((this.FindName("DG1")) as DataGrid).ItemsSource = peopleList;
                DG1.ItemsSource = studentlist;

            }



            //end 导入


        }
    }
}
