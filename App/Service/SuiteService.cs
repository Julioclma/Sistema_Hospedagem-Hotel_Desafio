using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;
using SistemaHospedagemHotel.App.Repository;

namespace SistemaHospedagemHotel.App.Service
{
    public class SuiteService
    {
        SuiteRepository SuiteRepository;
        public SuiteService(SuiteRepository suiteRepository)
        {
            SuiteRepository = suiteRepository;
        }
        public bool Create(Suite suite)
        {
            return SuiteRepository.Create(suite);
        }
        public List<Suite> All()
        {
            return SuiteRepository.All();
        }
       public Suite FindBySuiteId(int IdSuite)
        {
            return SuiteRepository.FindBySuiteId(IdSuite);
        }
    }
}