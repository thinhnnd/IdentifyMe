﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IdentifyMe.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomAppShell : Shell
    {
        public BottomAppShell()
        {
            InitializeComponent();
        }
    }
}