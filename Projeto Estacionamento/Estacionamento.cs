namespace DesafioFundamentos.Models {
    public class Estacionamento {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo() {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            var placa = Console.ReadLine().Trim();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
                Console.WriteLine("Desculpe, esse veículo já está estacionado aqui. Confira se digitou a placa corretamente");
            }
            else {
                veiculos.Add(placa.ToUpper());

                Console.WriteLine("O veículo foi estacionado.");
            }
        }

        public void RemoverVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            var placa = Console.ReadLine().Trim();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                var horasEstacionado = Console.ReadLine().Trim();

                if (int.TryParse(horasEstacionado, out var horas)) {
                    decimal valorTotal = (horas * precoPorHora) + precoInicial;

                    veiculos.Remove(placa.ToUpper());

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else {
                    Console.WriteLine("Desculpe, não consegui compreender esse valor. Confira se digitou a placa corretamente");
                }
            }
            else {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos() {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são:");
                // Exibindo os veículos estacionados

                veiculos.ForEach(x => {
                    Console.WriteLine(x);
                });
            }
            else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
