using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Example_2.Abstractions;
internal interface ISortStrategy {
    int[] Sort(int[] numbers);
}
