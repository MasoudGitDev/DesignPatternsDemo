using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.SingletonPattern.Abstractions {
    public interface IPerson {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
