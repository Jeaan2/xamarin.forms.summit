﻿using System;
using Xamarin.Forms;

namespace Xamarin.Summit
{
    public abstract class TabbedItemPage : ContentPage
    { 
        protected TabbedItemPage(Type viewModelType)
            => BindingContext = ViewModelLocator.Instance.Resolve(viewModelType);

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await (BindingContext as BaseViewModel)?.InitializeAsync();
        }
    }
}
