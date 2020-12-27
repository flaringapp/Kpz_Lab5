using System.Runtime.Serialization;

namespace Lab5.Data
{
    [DataContract]
    public class UserModel
    { 
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Email { get; set; }

        public UserModel() {
        }

        public UserModel(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }

        public override string ToString()
        {
            return $"User {Name} {Surname} - {Email}";
        }

    }
}
