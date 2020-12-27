using Lab5.Data;
using Lab5.Data.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Lab5.DataTest
{
    [TestClass]
    public class DataSerializerTest
    {
        private readonly string dir = AppDomain.CurrentDomain.BaseDirectory;
        private string FilePath => dir + "/test.txt";

        [TestMethod]
        public void TestSerialize()
        {
            var model = new DataModel
            {
                Users = new List<UserModel>
            {
                new UserModel("Name1", "Surname1", "email1@gmail.com"),
                new UserModel("Name2", "Surname2", "email2@gmail.com")
            }
            };
            DataSerializer.Serialize(FilePath, model);
        }

        [TestMethod]
        public void TestDeserialize()
        {
            DataSerializer.Deserialize(FilePath);
        }
    }
}
