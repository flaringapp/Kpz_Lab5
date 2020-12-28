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
                    new UserModel(1, "Name 1", "Surname 1", "namesurname1@gmail.com", UserModel.UserType.User),
                    new UserModel(2, "Name 2", "Surname 2", "namesurname2@gmail.com", UserModel.UserType.Manager)
                }
            };
        }

    }
}
