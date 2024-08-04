using System.Text;

namespace FileDirectoriesComposite.Extensions;
internal static class StringExtensions {
    public static string CreateTab(this string text , int level) {
        StringBuilder tabBuilder = new();
        for(int i = 0 ; i < level ; i++) {
            tabBuilder.Append("\t");
        }
        return tabBuilder.ToString() + text;
    }
}
