using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Serialization
{
    public class SerializationService<T> : ISerializationService<T>
        where T : class
    {
        public T Get(string serializedString)
        {
            
        }

        public string Put(T objectToSerialize)
        {
            
        }
    }
}
