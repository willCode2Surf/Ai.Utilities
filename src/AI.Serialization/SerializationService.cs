using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AI.Serialization
{
    public class SerializationService<T> : ISerializationService<T>
        where T : class
    {
        public T Get(string serializedString)
        {
            
            using(var reader = new StringReader(serializedString))
            {
                var ret = new XmlSerializer(typeof (T)).Deserialize(reader);
                return (T) ret;
            }

        }

        public string Put(T objectToSerialize)
        {
            var buffer = new StringBuilder();
            using(var writer = new StringWriter(buffer))
            {
                new XmlSerializer(typeof (T)).Serialize(writer,objectToSerialize);
            }
            return buffer.ToString();
        }
    }
}
