using System;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using System.Data.Entity;
using System.Data.Entity.Validation;

using LBM.Data;

namespace LBM
{
    public class DbInterface
    {
        private string dbSourceAddress = "CYEC\\SQLEXPRESS,1433";
        private string dbUsername = "lbadmin";
        private string dbUserPassword = "lbadmin";

        #region Constructor
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static DbInterface() { }
        private DbInterface()
        {
        }
        #endregion

        #region Singleton
        private static readonly DbInterface instance = new DbInterface();
        public static DbInterface Instance
        {
            get { return instance; }
        }
        #endregion

        private void SetConnectionString(LBDataEntities context)
        {
            context.Connection.ConnectionString = String.Format("datasource={0};initial catalog=LBData;integrated security=False;user id={1};password={2};MultipleActiveResultSets=True;App=EntityFramework",
                dbSourceAddress, dbUsername, dbUserPassword);
            
            //context.Connection.ConnectionString = String.Format("Data Source={0};Initial Catalog=LBData;Persist Security Info=True;User ID={1}", m_DbSource, m_DbUser, m_DbPassword);
        }
        private void SetConnectionString(IDbConnection conn)
        {
            string strConn = String.Format("metadata=res://*;provider=System.Data.Client;provider connection string=';Data Source={0};Initial Catalog=LBData;Persist Security Info=True;User Id={1};Password={2};MultipleActiveResultSets=True';", 
                dbSourceAddress, dbUsername, dbUserPassword);

            conn.ConnectionString = strConn;
            //conn.ConnectionString = String.Format("Data Source={0};Initial Catalog=LBData;Persist Security Info=True;User ID={1}", m_DbSource, m_DbUser, m_DbPassword);
            // conn.ConnectionString = String.Format("datasource={0};initial catalog=LBData;integrated security=False;user id={1};password={2};MultipleActiveResultSets=True;App=EntityFramework",
                //m_DbSource, m_DbUser, m_DbPassword);

        }

        public bool AuthenticateUser(string username, string password, out string errMsg)
        {
            errMsg = String.Empty;
            try
            {
                using (var context = new LBDataEntities())
                {
                    context.Connection.Open();
                    //SetConnectionString(context.Connection);
                    var query = context.tblUsers.Where(x => x.Username.Equals(username));
                    var entry = query.FirstOrDefault();

                    if (query != null && query.Any())
                    {
                        return entry.Password == password;
                    }
                }
            }
            catch (DbEntityValidationException dbExc)
            {
                errMsg = dbExc.Message;
            }
            catch (Exception exc)
            {
                errMsg = exc.Message;
            }
            
            return false;
        }

