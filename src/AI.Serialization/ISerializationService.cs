using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Serialization
{
    public interface ISerializationService<T>
        where T: class
    {
        T Get(string serializedString);

        string Put(T objectToSerialize);
    }
}
