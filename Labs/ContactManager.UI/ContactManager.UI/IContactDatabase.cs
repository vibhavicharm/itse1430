using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.UI
{
    public interface IContactDatabase
    {
        Contact Add( Contact contact );
        Contact Get( int id );
        IEnumerable<Contact> GetAll();
        void Remove( int name );
        Contact Update( int name, Contact contact );

    }

    public class Contact
    {
    }
}
