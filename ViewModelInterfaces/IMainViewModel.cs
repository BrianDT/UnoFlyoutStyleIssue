// <copyright file="IMainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2020 All rights reserved</copyright>

namespace Vssl.Samples.ViewModelInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using Vssl.Samples.ViewModelInterfaces;

    /// <summary>
    /// The view model for the main page
    /// </summary>
    public interface IMainViewModel : IBaseViewModel
    {
        /// <summary>
        /// Gets the Settings command
        /// </summary>
        ICommand StartCommand { get; }

        /// <summary>
        /// Gets a sample show section command
        /// </summary>
        ICommand ShowObjectivesCommand { get; }

        /// <summary>
        /// Gets the switch model command
        /// </summary>
        ICommand SwitchModelCommand { get; }

        /// <summary>
        /// Gets the text used to indicate that the primary command was clicked
        /// </summary>
        string PrimaryClicked { get; }

        /// <summary>
        /// Gets the text used to indicate that the primary command was actioned
        /// </summary>
        string PrimaryCommand { get; }

        /// <summary>
        /// Start by click
        /// </summary>
        void Start();
    }
}
