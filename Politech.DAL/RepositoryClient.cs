using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Politech.DAL.Model;

namespace Politech.DAL
{

    public class RepositoryClient
    {
        private readonly string path;

        public RepositoryClient (string path)
        {
            this.path = path;
        }

        public ReturnResultClient GetAllClients()
        {
            ReturnResultClient result = new ReturnResultClient();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var col = db.GetCollection<Client>("Client")
                    .FindAll()
                    .ToList();
                }
            }
            catch (Exception ex) {
                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }

        public ReturnResultClient GetClientById(string Id)
        {
            ReturnResultClient result = new ReturnResultClient();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var col = db.GetCollection<Client>("Client")
                    .FindById(Id);
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }


        public ReturnResultClient CreateClient(Client client)
        {
            ReturnResultClient result = new ReturnResultClient();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var clients = db.GetCollection<Client>("Client");
                    clients.Insert(client);
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }

    }
}
