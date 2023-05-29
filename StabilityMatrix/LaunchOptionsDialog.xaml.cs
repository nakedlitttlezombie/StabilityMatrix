﻿using System.Windows;
using System.Windows.Controls;
using StabilityMatrix.ViewModels;
using Wpf.Ui.Contracts;
using Wpf.Ui.Controls.ContentDialogControl;

namespace StabilityMatrix;

public partial class LaunchOptionsDialog : ContentDialog
{
    private readonly LaunchOptionsDialogViewModel viewModel;

    public LaunchOptionsDialog(IContentDialogService dialogService, LaunchOptionsDialogViewModel viewModel) : base(
        dialogService.GetContentPresenter())
    {
        this.viewModel = viewModel;
        InitializeComponent();
    }

    private void LaunchOptionsDialog_OnLoaded(object sender, RoutedEventArgs e)
    {
        viewModel.OnLoad(); 
    }
}
