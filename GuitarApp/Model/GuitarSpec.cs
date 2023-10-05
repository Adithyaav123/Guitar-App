using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class GuitarSpec
    {
        public Builder Builder { get; private set; }
        public string Model { get; private set; }
        public Type Type { get; private set; }
        public int NumStrings { get; private set; }
        public Wood BackWood { get; private set; }
        public Wood TopWood { get; private set; }

        public GuitarSpec(Builder builder, string model, Type type,
                          int numStrings, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            NumStrings = numStrings;
            BackWood = backWood;
            TopWood = topWood;
        }

        internal bool Matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder)
                return false;
            if (!string.IsNullOrEmpty(Model) &&
                !string.Equals(Model, otherSpec.Model, StringComparison.OrdinalIgnoreCase))
                return false;
            if (Type != otherSpec.Type)
                return false;
            if (NumStrings != otherSpec.NumStrings)
                return false;
            if (BackWood != otherSpec.BackWood)
                return false;
            if (TopWood != otherSpec.TopWood)
                return false;
            return true;
        }
    }
}
