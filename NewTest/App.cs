﻿using BlazorBindings.Maui;

namespace NewTest;

public partial class App : Application
{
    public App(MauiBlazorBindingsRenderer renderer)
    {
        renderer.AddComponent<AppShell>(this);
    }
}
