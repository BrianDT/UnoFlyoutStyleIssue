// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2020 All rights reserved</copyright>

namespace Vssl.Samples.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Vssl.Samples.Framework;
    using Vssl.Samples.ViewModelInterfaces;

    /// <summary>
    /// The view model for the main page
    /// </summary>
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class
        /// </summary>
        public MainViewModel()
        {
            this.StartCommand = new DelegateCommandAsync(this.OnCommand1Actioned, (o) => true);
            this.ShowObjectivesCommand = new DelegateCommandAsync(this.OnCommand2Actioned, (o) => true);
            this.SwitchModelCommand = new DelegateCommandAsync(this.OnCommand3Actioned, (o) => true);
        }

        /// <summary>
        /// Gets the Settings command
        /// </summary>
        public ICommand StartCommand { get; private set; }

        /// <summary>
        /// Gets a sample show section command
        /// </summary>
        public ICommand ShowObjectivesCommand { get; private set; }

        /// <summary>
        /// Gets the switch model command
        /// </summary>
        public ICommand SwitchModelCommand { get; private set; }

        /// <summary>
        /// Gets the text used to indicate that the primary command was clicked
        /// </summary>
        public string PrimaryClicked { get; private set; }

        /// <summary>
        /// Gets the text used to indicate that the primary command was actioned
        /// </summary>
        public string PrimaryCommand { get; private set; }

        /// <summary>
        /// Start by click
        /// </summary>
        public void Start()
        {
            this.PrimaryClicked = "Clicked";
            this.OnPropertyChanged("PrimaryClicked");
        }

        /// <summary>
        /// The execution handler for the primary Command
        /// </summary>
        /// <param name="parameter">Optional parameters</param>
        /// <returns>An awaited task</returns>
        private async Task OnCommand1Actioned(object parameter)
        {
            this.PrimaryCommand = "Settings actioned";
            this.OnPropertyChanged("PrimaryCommand");
            await Task.CompletedTask;
        }

        /// <summary>
        /// The execution handler for the secondary Command
        /// </summary>
        /// <param name="parameter">Optional parameters</param>
        /// <returns>An awaited task</returns>
        private async Task OnCommand2Actioned(object parameter)
        {
            this.PrimaryCommand = "Show detail actioned";
            this.OnPropertyChanged("PrimaryCommand");
            await Task.CompletedTask;
        }

        /// <summary>
        /// The execution handler for the flyout Command
        /// </summary>
        /// <param name="parameter">Optional parameters</param>
        /// <returns>An awaited task</returns>
        private async Task OnCommand3Actioned(object parameter)
        {
            this.PrimaryCommand = $"Switch model to {parameter as string} actioned";
            this.OnPropertyChanged("PrimaryCommand");
            await Task.CompletedTask;
        }
    }
}
