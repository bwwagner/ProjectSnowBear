namespace SnowCrashBank.Models   
{
    public enum AccountType
    {
        A, B, C  // TODO: Define the types
    }

    
    public class Join
    {
        public int JoinId { get; set; }            // Separate profile and account IDs
        public int UserAccountID { get; set; }
        public int ProfileID { get; set; }
        public AccountType? Type { get; set; }     // TODO: Define the types

        public virtual AccountType Types { get; set; }
        public virtual Profile account { get; set; }
    }
}