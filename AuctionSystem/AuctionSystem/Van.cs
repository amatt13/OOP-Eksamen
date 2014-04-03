using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class Van : Car
    {
        bool SafetyBar; //Angiver hvorvidt der findes en sikkerhedsbøjle bag førersædet. 
        int LoadCapacity; // Angiver hvor meget påhængsvægt bilen kan køre med. Hvis vægten overstiger 750 kg. kræver det et BE kørekort 
    }
}
