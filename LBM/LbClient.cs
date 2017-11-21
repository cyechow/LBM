using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBM
{
    public class LbClient
    {
        private string m_ClientName;
        public string ClientName { get { return m_ClientName; } set { m_ClientName = value; } }

        private string m_ContactName;
        public string ContactName { get { return m_ContactName; } set { m_ContactName = value; } }

        private string m_ContactEmail;
        public string ContactEmail { get { return m_ContactEmail; } set { m_ContactEmail = value; } }

        private string m_ContactPhoneNumber;
        public string ContactPhoneNumber { get { return m_ContactPhoneNumber; } set { m_ContactPhoneNumber = value; } }

        private DateTime m_AccountOpenDate;
        public DateTime AccountOpened { get { return m_AccountOpenDate; } set { m_AccountOpenDate = value; } }

        public LbClient(string name, DateTime accountOpened, string contact = "", string email = "", string phoneNum = "")
        {
            m_ClientName = name;
            m_ContactName = contact;
            m_ContactEmail = email;
            m_ContactPhoneNumber = phoneNum;

            m_AccountOpenDate = accountOpened;
        }
    }
}
