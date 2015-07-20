using CrimeCity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeCity.BusinessLogic.Transformers
{
    public abstract class CollectionTransformer<TTO, TFROM> : ITransformer<TTO, TFROM>
    {
        public abstract TTO Translate(TFROM from);

        public List<TTO> Translate(List<TFROM> from)
        {
            return from.Select(x => Translate(x))
                       .ToList();
        }
    }
}