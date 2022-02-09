using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklenmiştir");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silinmiştir");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellenmiştir");
        }
    }
}
