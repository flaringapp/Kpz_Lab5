using System.IO;
using System.Runtime.Serialization;

namespace Lab5.Data.Serialization
{
    public class DataSerializer
    {
        public static void Serialize(string path, DataModel data)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                var formatter = new DataContractSerializer(typeof(DataModel));
                formatter.WriteObject(stream, data);
            }
        }

        public static DataModel Deserialize(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                var formatter = new DataContractSerializer(typeof(DataModel));
                return (DataModel)formatter.ReadObject(stream);
            }
        }
    }
}
