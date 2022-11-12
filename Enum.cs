using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_POS_X
{
    internal class Enum
    {
        public enum POPUPSTATUS
        {
            OK,
            CANCEL,
            ERROR
        }
       public enum MenuList {
            COFFEE,
            NON_COFFEE,
            SMOOTHIE,
            Dessert,
            ETC
        }
        public enum SelectSwitch
        {
            Payment,
            Sale,
            Aamount_received,
            Aamount_remaining
        }



    }
}
