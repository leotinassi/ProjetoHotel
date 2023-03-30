using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Modells {
    public class Reserva {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados) {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes) {
            
            if (hospedes.Count <= Suite.Capacidade) {
                Hospedes = hospedes;
            } else {
                
                throw new ArgumentException("O numero de Hospedes é maior que a capacidade que a Suite comporta.");
            }
        }

        public void CadastrarSuite(Suite suite) {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() {
            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria() {
            
            decimal valor = 0;

            valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10) {

                decimal desconto = 0;
                desconto = valor * (int)0.10; 
                valor = valor - desconto;
            }

            return valor;
        }
    }
}
