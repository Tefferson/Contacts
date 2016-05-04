using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class Class1
    {
        public List<Contact> CONTATOS { get; set; }
        public Contact Get() => null;

        public Contact GET_PORID(int id) => default(Contact);

        public IEnumerable<Contact> Listar_TODOS() => default(IEnumerable<Contact>);

        public void ADICIONAR_CONTACT(object contact)
        {
            if (contact is Contact)
            {
                var contactContact = (Contact)contact;
                CONTATOS.Add(contactContact);
            }

            throw new Exception("CONTACT IS NOT A CONTACT");
        }

        public Class1()
        {
            CONTATOS = new List<Contact>();
        }
    }
}
