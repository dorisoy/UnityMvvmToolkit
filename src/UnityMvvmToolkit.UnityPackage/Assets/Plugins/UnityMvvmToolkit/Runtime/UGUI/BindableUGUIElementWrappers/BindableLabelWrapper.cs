﻿using TMPro;
using UnityMvvmToolkit.Common;
using UnityMvvmToolkit.Common.Interfaces;
using UnityMvvmToolkit.UGUI.BindableUGUIElements;

namespace UnityMvvmToolkit.UGUI.BindableUGUIElementWrappers
{
    public class BindableLabelWrapper : BindablePropertyElement
    {
        private readonly TMP_Text _label;
        private readonly IReadOnlyProperty<string> _textProperty;

        public BindableLabelWrapper(BindableLabel label, IObjectProvider objectProvider) : base(objectProvider)
        {
            _label = label.Label;
            _textProperty = GetReadOnlyProperty<string>(label.BindingTextPath);
        }

        public override void UpdateValues()
        {
            if (_textProperty != null)
            {
                _label.text = _textProperty.Value;
            }
        }
    }
}