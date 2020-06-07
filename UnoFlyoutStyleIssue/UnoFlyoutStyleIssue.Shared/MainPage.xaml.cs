// <copyright file="MainPage.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2020 All rights reserved</copyright>

namespace UnoFlyoutStyleIssue
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using Vssl.Samples.Framework;
    using Vssl.Samples.ViewModelInterfaces;
    using Vssl.Samples.ViewModels;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Navigation;

    // The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
            var dispatcher = new UIDispatcher();
            dispatcher.Initialize();
            DispatchHelper.Initialise(dispatcher);
            this.DataContext = new MainViewModel();
        }

        /// <summary>
        /// Gets the data context as the interface to the view model for compile time binding
        /// </summary>
        public IMainViewModel VM
        {
            get
            {
                return this.DataContext as IMainViewModel;
            }
        }

        /// <summary>
        /// Event handler for primary command click
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.VM.Start();
        }
    }
}
