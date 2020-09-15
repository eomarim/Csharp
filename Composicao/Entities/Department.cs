using System;

namespace Composicao.Entities{

    public class Department{
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}