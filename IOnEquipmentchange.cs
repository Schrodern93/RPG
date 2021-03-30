using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    interface IOnEquipmentchange
    {

        public Equipment OnEquipmentchange(Equipment newEquipment, Equipment oldEquipment);

    }
}
