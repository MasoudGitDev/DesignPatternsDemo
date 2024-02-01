namespace AbstractFactory.Abstractions;
internal interface IDialog {
    void Show();
}
internal interface IToolbar {
    void Show();
}

internal interface ITheme  {
    IDialog Dialog { get; }
    IToolbar Toolbar { get; }
}


