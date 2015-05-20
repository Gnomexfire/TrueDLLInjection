using System.Diagnostics;
using System.Windows.Forms;

namespace ExampleProject 
{
    public class Example
    {
        public static int EntryPoint(string args)
        {
            var proc = Process.GetCurrentProcess().ProcessName;
            MessageBox.Show(@"Process  is : " + proc);
            if (args != null)
            {
                MessageBox.Show(args);
            }
            return 0;
        }
    }
}
