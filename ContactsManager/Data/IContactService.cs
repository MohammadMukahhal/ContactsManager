namespace ContactsManager.Data
{
    interface IContactService
    {
        List<Contact> GetContacts();
        Contact GetContact(Guid id);

        void UpdateContact(Contact contact);

        void DeleteContact(Guid Id);

        void AddContact(Contact contact);
    }
}
