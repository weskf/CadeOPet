namespace CadeMeuPet.Extensions
{
    public class Response
    {
        private static bool _HasError;

        public bool HasError { get; set; }
        public string MsgReturn { get; set; }
    }
}
