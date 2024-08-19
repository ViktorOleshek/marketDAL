using Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public abstract class AbstractRepository(TradeMarketDbContext context)
    {
        protected TradeMarketDbContext Context { get; } = context;
    }
}
