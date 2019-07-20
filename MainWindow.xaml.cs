using NoesisApp;

namespace ConsoleApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Noesis.GUI.LoadComponent(this, "MainWindow.xaml");
        }
    }
}
