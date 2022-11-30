﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChatAppplication.WPF.Core;
internal class ObservableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] String propertyname = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
    }
}
