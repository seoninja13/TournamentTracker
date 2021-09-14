using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        // Interface doesnt have code/ has only implementation. We have only public items. Whoever is using 'IDataConnection' interface has to implement the 'CreatePrize' method.
        PrizeModel CreatePrize(PrizeModel model);
    }
}
