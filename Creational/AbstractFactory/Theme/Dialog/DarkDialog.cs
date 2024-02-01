using AbstractFactory.Abstractions;
using Shared.Services;

namespace AbstractFactory.Theme.Dialog;
internal class DarkDialog : IDialog {
    public void Show() => Logger.Log("This is a <Dark> Dialog");
}