        public ReadOnlyCollection<string> QueryClientNameList()
        {
            List<string> lClients = new List<string>();
            try
            {
                using (var context = new LBDataEntities())
                {
                    context.Connection.Open();
                    //SetConnectionString(context);

                    var query = context.tblClients.Select(x => x.ClientName);
                    if (query.Any())
                    {
                        lClients = query.ToList();
                    }
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }

            return lClients.AsReadOnly();
        }

        public ReadOnlyCollection<int> QueryClientIdList()
        {
            List<int> lClients = new List<int>();
            try
            {
                using (var context = new LBDataEntities())
                {
                    context.Connection.Open();

                    var query = context.tblClients.Select(x => x.UID);
                    if (query.Any())
                    {
                        lClients = query.ToList();
                    }
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }

            return lClients.AsReadOnly();
        }
        public bool SaveClientDataToDB(int clientId, LbClient clientProfile, out string errMsg)
        {
            errMsg = "";
            
            try
            {
                using (var context = new LBDataEntities())
                {
                    context.Connection.Open();
                    //SetConnectionString(context);

                    var query = context.tblClients.Where(x => x.UID == clientId);
                    if (!query.Any())
                    {
                        var entry = new tblClient();
                        entry.ClientName = clientProfile.ClientName;
                        entry.ContactName = clientProfile.ContactName;
                        entry.ContactEmail = clientProfile.ContactEmail;
                        entry.ContactPhoneNumber = clientProfile.ContactPhoneNumber;

                        entry.AccountOpenDate = clientProfile.AccountOpened;

                        context.tblClients.AddObject(entry);
                    }
                    else
                    {
                        var entry = query.First();
                        entry.ClientName = clientProfile.ClientName;
                        entry.ContactName = clientProfile.ContactName;
                        entry.ContactEmail = clientProfile.ContactEmail;
                        entry.ContactPhoneNumber = clientProfile.ContactPhoneNumber;

                        entry.AccountOpenDate = clientProfile.AccountOpened;
                    }
                        
                    context.SaveChanges();
                }
            }
            catch (Exception exc)
            {
                errMsg = exc.Message;
                errMsg += Environment.NewLine;
                errMsg += exc.StackTrace;
                return false;
            }

            return true;
        }
        public bool DeleteClientFromDB(int clientId, out string errMsg)
        {
            errMsg = "";

            try
            {
                using (var context = new LBDataEntities())
                {
                    context.Connection.Open();
                    var query = context.tblClients.Where(x => x.UID == clientId);
                    if (query != null && query.Any())
                    {
                        var entry = query.First();
                        context.tblClients.DeleteObject(entry);
                        context.SaveChanges();
                    }
                    else
                    {
                        errMsg = String.Format("Could not find client {0} in the DB.", clientId);
                    }
                }
            }
            catch (Exception exc)
            {
                errMsg = exc.Message;
                errMsg += Environment.NewLine;
                errMsg += exc.StackTrace;
                return false;
            }

            return true;
        }

        public LbClient RetrieveClientDetailsFromDb(int clientId)
        {
            LbClient clientData = new LbClient(String.Empty, DateTime.Now);
            string errMsg = "";
            try
            {
                using (var context = new LBDataEntities())
                {
                    context.Connection.Open();
                    var query = context.tblClients.Where(x => x.UID == clientId);
                    if (query != null && query.Any())
                    {
                        var entry = query.First();
                        clientData.ClientName = entry.ClientName;
                        clientData.ContactName = entry.ContactName;
                        clientData.ContactEmail = entry.ContactEmail;
                        clientData.ContactPhoneNumber = entry.ContactPhoneNumber;
                        if (entry.AccountOpenDate.HasValue) { clientData.AccountOpened = entry.AccountOpenDate.Value; }
                    }
                }
            }
            catch (Exception exc)
            {
                errMsg = exc.Message;
                errMsg += Environment.NewLine;
                errMsg += exc.StackTrace;               
            }

            return clientData;
        }

        public string RetrieveClientNameFromDb(int clientId)
        {
            string clientName = "Unknown";
            string errMsg = "";
            try
            {
                using (var context = new LBDataEntities())
                {
                    context.Connection.Open();
                    var query = context.tblClients.Where(x => x.UID == clientId);
                    if (query != null && query.Any())
                    {
                        var entry = query.First();
                        clientName = entry.ClientName;
                    }
                }
            }
            catch (Exception exc)
            {
                errMsg = exc.Message;
                errMsg += Environment.NewLine;
                errMsg += exc.StackTrace;               
            }

            return clientName;
        }

        public int RetrieveClientIdFromDb(string strClientName)
        {
            int clientId = -1;
            string errMsg = "";
            try
            {
                using (var context = new LBDataEntities())
                {
                    context.Connection.Open();
                    var query = context.tblClients.Where(x => x.ClientName == strClientName);
                    if (query != null && query.Any())
                    {
                        var entry = query.First();
                        clientId = entry.UID;
                    }
                }
            }
            catch (Exception exc)
            {
                errMsg = exc.Message;
                errMsg += Environment.NewLine;
                errMsg += exc.StackTrace;               
            }

            return clientId;
        }
    }
}
