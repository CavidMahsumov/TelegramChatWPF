using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AzeriChat
{
    static public class IService
    {
       static public string GetResponseForSalam()
        {
            List<string>SalamRequest = new List<string>
            {
                "Salam","Aleykum Salam","Salam Aleykum"
            };

            Random random = new Random();
            int index = random.Next(SalamRequest.Count);
            return SalamRequest[index];

        }
        static public string GetResponseForNecesen()
        {
            List<string> NecesenRequest = new List<string>
            {
                "Sagol.Sen Necesen?","Sukur Sen Necesen?","Yaxsi"
            };

            Random random = new Random();
            int index = random.Next(NecesenRequest.Count);
            return NecesenRequest[index];

        }
        static public string GetResponseForHardasan()
        {
            List<string> HardasanRequest = new List<string>
            {
                "Evde","Ishde","Colde"
            };

            Random random = new Random();
            int index = random.Next(HardasanRequest.Count);
            return HardasanRequest[index];

        }
        static public string GetResponseForNeyneyirsen()
        {
            List<string> NeyneyirsenRequest = new List<string>
            {
                "Yatiram","Kinoya Baxiram","Kod Yaziram","Oyun Oynayiram"
            };

            Random random = new Random();
            int index = random.Next(NeyneyirsenRequest.Count);
            return NeyneyirsenRequest[index];

        }
        static public string GetResponseRandom()
        {
            List<string> NeyneyirsenRequest = new List<string>
            {
                "IdmanDa","Seherde","Sagol","2 deq catiram"
            };

            Random random = new Random();
            int index = random.Next(NeyneyirsenRequest.Count);
            return NeyneyirsenRequest[index];

        }
    }
}
