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

            return AddCore(contact);
        }

        Contact Update( string name, Contact contact )
        {
            //Validate
            if (name.Length <= 0)
                throw new ArgumentOutOfRangeException(nameof(name), "Name is required");
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            //ObjectValidator.Validate(contact);

            var existing = GetCore(name);
            if (existing == null)
                throw new Exception("Contact does not exist.");

            //Game names must be unique            
            //var sameName = FindByName(Contact.Name);
            //if (sameName != null && sameName.Name != name)
            //    throw new Exception("Contact must be unique.");

            return UpdateCore(name, contact);
        }

        void Delete( string name )
        {
            if (name.Length <= 0)
                throw new ArgumentOutOfRangeException(nameof(name), "Name is required.");

            DeleteCore(name);
        }

        Contact Get( string name )
        {
            if (name.Length <= 0)
                throw new ArgumentOutOfRangeException(nameof(name), "Name is required.");

            return GetCore(name);
        }

        IEnumerable<Contact> GetAll()
        {
            return GetAllCore();
        }

        //protected virtual Contact FindByName( string name )
        //{
        //    return (from contact in GetAllCore()
        //            where String.Compare(contact.name, Name, true) == 0
        //            select (contact).FirstOrDefault());

        //}



        protected abstract Contact GetCore( string name );

        protected abstract Contact AddCore( Contact contact );

        protected abstract Contact UpdateCore( string name, Contact newContact );

        protected abstract void DeleteCore( string name );

        protected abstract IEnumerable<Contact> GetAllCore();

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
    }
}
