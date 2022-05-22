namespace CadeMeuPet.Extensions
{
    public class Response
    {
        private static bool _HasError;

        public bool HasError{ get => _HasError; set => _HasError = false; }
        public string MsgReturn { get; set; }        
    }
}
