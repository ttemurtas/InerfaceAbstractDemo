using InerfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using System.Threading.Tasks;

namespace InerfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            TCKimlikNoDogrulaRequest tCKimlikNoDogrula = new TCKimlikNoDogrulaRequest();
            var result = client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest()).Result;
            bool check = result.Body.TCKimlikNoDogrulaResult;
            return check;
        }
    }
}
