using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBM
{
    public class LbClient
    {
        private string clientName;
        public string ClientName { get { return clientName; } set { clientName = value; } }

        private string contactName;
        public string ContactName { get { return contactName; } set { contactName = value; } }

        private string contactEmail;
        public string ContactEmail { get { return contactEmail; } set { contactEmail = value; } }

        private string contactPhoneNumber;
        public string ContactPhoneNumber { get { return contactPhoneNumber; } set { contactPhoneNumber = value; } }

        private DateTime accountOpenDate;
        public DateTime AccountOpened { get { return accountOpenDate; } set { accountOpenDate = value; } }

        public LbClient(string name, DateTime accountOpened, string contact = "", string email = "", string phoneNum = "")
        {
            clientName = name;
            contactName = contact;
            contactEmail = email;
            contactPhoneNumber = phoneNum;

            accountOpenDate = accountOpened;
        }
    }
}
