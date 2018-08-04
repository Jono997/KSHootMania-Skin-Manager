using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSM_Skin_Manager_Help
{
    public static class Extension_methods
    {
        public static void AddRange<T, E> (this Dictionary<T, E> dictionary, params object[] parameters)
        {
            if (parameters.Length % 2 == 1)
            {
                throw new ArgumentException("An odd number of arguments was passed");
            }
            else
            {
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    dictionary.Add((T)parameters[i], (E)parameters[i + 1]);
                }
            }
        }
    }
}
