namespace ContactsManager.Data
{
    public class ContactService : IContactService
    {
        private List<Contact> contacts = new List<Contact>()
        {
            new Contact(){ Id = Guid.NewGuid(), FirstName = "Mohammad", LastName = "Mukahhal", Phone = "3134426680", BirthDate= new DateTime(2001, 01, 15)}
};
        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public Contact GetContact(Guid Id)
        {
            return contacts.SingleOrDefault(x => x.Id == Id);
        }

        public void UpdateContact(Contact contact)
        {
            var oldContact = GetContact(contact.Id);
            oldContact.FirstName = contact.FirstName;
            oldContact.LastName = contact.LastName;
            oldContact.Phone = contact.Phone;
            oldContact.BirthDate = contact.BirthDate;
        }

        public void DeleteContact(Guid Id)
        {
            var oldContact = GetContact(Id);
            contacts.Remove(oldContact);
        }

        public void AddContact(Contact contact)
        {
            contact.Id = Guid.NewGuid();
            contacts.Add(contact);
        }
    }
}
