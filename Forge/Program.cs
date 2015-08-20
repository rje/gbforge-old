using System;
using Xwt;

namespace gbforge.Forge
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Initialize();
            var win = new MainWindow();
            win.Show();
            Application.Run();
            win.Dispose();
        } 
    }
}