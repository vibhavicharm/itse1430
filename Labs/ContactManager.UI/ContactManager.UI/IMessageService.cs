using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.UI
{
    interface IMessageService
    {
        Contact Get( Contact contact );
        Contact Send(Contact contact);
    }
}
