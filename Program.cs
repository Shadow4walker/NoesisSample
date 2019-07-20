using System;

namespace ConsoleApp1
{
    class Program
    {
        static App app;

        public static void Main(string[] args)
        {
            app = new App() { Uri = "App.xaml", StartupUri = "MainWindow.xaml" };
            app.Run();
        }
    }
}
