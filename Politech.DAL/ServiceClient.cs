using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Politech.DAL.Model;

namespace Politech.DAL
{
    public class ServiceClient
    {
        public List<Client> GetAllClients()
        {
            List<Client> clients = null;
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                var col = db.GetCollection<Client>("Client")
                .FindAll()
                .ToList();
            }

            return clients;
        }

        public Client GetClientById(string Id)
        {
            Client client = null;
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                var col = db.GetCollection<Client>("Client")
                .FindById(Id);
            }

            return client;
        }

        public bool CreateClient(Client client)
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                var clients = db.GetCollection<Client>("Client");
                clients.Insert(client);
            }

            return true;
        }

    }
}
