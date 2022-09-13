// See https://aka.ms/new-console-template for more information
namespace metodos{
    class program{
        public static void Main(String[] args){
            Console.WriteLine("Hello, World!");
            carro carro = new carro();
        }
    }
    public class carro{
        public float preco;
        public string nome;

        public bool ligar(){
            console.WriteLine("Carro Ligado!");    
        }
    }
}