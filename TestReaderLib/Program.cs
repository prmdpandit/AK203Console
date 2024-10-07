using AK203.Repository;
using ModuleReader;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace RFID_MoudleReader
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
            Application.Run(container.Resolve<frmLogin>());

            
            //Application.Run(new frmLogin());
        }
    }
}
