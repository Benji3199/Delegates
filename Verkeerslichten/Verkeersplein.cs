using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkeerslichten
{
    public delegate void SwitchVerkeerslicht();

    public class Verkeersplein
    {
        private event SwitchVerkeerslicht BaanSwitch;

        public void SubscribeVerkeerslicht(SwitchVerkeerslicht verkeerslicht)
        {
            BaanSwitch += verkeerslicht;
        }

        public void PublishLichtenOmswitchen()
        {
            BaanSwitch?.Invoke();
        }

        public override string ToString()
        {
            string result = "";
            var list = BaanSwitch.GetInvocationList();
            for(int i = 0; i < list.Length; i++)
            {
                result += list[i].Target.ToString();
                result += "\n";
            }
            return result;
        }
    }
}
