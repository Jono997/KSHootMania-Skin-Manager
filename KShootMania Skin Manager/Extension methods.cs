using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KShootMania_Skin_Manager
{
    /// <summary>
    /// A collecton of the extension methods in the application
    /// </summary>
    public static class Extension_methods
    {
        /// <summary>
        /// Adds numerous keys to a dictionary
        /// </summary>
        /// <param name="parameters">The keys and values to add
        /// An ArgumentException will be raised if the number of arguments passed is odd
        /// If an odd numbered argument is not the type of the dictionary key or an even numbered argument is not the type of the dictionary value, a FormatException will be raised</param>
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
                    if (parameters[i].GetType() != typeof(T))
                        throw new FormatException("Argument " + i.ToString() + " is not of type " + typeof(T).ToString() + '.');
                    else if (parameters[i + 1].GetType() != typeof(E))
                        throw new FormatException("Argument " + (i + 1).ToString() + " is not of type " + typeof(E).ToString() + '.');
                    else
                        dictionary.Add((T)parameters[i], (E)parameters[i + 1]);
                }
            }
        }
    }
}
