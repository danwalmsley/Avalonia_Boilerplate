using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Chrome;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using System.Threading.Tasks;

namespace Avalonia.Boilerplate {
    public class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Position = new PixelPoint((int)-8,(int)-8);
            Width = Screens.Primary.WorkingArea.Width+ 16;
            Height = Screens.Primary.WorkingArea.Height + 16;
            WindowState = WindowState.Maximized;

#if DEBUG
            this.AttachDevTools();
#endif
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e) {
            base.OnApplyTemplate(e);

            

        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
            //var button = this.FindControl<Button>("MyButton");
            //button.Click += Button_Click;  
        }

        private async void Button_Click(object? sender, Interactivity.RoutedEventArgs e)
        {
            //this.WindowState = WindowState.Minimized;
            //await Task.Delay(3000);
            var appWindow = new MyWindow();
            appWindow.WindowState = WindowState.Maximized;
            //appWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            appWindow.Show();
        }
    }
}
