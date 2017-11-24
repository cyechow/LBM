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

        private string errMsg = "";
        public string ErrorMessage { get { return errMsg; } }

        public bool IsUserAuthenticated = false;

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
        }
        private void SetConnectionString(IDbConnection conn)
        {
            string strConn = String.Format("metadata=res://*;provider=System.Data.Client;provider connection string=';Data Source={0};Initial Catalog=LBData;Persist Security Info=True;User Id={1};Password={2};MultipleActiveResultSets=True';", 
                dbSourceAddress, dbUsername, dbUserPassword);

            conn.ConnectionString = strConn;
        }

        public void AuthenticateUser(string username, string password)
        {
            try
            {
                IsUserAuthenticated = IsValidUserCredentials(username, password);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool IsValidUserCredentials(string username, string password)
        {
            using (var context = new LBDataEntities())
            {
                context.Connection.Open();
                var query = context.tblUsers.Where(x => x.Username.Equals(username));
                var entry = query.FirstOrDefault();

                if (query != null && query.Any())
                {
                   return entry.Password == password;
                }
            }

            return false;
        }

        public ReadOnlyCollection<string> GetClientNames()
        {
            try
            {
                List<string> clientNames = QueryClientNames();
                return clientNames.AsReadOnly();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private List<string> QueryClientNames()
        {
            List<string> clientNames = new List<string>();
            using (var context = new LBDataEntities())
            {
                context.Connection.Open();

                var query = context.tblClients.Select(x => x.ClientName);
                if (query.Any())
                {
                    clientNames = query.ToList();
                }
            }

            return clientNames;
        }

        public ReadOnlyCollection<int> GetClientIds()
        {
            try
            {
                List<int> clientIds = QueryClientIds();
                return clientIds.AsReadOnly();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private List<int> QueryClientIds()
        {
            List<int> clientIds = new List<int>();
            using (var context = new LBDataEntities())
            {
                context.Connection.Open();

                var query = context.tblClients.Select(x => x.ClientId);
                if (query.Any())
                {
                    clientIds = query.ToList();
                }
            }
            return clientIds;
        }

        public void SendClientDataToDb(int clientId, LbClient clientProfile)
        {
            try
            {
                StoreClientInfo(clientId, clientProfile);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void StoreClientInfo(int clientId, LbClient clientProfile)
        {
            using (var context = new LBDataEntities())
            {
                context.Connection.Open();

                var query = context.tblClients.Where(x => x.ClientId == clientId);
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

        public void RemoveClient(int clientId)
        {
            try
            {
                DeleteClientOrderItems(clientId);
                DeleteClientOrders(clientId);
                DeleteClient(clientId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void DeleteClient(int clientId)
        {
            using (var context = new LBDataEntities())
            {
                context.Connection.Open();
                var query = context.tblClients.Where(x => x.ClientId == clientId);
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
        private void DeleteClientOrders(int clientId)
        {
            // TODO
        }
        private void DeleteClientOrderItems(int clientId)
        {
            // TODO
        }

        public LbClient GetClientProfile(int clientId)
        {
            try
            {
                return QueryClientProfile(clientId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private LbClient QueryClientProfile(int clientId)
        {
            LbClient clientProfile = new LbClient(String.Empty, DateTime.Now);
            using (var context = new LBDataEntities())
            {
                context.Connection.Open();
                var query = context.tblClients.Where(x => x.ClientId == clientId);
                if (query != null && query.Any())
                {
                    var entry = query.First();
                    clientProfile.ClientName = entry.ClientName;
                    clientProfile.ContactName = entry.ContactName;
                    clientProfile.ContactEmail = entry.ContactEmail;
                    clientProfile.ContactPhoneNumber = entry.ContactPhoneNumber;
                    if (entry.AccountOpenDate.HasValue) { clientProfile.AccountOpened = entry.AccountOpenDate.Value; }
                }
            }

            return clientProfile;
        }

        public string GetClientName(int clientId)
        {
            try
            {
                return QueryClientName(clientId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private string QueryClientName(int clientId)
        {
            string clientName = "Unknown";
            using (var context = new LBDataEntities())
            {
                context.Connection.Open();
                var query = context.tblClients.Where(x => x.ClientId == clientId);
                if (query != null && query.Any())
                {
                    var entry = query.First();
                    clientName = entry.ClientName;
                }
            }
            return clientName;
        }

        public int GetClientId(string clientName)
        {
            try
            {
                return QueryClientId(clientName);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private int QueryClientId(string clientName)
        {
            int clientId = -1;
            using (var context = new LBDataEntities())
            {
                context.Connection.Open();
                var query = context.tblClients.Where(x => x.ClientName == clientName);
                if (query != null && query.Any())
                {
                    var entry = query.First();
                    clientId = entry.ClientId;
                }
            }
            return clientId;
        }
    }
}
