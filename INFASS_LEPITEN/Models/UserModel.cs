namespace INFASS_LEPITEN.Models
{
    public class UserModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Sql(
            string fullName,
            string email,
            int age,
            string gender,
            string username,
            string password,
            string confirmPassword)
        {
            string query =
                "INSERT INTO Users (FullName, Email, Age, Gender, Username, Password, ConfirmPassword) VALUES ('" +
                fullName + "','" +
                email + "'," +
                age + ",'" +
                gender + "','" +
                username + "','" +
                password + "','" +
                confirmPassword + "')";

            return query;
        }
    }
}