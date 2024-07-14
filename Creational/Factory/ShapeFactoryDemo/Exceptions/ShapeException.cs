using Shared.Exceptions;

namespace ShapeFactoryDemo.Exceptions;
internal class ShapeException : CustomException
{
    public ShapeException(int shapeOrder) : base()
    {
        Update("NotValid", $"The shape-order value ({shapeOrder}) is not valid.");
    }

    public ShapeException(string description) : base(description) {
        Update("Founded");
    }
}
