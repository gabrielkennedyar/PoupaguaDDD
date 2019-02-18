using System;

namespace PoupaguaDDD.Domain.Value_Objects.Usuarios
{
    public class DataNasc
    {
        public static bool Validar(DateTime dataNasc)
        {
            return (DateTime.Now - dataNasc.Date).Days / 365.2425 >= 18;
        }
    }
}
