namespace UniMartAPI.DTOs.User
{
    public class UserProfileDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public int ProductCount { get; set; }
        public List<UserProductDto> Products { get; set; }
    }


}
