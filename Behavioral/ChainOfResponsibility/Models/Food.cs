using ChainOfResponsibility.Abstractions;

namespace ChainOfResponsibility.Models;
internal record Food(string Name , decimal Price) : IFood;