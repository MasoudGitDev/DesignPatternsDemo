using AbstractFactory.Abstractions;
using AbstractFactory.Constants;
using AbstractFactory.Factories;

namespace AbstractFactory.Theme;
internal class Theme(ColorMode _themeColor) : ITheme {
    public IDialog Dialog => DialogFactory.Create(_themeColor);
    public IToolbar Toolbar => ToolbarFactory.Create(_themeColor);
    public void Show() {
        Dialog.Show();
        Toolbar.Show();
    }
}
