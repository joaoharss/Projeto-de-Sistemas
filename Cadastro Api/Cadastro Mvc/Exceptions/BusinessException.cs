namespace Cadastro_Mvc.Exceptions
{
    [Serializable]
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { } 
    }
}
