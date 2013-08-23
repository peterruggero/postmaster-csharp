using System.Collections.Generic;
using System.ComponentModel;

namespace Postmaster.io.Api.V1.Entities
{
    /// <summary>
    /// Entity base class.
    /// </summary>
    public class BaseEntity
    {
        public readonly const bool DefaultBool = false;
        public readonly const string DefaultString = "";
        public readonly const int DefaultInt = 0;
        public static readonly List<string> DefaultStringList = new List<string>();
        public static readonly Dictionary<string, string> DefaultStringDictionary = new Dictionary<string, string>(); 
    }
}
