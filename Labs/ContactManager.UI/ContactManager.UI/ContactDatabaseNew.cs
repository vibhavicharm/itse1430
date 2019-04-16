using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.UI
{
    public abstract class ContactDatabaseNew : IContactDatabaseNew
    {
        private object ObjectValidator;

        Contact Add( Contact contact )
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

           // ObjectValidator.Validate(contact);

            //var existing = FindByName(contact.name);
            // if (existing != null)
            //     throw new Exception("Contact must be unique");

            return Add(contact);
        }

        Contact Update( string name, Contact contact )
        {
            //Validate
            if (name.Length <= 0)
                throw new ArgumentOutOfRangeException(nameof(name), "Name is required");
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            //ObjectValidator.Validate(contact);

            var existing = Get(name);
            if (existing == null)
                throw new Exception("Contact does not exist.");

            //Game names must be unique            
            //var sameName = FindByName(Contact.Name);
            //if (sameName != null && sameName.Name != name)
            //    throw new Exception("Contact must be unique.");

            return Update(name, contact);
        }

        void Delete( string name )
        {
            if (name.Length <= 0)
                throw new ArgumentOutOfRangeException(nameof(name), "Name is required.");

            Delete(name);
        }

        Contact Get( string name )
        {
            if (name.Length <= 0)
                throw new ArgumentOutOfRangeException(nameof(name), "Name is required.");

            return Get(name);
        }

        IEnumerable<Contact> GetAll()
        {
            return contactList;
        }

        private List<Contact> contactList;

        public IEnumerable<Contact> ContactList
        {
            get { return contactList; }
            set { contactList = value.ToList(); }
        }

        //protected virtual Contact FindByName( string name )
        //{
        //    return (from contact in GetAllCore()
        //            where String.Compare(contact.name, Name, true) == 0
        //            select (contact).FirstOrDefault());

        //}



       
        
        
        Contact IContactDatabaseNew.Add( Contact contact )
        {
            throw new NotImplementedException();
        }

        Contact IContactDatabaseNew.Get( string name )
        {
            throw new NotImplementedException();
        }

        IEnumerable<Contact> IContactDatabaseNew.GetAll()
        {
            
            throw new NotImplementedException();
        }

        public abstract void Remove( string name );

        Contact IContactDatabaseNew.Update( string name, Contact contact )
        {
            throw new NotImplementedException();
        }

        public abstract void Add( object contact );

        void IContactDatabaseNew.Delete( string name )
        {
            throw new NotImplementedException();
        }

        public void Update( string name, object contact )
        {
            throw new NotImplementedException();
        }
    }
}
