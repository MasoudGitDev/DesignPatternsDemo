using AbstractFactory.Abstractions;
using Shared.Services;

namespace AbstractFactory.Theme.Dialog;

internal class LightDialog : IDialog {
    public void Show() => Logger.Log("This is a <Light> Dialog");
}
