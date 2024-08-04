using FileDirectoriesComposite.Abstractions;
using FileDirectoriesComposite.Extensions;
using Shared.Services;

namespace FileDirectoriesComposite.Models;

internal class DirectoryItem(string name , int level) : IITem {
    private readonly List<IITem> items = new();
    public string Name => name;
    public int Level => level;

    public void GetDetails() {
        Logger.Log(name.CreateTab(level));
        foreach(var item in items) {
            item.GetDetails();
        }
    }
    public void Add(IITem item) => items.Add(item);
    public void Remove(IITem item) => items.Remove(item);
}
