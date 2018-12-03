using System;

namespace Business
{
    public class Validacao
    {
        public bool ValidaConta(string conta)
        {
            try
            {
                int numConta = int.Parse(conta);
                return true;
            }
            catch (Exception) { return false; }
        }

        public bool ValidaValor(string valor)
        {
            try
            {
                float valorFloat = float.Parse(valor);
                return true;
            }
            catch (Exception) { return false; }
        }
    }
}