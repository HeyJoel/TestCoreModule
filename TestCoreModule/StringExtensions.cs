using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuttingEdge.Conditions;

namespace TestCoreModule
{
    public static class StringExtensions
    {
        public static string AddJoel(this string s)
        {
            Condition.Requires(s).IsNotNull();
            return s += "Joel";
        }
    }
}
