using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.UI
{
    public interface IContactDatabaseNew
    {
        Contact Add( Contact contact );
        Contact Get( string name );
        IEnumerable<Contact> GetAll();
        void Remove( string name );
        Contact Update( string name, Contact contact );
        void Add( object contact );
        void Delete( string name );
        void Update( string name, object contact );
    } 

    public class Contact
    {
        internal string Name;
        internal string Email;
    }
}
