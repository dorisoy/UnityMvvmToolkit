﻿using System.ComponentModel;
using Interfaces.Services;
using UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using UnityMvvmToolkit.Common.Interfaces;
using UnityMvvmToolkit.UI;

namespace Views
{
    public class BaseView<TBindingContext> : DocumentView<TBindingContext>
        where TBindingContext : class, INotifyPropertyChanged
    {
        [SerializeField] private AppContext _appContext;

        protected override TBindingContext GetBindingContext()
        {
            RootVisualElement.Q<ContentPage>()?.Initialize(_appContext.Resolve<IThemeService>());
            return _appContext.Resolve<TBindingContext>();
        }

        protected override IConverter[] GetValueConverters()
        {
            return _appContext.Resolve<IConverter[]>();
        }

        protected override IBindableElementsWrapper GetBindableElementsWrapper()
        {
            return _appContext.Resolve<IBindableElementsWrapper>();
        }
    }
}