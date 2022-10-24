using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Interfaces
{
    public interface ITrade
    {
        DateTime NextPaymentDate { get;  }
        double Value { get;  }
        string ClientSector { get;  }
        List<ITrade> Trades { get;  }
    }
}
