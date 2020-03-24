using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorSE
{
    public class Conditional
    {
        private readonly Dictionary<string, bool?> _singleValueVariables;

        public Conditional(Dictionary<string, List<string>> multiValueVariables, Dictionary<string, bool?> singleValueVariables)
        {
            _singleValueVariables = singleValueVariables;
        }

        //public bool RunConditional(Dictionary<string, bool?> singleValues, string regra)
        //{
        //    if(singleValues.ContainsKey("previsao do tempo"))
        //    {
        //        if(singleValues["previsao do tempo"].Value == true)
        //        {
        //            singleValues["chovendo"] = true;
        //        }
        //    }
        //}
    }
}
