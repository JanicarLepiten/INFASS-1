using Microsoft.AspNetCore.HttpLogging;

namespace INFASS_LEPITEN.Models
{
    public class UserModel
    {
        //public string FullName { get; set; }
        //public string Email { get; set; }
        //public int Age { get; set; }
        //public string Gender { get; set; }
        //public string Username { get; set; }
        //public string Password { get; set; }
        //public string ConfirmPassword { get; set; }

        //public string Sql(
        //    string fullName,
        //    string email,
        //    int age,
        //    string gender,
        //    string username,
        //    string password,
        //    string confirmPassword)
        //{
        //    string query =
        //        "INSERT INTO Users (FullName, Email, Age, Gender, Username, Password, ConfirmPassword) VALUES ('" +
        //        fullName + "','" +
        //        email + "'," +
        //        age + ",'" +
        //        gender + "','" +
        //        username + "','" +
        //        password + "','" +
        //        confirmPassword + "')";

        //----------------------------------------------------------INSERT CODE-------------------------------------------------------------------
        public String _Insert(string[] fields, string[] values, string tbName)
        {
 
        
        string query = "INSERT INTO "+tbName+" (";

        for (int i = 0; i<fields.Length; i++)
        {
            query += fields[i];

            if (i < fields.Length - 1)
                query += ",";
        }
            query += ") VALUES (";
        for (int i = 0; i<values.Length; i++)
        {
                if (int.TryParse(values[i], out _))
                {
                    // If value is a number, no quotes
                    query += values[i];
                }
                else
                {
                    // Otherwise, add quotes
                    query += "'" + values[i] + "'";
                }


                if (i < values.Length - 1)
                    query += ",";
            }
            query += ");";
 
            return query;
        }

        //-----------------------------------------UPDATE CODE-----------------------------------------------------
        public string _Update(string[] fields, string[] values, string tbName, string condition)
        {
            string query = "UPDATE " + tbName + " SET ";

            for (int i = 0; i < fields.Length; i++)
            {
                query += fields[i] + "=";

                if (decimal.TryParse(values[i], out _))
                {
                    // Numeric value (no quotes)
                    query += values[i];
                }
                else
                {
                    // String value (with quotes)
                    query += "'" + values[i] + "'";
                }

                if (i < fields.Length - 1)
                    query += ",";
            }

            query += " WHERE " + condition + ";";

            return query;
        }

        //-------------------------------------------DELETE CODE-------------------------------------------------------
        public string _Delete(string tbName, string condition)
        {
            string query = "DELETE FROM " + tbName +
                           " WHERE " + condition + ";";

            return query;
        }

        //-------------------------------------VIEW ALL-----------------------------------------
        public string _ViewAll(string tbName)
        {
            string query = "SELECT * FROM " + tbName + ";";

            return query;
        }
    }
}