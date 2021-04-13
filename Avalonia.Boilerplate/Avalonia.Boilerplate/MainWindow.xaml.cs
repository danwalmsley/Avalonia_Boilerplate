using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Avalonia.Boilerplate {
    public class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            
            popup = new Window();
            popup.Focusable = false;
            popup.ShowActivated = false;
            popup.Width = 100;
            popup.Height = 100;
            popup.Position = new PixelPoint(500, 200);
            popup.Show();
            popup.Hide();
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }

        private Window popup;
        
        private void InputElement_OnPointerEnter(object? sender, PointerEventArgs e)
        {
            popup.Show();
        }

        private void InputElement_OnPointerLeave(object? sender, PointerEventArgs e)
        {
            popup.Hide();
        }
    }
}
