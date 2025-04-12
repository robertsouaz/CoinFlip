using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Coin
    {
        private string ladoSorteado;

        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }
        public Coin()
        { // construtor não pode o mesmo nome da classe
            

        }
        public string Flip()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                ladoSorteado = "coroa"; // valor padrão
            }
            else
            {
                ladoSorteado = "cara"; // valor padrão
            }
            
            // ladoSorteado = random.Next(2) == 0 ? "cara" : "coroa"; // operador ternário

            return (ladoSorteado);
        }

    }
}
