using Strategy.Abstractions;
using Strategy.Constants;

namespace Strategy.Models;
public record MathOperationModel(MathOperationType MathOperationType , IMathOperation MathOperation);
