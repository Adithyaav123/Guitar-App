﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    
    public enum Type
    {
        ACOUSTIC,
        ELECTRIC
    }

    public static class TypeExtensions
    {
        public static string ToCustomString(this Type type)
        {
            switch (type)
            {
                case Type.ACOUSTIC:
                    return "acoustic";
                case Type.ELECTRIC:
                    return "electric";
                default:
                    return "unspecified";
            }
        }
    }
}

