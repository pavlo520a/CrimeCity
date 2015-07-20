using CrimeCity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.Repositories
{
    public class CrimeCityRepository
    {
        private CrimeCity.DB.CrimeCityModel _model = new DB.CrimeCityModel();

        protected CrimeCity.DB.CrimeCityModel Model
        {
            get { return _model; }
        }
    }
}