using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public interface IConto
    {
        public void Preleva(int somma);
        public void Deposita(int somma);
    }
}
