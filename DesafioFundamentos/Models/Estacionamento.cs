// Arquivo: Estacionamento.cs
using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public override string ToString()
        {
            return $"Placa: {Placa}";
        }
    }

    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<Veiculo> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();

            Veiculo novoVeiculo = new Veiculo
            {
                Placa = placa
            };

            veiculos.Add(novoVeiculo);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a ser removido:");
            string placa = Console.ReadLine();

            Veiculo veiculoParaRemover = veiculos.Find(v => v.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));

            if (veiculoParaRemover != null)
            {
                veiculos.Remove(veiculoParaRemover);
                Console.WriteLine("Veículo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Lista de Veículos:");
            foreach (Veiculo veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }

        public decimal CalcularCustoEstacionamento(int horasEstacionado)
        {
            return precoInicial + (precoPorHora * horasEstacionado);
        }
    }
}

