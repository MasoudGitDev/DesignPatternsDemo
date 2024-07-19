namespace PasswordChecker.Constants;
internal record CharacterType(string Pattern , string Name) {
    public static CharacterType English = new("[a-zA-Z]",nameof(English));
    public static CharacterType  Digit = new ("[0-9]",nameof(Digit));
    public static CharacterType  Specials =new(@"[!@#$%^&*-/]", nameof(Specials));
    public static CharacterType  Valid =new(@"[a-zA-Z0-9!@#$%^&*-/]", nameof(Valid));
    public static CharacterType  Invalid =new(@"[^a-zA-Z0-9!@#$%^&*-/]", nameof(Invalid));
    public static CharacterType  UpperCase =new(@"[A-Z]", nameof(UpperCase));
    public static CharacterType  LowerCase =new(@"[a-z]", nameof(LowerCase));
}
