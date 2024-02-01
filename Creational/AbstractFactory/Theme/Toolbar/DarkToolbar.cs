using AbstractFactory.Abstractions;
using Shared.Services;

namespace AbstractFactory.Theme.Toolbar;
internal class DarkToolbar : IToolbar {
    public void Show() => Logger.Log("This is a <Dark> toolbar.\n");
}

