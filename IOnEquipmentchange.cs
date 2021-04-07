using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public interface IOnEquipmentChange
    {
        void OnEquipmentChange(Equipment newEquipment, Equipment oldEquipment);
    }
}
