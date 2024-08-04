using FileDirectoriesComposite.Abstractions;
using FileDirectoriesComposite.Extensions;
using Shared.Services;

namespace FileDirectoriesComposite.Models;
internal class FileItem(string name , int level) : IITem {
    public string Name => name;
    public int Level => level;

    public void GetDetails() {
        Logger.Log(name.CreateTab(level));
    }
}