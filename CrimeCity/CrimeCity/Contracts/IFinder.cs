using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.Contracts
{
    public interface IFinder<TEntity, TCriteria>
    {
        List<TEntity> Find(TCriteria criteria);
    }
}
