namespace EmprestimosLivros.API.Errors
{
    //Todas excecoes que virem, retornarao no formato desta classe.
    //Isso sera lido atraves do middleware:
    public class ApiException
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

        public ApiException(string statusCode, string message, string details)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }
    }
}
