using Lab5.Data.Serialization;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Lab5.Data
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public List<UserModel> Users { get; set; }

        public DataModel()
        {
            Users = new List<UserModel>();
        }

        public override string ToString()
        {
            var result = "Users: [";
            foreach (var user in Users)
            {
                result += $"{user}, ";
            }
            result += "]";
            return result;
        }


        public static string DataPath = "data.dat";

        public void Save()
        {
            DataSerializer.Serialize(DataPath, this);
        }

        public static DataModel Load()
        {
            try
            {
                return DataSerializer.Deserialize(DataPath);
            } 
            catch(Exception)
            {
                return new DataModel();
            }
        }
    }
}
