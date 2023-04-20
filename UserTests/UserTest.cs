namespace UserNamespace.UserTests
{
    public class UserTest
    {
        [Fact]
        public void User_Constructor_CreatesUserObject()
        {
            User user1 = new User("James", "jcep@gmail.com");
            Assert.Equal("James", user1.Name);
            Assert.Equal("jcep@gmail.com", user1.Email);
        }
        [Fact]
        public void User_IsSetupComplete_ReturnTrueOrFalse()
        {
            User user1 = new User("James", "jcep@gmail.com");
            bool ToF = user1.IsSetupComplete();
            Assert.Equal(ToF, user1.IsSetupComplete());
        }
        [Fact]
        public void User_CreatePassword_PasswordSetSuccessfully()
        {
            User user1 = new User("James", "jcep@gmail.com");
            user1.CreatePassword("jcep@gmail.com", "ThisIsMyPassword");
            Assert.Equal("ThisIsMyPassword", user1.CreatePassword("ThisIsMyPassword"));
        }
        [Fact]
        public void User_LogIn_ReturnString()
        {
            User user1 = new User("James", "jcep@gmail.com");
            user1.LogIn("ThisIsMyPassword");
            Assert.Equal("ThisIsMyPassword", user1.IsLoggedIn);
        }
        [Fact]
        public void User_LogOut_ReturnFalse()
        {
            User user1 = new User("James", "jcep@gmail.com");
            user1.LogOut();
            Assert.Equal("jcep@gmail.com", user1.Email);

        }
    }
}