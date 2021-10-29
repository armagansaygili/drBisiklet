using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doktorBisiklet
{
    static class Program
    {
        [STAThread]
        static void Main()
        {


            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.GetType().GUID.ToString());

            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            var id = attribute.Value;

            using (Mutex mutex = new Mutex(false, "Global\\" + id))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Program zaten çalışıyor");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new drBisikletHome());
            }

        }
    }
}
