using DesignPatterns.Shared.SingletonPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.SingletonPattern.Models {
    public class Person : IPerson {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = String.Empty;
    }
}
