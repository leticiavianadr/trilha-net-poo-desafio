namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor para inicializar as propriedades específicas de iPhone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Configurações específicas de inicialização para iPhone
        }

        // Implementação específica para instalar aplicativo em um iPhone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no DUT iPhone.");
        }
    }
}
