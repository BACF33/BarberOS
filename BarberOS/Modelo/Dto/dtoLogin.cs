namespace BarberOS.Modelo.Dto
{
    public class DtoLogin : dbContext
    {
        private string userName;
        private string userPass;

        public string UserName { get => userName; set => userName = value; }
        public string UserPass { get => userPass; set => userPass = value; }
    }
}
