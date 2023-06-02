using dfdfgs;
using System.Runtime.InteropServices;

namespace Course
{
    struct Carro
    {
        //dados da struct
        public string Marca;
        public int Ano;
        public string Cor;

        //construtor
        public Carro( string Marca, int Ano, string Cor)
        {
            this.Marca = Marca;
            this.Ano = Ano;
            this.Cor = Cor;
        }

        //método
        public void Info()
        {
            Console.WriteLine(this.Marca);
            Console.WriteLine(this.Ano);
            Console.WriteLine(this.Cor);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroNovo;
            carroNovo.Marca = "honda";
            carroNovo.Ano = 2010;
            carroNovo.Cor = "Preto";

            Console.WriteLine(carroNovo.Marca);
            Console.WriteLine(carroNovo.Ano);
            Console.WriteLine(carroNovo.Cor);

            carroNovo.Info();


        }
    }

}
