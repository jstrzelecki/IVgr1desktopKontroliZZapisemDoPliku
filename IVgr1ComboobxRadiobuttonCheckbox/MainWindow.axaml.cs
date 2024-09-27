using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace IVgr1ComboobxRadiobuttonCheckbox;

public partial class MainWindow : Window
{
    private List<RadioButton> _group2RadioButtons;
    public MainWindow()
    {
        InitializeComponent();
        SubmitButton.Click += SubmitButton_Click;
        _group2RadioButtons = new()
        {
            Radio4,
            Radio5,
            Radio6
        };

    }

    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        try
        {
            var checkBoxValue = MyCheckBox.IsChecked == true ? "Zaznaczono" : "NIE zaznaczono";
            
            // radiobutton grupa 1
            var radiobuttonValue = Radio1.IsChecked == true ? Radio1.Content : Radio2.Content;
            
            //radiobutton grupa 2
            
            
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}