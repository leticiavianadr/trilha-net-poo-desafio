namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor para inicializar as propriedades específicas de Nokia
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Configurações específicas de inicialização para Nokia
        }

        // Implementação específica para instalar aplicativo em um Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no DUT Nokia.");
        }
    }
}