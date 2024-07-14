using ShapeFactoryDemo.Abstractions;
using ShapeFactoryDemo.Constants;
using Shared.Services;

namespace ShapeFactoryDemo;
internal class ProgramHandler(IShapeFactory shapeFactory) {
    public void CreateShape(int total , string userInput) {
        bool isInteger = int.TryParse(userInput, out int shapeNumber);
        if(!isInteger) {
            Logger.Log($"Please enter a valid integer between 1 and {total}.");
            return;
        }
        CreateWithCheckNumber((ShapeNames) shapeNumber , total);
    }
    private void CreateWithCheckNumber(ShapeNames shapeNumber , int total) {
        if(total >= (int) shapeNumber) {
            shapeFactory.Create(shapeNumber).Draw();
        }
        else {
            Logger.Log($"The shape numbers start from 1 to {total}.");
        }
    }
}
