using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GoodsStorage
{
    /// <summary>
    /// A user class marked with attributes to trigger serialization.
    /// </summary>
    [DataContract]
    public class User
    {
        [DataMember]
        public string Initials { get; set; }
        [DataMember]
        public ulong TelephoneNumber { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public  string Password {get;set;}
        [DataMember]
        public List<Order> AllOrders { get; set; } = new List<Order>();
        [DataMember]
        public List<Item> ShoppingCart { get; set; } = new List<Item>();
        /// <summary>
        /// Constructor for making a new user.
        /// </summary>
        /// <param name="initials">User first, last and secon names.</param>
        /// <param name="telephone">Uset telephone number.</param>
        /// <param name="address">User address.</param>
        /// <param name="email">User email.</param>
        /// <param name="password">User password.</param>
        public User(string initials, ulong telephone, string address, string email, string password)
        {
            Initials = initials;
            TelephoneNumber = telephone;
            Address = address;
            Email = email;
            Password = password;
        }
    }
}
