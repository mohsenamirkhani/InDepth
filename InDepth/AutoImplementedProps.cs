using System;
using System.Collections.Generic;
using System.Text;

namespace InDepth
{
    public sealed class AutoImplementedProps
    {
        // read/write auto implemented property
        public int Id { get; set; }

        // read/write auto implemented and initialized property
        public string Name { get; set; } = "Mohsen";

        // read-only auto implemented property
        public double Width { get; }

        // read-only auto implemented and initialized property
        public double Size { get; } = 10d;

        // read-only computed property
        public double Size2
        {
            get
            {
                return Width * Length;
            }
        }

        // this is not possible
        // "can not access non-static property in a static context"
        //public double Size { get; } = Width;


        // expression-bodied read-only computed property
        public double Length => Width * Size;
    }

    public struct AutoImplementedPropsStruct
    {
        public double Size { get; }

        // prior to C#6 we must have add :this() to the constructor because of definite assignment rules of "structs"
        public AutoImplementedPropsStruct(double size)
        {
            Size = size;
        }
    }
}
