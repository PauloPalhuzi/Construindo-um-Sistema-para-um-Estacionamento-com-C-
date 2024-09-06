namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Solicita ao usuário para digitar a placa do veículo
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Adiciona a placa do veículo à lista
            veiculos.Add(placa);

            // Confirma a adição do veículo
            Console.WriteLine($"Veículo com placa {placa} adicionado ao estacionamento.");
        }

        public void RemoverVeiculo()
        {
            // Solicita ao usuário para digitar a placa do veículo a ser removido
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo está na lista
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Solicita a quantidade de horas que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Lê e valida a quantidade de horas
                if (int.TryParse(Console.ReadLine(), out int horas) && horas >= 0)
                {
                    // Calcula o valor total
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    // Remove o veículo da lista
                    veiculos.Remove(placa);

                    // Exibe o valor total
                    Console.WriteLine($"O veículo com placa {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
                }
                else
                {
                    // Mensagem de erro se a quantidade de horas for inválida
                    Console.WriteLine("Quantidade de horas inválida. Por favor, insira um número inteiro positivo.");
                }
            }
            else
            {
                // Mensagem de erro se o veículo não for encontrado
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Percorre a lista de veículos e exibe cada placa
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                // Mensagem se não houver veículos
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
