namespace SnowCrashBank.Models   
{
    public enum AccountType
    {
        A, B, C
    }

    public class Join
    {
        public int JoinId { get; set; }
        public int UserAccountID { get; set; }
        public int ProfileID { get; set; }
        public AccountType? Type { get; set; }

        public virtual AccountType Types { get; set; }
        public virtual Profile account { get; set; }
    }
}