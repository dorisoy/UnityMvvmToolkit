﻿using System.Runtime.CompilerServices;
using UnityMvvmToolkit.Core.Extensions;

namespace UnityMvvmToolkit.Core.Converters.ParameterValueConverters
{
    public class ParameterToFloatConverter : ParameterValueConverter<float>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Convert(string parameter)
        {
            parameter.TryParse(out var result);
            return result;
        }
    }
}