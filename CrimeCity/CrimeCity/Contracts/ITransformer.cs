using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeCity.Contracts
{
    public interface ITransformer<TTO, TFROM>
    {
        TTO Translate(TFROM from);
        List<TTO> Translate(List<TFROM> from);
    }
}
