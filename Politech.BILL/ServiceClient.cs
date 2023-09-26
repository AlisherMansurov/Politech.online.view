using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Politech.DAL;
using Politech.DAL.Model;

namespace Politech.BILL
{
    public class ServiceClient
    {
        private readonly string path = "";
        public ServiceClient(string path) {
            this.path = path;
        }
        public (bool IsEror, string message) RegisterClient(Client client)
        {
            RepositoryClient repo = new RepositoryClient(path);
            ReturnResultClient result = repo.CreateClient(client);
            return (result.IsError, result.Exception != null ? result.Exception.Message : "");
        }
    }
}
