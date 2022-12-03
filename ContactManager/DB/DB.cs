using ContactManager.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.DB
{
    internal class DB
    {
        List<Contact> GetContacts()
        {
            return null;

            //List.add();
        }

        Contact GetContact(int contactId)
        {
            return null;
        }

        Contact GetContacts(int contactId)
        {
            return null;
        }

        Contact GetAddress(int contactId)
        {
            return null;
        }

        Contact GedAddressesForContact(int contactId)
        {
            return null;
        }

        // GetContact - Show just a few details
        // GetContacts - Show more details for an ID
        // GetAddress - Shows an address for address ID.
        //GetAddressesForContact - Get All addresses for a contact ID (limited detail)
    }
}
