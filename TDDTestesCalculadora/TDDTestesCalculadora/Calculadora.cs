namespace CalculadoraProj
{
    public class Calculadora
    {
        private List<string> _listahistorico;

        public Calculadora()
        {
            _listahistorico = new List<string>();
        }


        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            _listahistorico.Insert(0, $"Result: {resultado}");
            return resultado;
        }
        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            _listahistorico.Insert(0, $"Result: {resultado}");
            return resultado;
        }
        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            _listahistorico.Insert(0, $"Result: {resultado}");
            return resultado;
        }
        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            _listahistorico.Insert(0, $"Result: {resultado}");
            return resultado;
        }

        public List<string> Historico()
        {
            _listahistorico.RemoveRange(3, _listahistorico.Count - 3);
            return _listahistorico;
        }
    }
}
