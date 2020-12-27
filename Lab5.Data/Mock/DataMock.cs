using System.Collections.Generic;

namespace Lab5.Data.Mock
{
    public class DataMock
    {
        public static DataModel Mock()
        {
            return new DataModel
            {
                Users = new List<UserModel>
                {
                    new UserModel("Name 1", "Surname 1", "namesurname1@gmail.com"),
                    new UserModel("Name 2", "Surname 2", "namesurname2@gmail.com")
                }
            };
        }

    }
}
