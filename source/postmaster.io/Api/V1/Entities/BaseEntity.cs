using System.Collections.Generic;
using System.ComponentModel;

namespace Postmaster.io.Api.V1.Entities
{
    /// <summary>
    /// Entity base class.
    /// </summary>
    public class BaseEntity
    {
        public const bool DefaultBool = false;
        public const string DefaultString = "";
        public const int DefaultInt = 0;
        public const long DefaultLong = 0;
        public static readonly List<string> DefaultStringList = new List<string>();
        public static readonly Dictionary<string, string> DefaultStringDictionary = new Dictionary<string, string>(); 
    }
}
