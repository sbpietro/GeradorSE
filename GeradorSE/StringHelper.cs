using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorSE
{
    public static class StringHelper
    {
        public static bool ToBoolean(this string text)
        {
            return text == "Sim";
        }
    }
}
