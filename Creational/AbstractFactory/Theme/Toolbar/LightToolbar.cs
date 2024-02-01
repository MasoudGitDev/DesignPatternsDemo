using AbstractFactory.Abstractions;
using Shared.Services;

namespace AbstractFactory.Theme.Toolbar;

internal class LightToolbar : IToolbar {
    public void Show() => Logger.Log("This is a <Light> toolbar.\n");
}

