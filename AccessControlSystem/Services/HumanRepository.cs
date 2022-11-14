using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static AccessControlSystem.Services.HumanRepository;

namespace AccessControlSystem.Services
{
    public class HumanRepository
    {
        public List <Human> humans = new List <Human> ();
        public void HumanList()
        {

            humans = new List<Human>() {
            new Human(){ Id = 1, FirstName = "Dovydas", SecondName = "Ivanauskas"},
            new Human() { Id=2, FirstName = "Tomas", SecondName = "Tomejus"},
            new Human(){Id=3, FirstName = "Gerda", SecondName = "Vaiciute"},

            };
        }
    }
}