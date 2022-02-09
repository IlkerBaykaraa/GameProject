using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer))
            {
                Console.WriteLine("Ekleme başarılı");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Silme başarılı");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncelleme başarılı");
        }
    }
}
