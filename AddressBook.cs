using System.Collections.Generic;

namespace Address
{
    class AddressBook
    {
        public Dictionary<Contact, string> addressbook {get; set; }
        public void AddContact(Contact contact){
            addressbook.Add(contact, contact.Email);
        }

        public Contact GetByEmail(string email){
            foreach(var pair in addressbook)
            {
                if(pair.Value == email)
                {
                    return pair.Key;
                }
            }
        }
    }
}