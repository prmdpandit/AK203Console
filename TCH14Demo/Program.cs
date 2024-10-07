using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;
using Unity;
using AK203.Repository;


namespace TM200Demo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new UnityContainer();

            // Register DbContext and UnitOfWork with Unity container
            container.RegisterType<Ak203DbContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<MainWindow>());
           // Application.Run(new MainWindow());
            System.Environment.Exit(0);
  
            //int lpm = int.Parse("babdbad", System.Globalization.NumberStyles.HexNumber);
        }
    }
}
