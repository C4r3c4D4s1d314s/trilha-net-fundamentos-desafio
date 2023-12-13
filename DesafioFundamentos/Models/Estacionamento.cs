using System.Runtime.CompilerServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado");
                        
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*

            placa = Console.ReadLine();
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0; 

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                
                 if (int.TryParse(Console.ReadLine(), out horas))
                    {
                        // O valor foi convertido com sucesso
                        // Agora podemos usar a variável 'horas' como um número inteiro
                        Console.WriteLine($"Veículo estacionado por {horas} horas.");
                    }
                else        
                {
                    // A entrada não pôde ser convertida para um número inteiro
                    Console.WriteLine("Por favor, digite um número válido de horas.");
                }

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                valorTotal = precoInicial + (horas * precoPorHora);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var veiculos in veiculos)
                {
                    Console.WriteLine(veiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
