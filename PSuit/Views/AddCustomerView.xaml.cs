﻿using Microsoft.Practices.Prism.Mvvm;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;

namespace PSuite.Views
{
    [Export("AddCustomerView", typeof(IView))]
    public partial class AddCustomerView : Window, IView
    {
        public AddCustomerView()
        {
            InitializeComponent();
        }
    }
}
