using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class PersonVehiclePrivate : PersonVehicle
    {
        private bool _isofixMount;

        public LicenseType LicenseType
        {
            get { return _licenseType; }
        }

        public PersonVehiclePrivate()
        {
            _licenseType = LicenseType.B;
        }

        public PersonVehiclePrivate(string Name, uint Km, int Year, double NewPrice, bool TowHook, double KmL, int Seat, double[] Dimensions, bool IsofixMount)
        {
            this.Name = Name;
            this.Km = Km;
            _year = Year;
            this.NewPrice = NewPrice;
            this.TowHook = TowHook;
            this.KmL = KmL;
            this.Seat = Seat;
            this._dimensions = Dimensions;
            _licenseType = LicenseType.B;
            this._isofixMount = IsofixMount;
        }
    }
}
