using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.FactoryPattern.Abstractions; 

public interface IFurnishable { }
public interface ISeatable {
    void TakeSeat();
}
public interface IPlaceable {
    void PutItem();
}

public interface IChair : ISeatable, IFurnishable { }
public interface ISofa : ISeatable, IFurnishable { }
public interface ITable : IPlaceable, IFurnishable { }


public interface IFurniture {
    IChair ChooseChair();
    ISofa ChooseSofa();
    ITable ChooseTable();
}
