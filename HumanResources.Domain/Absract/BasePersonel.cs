namespace HumanResources.Domain.Absract
{
    public class BasePersonel
    {
        public int PersonelId { get; set; }

        public int IdentityId { get; set; }

        public DateTime LoginDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
               
        public DateTime Birthday { get; set; }

        public int PermissionDays { get; set; }

        public int Salary { get; set; }

        public Gender Gender { get; set; }
    }
    public enum Gender 
    { 
       Male=1,
       Female=2
    }
}
