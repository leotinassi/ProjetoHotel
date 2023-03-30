using ProjectHotel.Modells;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Cria os modelos hóspedes e cadastra na lista de hospedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria um nova reserva, passando a suíte e os hospedes

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibe a Quantidade de hospedes e o valor da diaria
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da Diária: {reserva.CalcularValorDiaria()}");


