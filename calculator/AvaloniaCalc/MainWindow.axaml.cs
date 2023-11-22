using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaCalc;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Number_OnClick(object? sender, RoutedEventArgs e)
    {
        var button = sender as Button;

        if (labelResult.Text == "0")
            labelResult.Text = string.Empty;

        labelResult.Text += button?.Content?.ToString();
    }
}
