using Shared.Exceptions;

namespace Factory.Exceptions;
internal class ShapeFactoryException : CustomException {
    public ShapeFactoryException() {
    }

    public ShapeFactoryException(string description) : base(description) {
    }

    public ShapeFactoryException(string code , string description) : base(code , description) {
    }

    public ShapeFactoryException(string method , string code , string description) : base(method , code , description) {
    }
}
