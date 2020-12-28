using System.Runtime.Serialization;

namespace Lab5.Data
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        public string Id { get; private set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Email { get; set; }

        public UserType Type { get; set; }

        public UserModel() {

        }

        public UserModel(string id, string name, string surname, string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
        }

        public override string ToString()
        {
            return $"User with {Id} - {Name} {Surname} - {Email}";
        }

        [DataContract]
        public enum UserType
        {
            User,
            Manager
        }
    }
}
