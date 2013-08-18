using Newtonsoft.Json;

namespace Postmaster.io.Communication.Api.V1.Utility
{
    public class Converter
    {
        public T Convert<T>(ref T type, ref string data)
        {
            T temp = JsonConvert.DeserializeObject<T>(data);
            return temp;
        }
    }
}
