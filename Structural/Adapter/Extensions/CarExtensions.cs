using Adapter.Abstractions;
using Adapter.Adapter;

namespace Adapter.Extensions;
internal static class CarExtensions {

    public static Car AsStandard(this Car car) {
        return new CarAdapter(car);
    }

}
