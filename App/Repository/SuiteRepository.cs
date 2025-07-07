using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;

namespace SistemaHospedagemHotel.App.Repository
{
    public class SuiteRepository
    {
        public List<Suite> Suites;
        public SuiteRepository()
        {
            Suites = new List<Suite>();
        }
        public bool Create(Suite suite)
        {
            Suites.Add(suite);
            if (Suites.Contains(suite))
            {
                return true;
            }

            return false;
        }
        public List<Suite> All()
        {
            return Suites;
        }

        public Suite FindBySuiteId(int idSuite)
        {
            try
            {
                Suite suite = Suites.Find(suite => suite.IdSuite == idSuite);
                return suite;
            }
            catch (System.Exception)
            {
                throw new Exception("Suite não encontrada");
            }
        }
    }
}