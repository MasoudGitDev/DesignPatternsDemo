using Flyweight.Abstractions;
using Flyweight.Constants;
using Shared.Extensions;
using Shared.Services;
using System.Reflection;

namespace Flyweight;
internal class GalaxyFlyweightFactory {
    private static readonly SortedList<GalaxyObject , IGalaxyObject> _galaxyObjects  = new();
    public static IGalaxyObject GetOrCreate(GalaxyObject galaxyObject) {
        // ============================ Get =======================
        if(_galaxyObjects.ContainsKey(galaxyObject)) {
            Logger.Log("Get : " + _galaxyObjects[galaxyObject].ToString());
            return _galaxyObjects[galaxyObject];
        }
        // ============================ Create =======================
        Type type  = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x=> !x.IsInterface && !x.IsAbstract &&
                x.IsAssignableTo(typeof(IGalaxyObject)) &&
                x.Name.Equals(galaxyObject.ToString()))
            .FirstOrDefault().ThrowIfNull($"Can not find <{galaxyObject}> type.");
        var instance =  ( (IGalaxyObject) Activator.CreateInstance(type) )
            .ThrowIfNull($"Can not create an instance of <{galaxyObject}> type.");
        _galaxyObjects.Add(galaxyObject, instance);
        Logger.Log("Create : " + instance.ToString());

        return instance;
    }
    public static void GetCount() => Logger.Log(_galaxyObjects.Count().ToString());
}
