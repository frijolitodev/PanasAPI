namespace Domain.BaseIdentities
{
    public class BaseIdentity
    {
        public string FullName { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public IdentityRole Identity { get; set; }
    }
}