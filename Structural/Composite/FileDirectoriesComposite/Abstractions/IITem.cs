namespace FileDirectoriesComposite.Abstractions;
internal interface IITem {
    int Level { get; }
    string Name { get; }
    void GetDetails();
}
