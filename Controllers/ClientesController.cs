using PrimeiraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrimeiraApi.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();


        //Metodo get, pegando valores
        public List<Cliente> Get()
        {
            return clientes;
        }

        //Metodo post, inserindo valores
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Cliente(nome));
                
            }
        }

        public void Delete(string nome)
        {

            //Link
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
                
            }
        }
    }
}
