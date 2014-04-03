using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class Autocamper : Vehicle
    {
        int NumOfSeats;
        int NumOfSleepSeats;
        bool Toilet;
        int HeatSource; //Change to enum. Mulige værdier er: gas, strøm eller oliefyr.
        /*
         * Energiklasse 
            o Autocamperens varmesystem spiller ind på hvilken energiklasse den bliver placeret i. 
            Hvis autocamperen bruger oliefyr, så skal km/l ganges med 0.7 inden energiklassen 
            beregnes. 
            o Hvis autocamperen bruger strøm, så skal km/l ganges med 0.8 inden energiklassen 
            beregnes. 
            o Hvis autocamperen bruger gas, så skal km/l ganges med 0.9 inden energiklassen 
            beregnes. 
            o Eksempel: En benzin-drevet autocamper fra 2007 der kører 18.5 km/l (klasse A) vil med 
            oliefyr havne i klasse C (18.5 * 0.7 = 12.95), mens en strøm-udgave vil havne i klasse B 
            (18.5 * 0.8 = 14.8) 
           Kørekorttype 
            o Er altid B.         */

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
