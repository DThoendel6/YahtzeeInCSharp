using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    class YahtzeeDA
    {
        public static User GetUser(string username)
        {
            User user = new User();
            // you need a connection object
            SqlConnection conn = YahtzeeDBA.GetYahtzeeConnection();
            // you need a sql statement
            string selectStatement = "Select * from Users where Username = @username";

            // you need a command object
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@username", username);

            try
            {
                // open the connection
                conn.Open();

                // execute the command
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    // pull the data
                    user.UserId = Convert.ToInt16(reader["UserId"]);
                    user.Username = reader["Username"].ToString();
                    user.UserHighScore = Convert.ToInt16(reader["UserHighScore"]);
                    user.UserNumberOfGamesPlayed = Convert.ToInt16(reader["UserNumberOfGamesPlayed"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return user;
        }
        public static bool CheckUsernameAvailability(string username)
        {
            bool pass = false;
            User user = new User();

            // you need a connection object
            SqlConnection conn = YahtzeeDBA.GetYahtzeeConnection();

            // you need a sql statement
            string selectStatement = "Select * from Users where Username = @username";

            // you need a command object
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@username", username);

            try
            {
                // open the connection
                conn.Open();

                // execute the command
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    // pull the data
                    user.UserId = Convert.ToInt16(reader["UserId"]);
                    user.Username = reader["Username"].ToString();
                    user.UserHighScore = Convert.ToInt16(reader["UserHighScore"]);
                    user.UserNumberOfGamesPlayed = Convert.ToInt16(reader["UserNumberOfGamesPlayed"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            if (user.Username == null)
                pass = true;            
            else
                pass = false;
            //returns true if the username is available
            return pass;
        }
        public static bool CheckPassword(string username, string password)
        {
            bool pass = false;
            User user = new User();

            // you need a connection object
            SqlConnection conn = YahtzeeDBA.GetYahtzeeConnection();

            // you need a sql statement
            string selectStatement = "Select * from Users where Username = @username AND UserPassword = @password";

            // you need a command object
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@username", username);
            selectCommand.Parameters.AddWithValue("@password", password);
            try
            {
                // open the connection
                conn.Open();

                // execute the command
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    // pull the data
                    user.UserId = Convert.ToInt16(reader["UserId"]);
                    user.Username = reader["Username"].ToString();
                    user.UserHighScore = Convert.ToInt16(reader["UserHighScore"]);
                    user.UserNumberOfGamesPlayed = Convert.ToInt16(reader["UserNumberOfGamesPlayed"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (user.Username == null)//there were no matches with that username and password
                pass = false;
            else
                pass = true;
           //returns true if that username and password found a user
            return pass;
        }
        public static void AddPlayer(User user, string password)
        {
            int numRows = 0;
            SqlConnection conn = YahtzeeDBA.GetYahtzeeConnection();

            string insertStatement = "INSERT INTO Users ( Username, UserPassword, UserHighScore, UserNumberOfGamesPlayed)" +
                "VALUES( @Username, @UserPassword, @UserHighScore, @UserNumberOfGamesPlayed)"; 

            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            //insertCommand.Parameters.AddWithValue("@UserId", user.UserId);
            insertCommand.Parameters.AddWithValue("@Username", user.Username);
            insertCommand.Parameters.AddWithValue("@UserPassword", password);
            insertCommand.Parameters.AddWithValue("@UserHighScore", user.UserHighScore);
            insertCommand.Parameters.AddWithValue("@UserNumberOfGamesPlayed", user.UserNumberOfGamesPlayed);
            try
            {
                conn.Open();
                numRows = insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return;
        }  
        public static int getTheHighScore() 
        {
            int score = 0;
            SqlConnection conn = YahtzeeDBA.GetYahtzeeConnection();

            string selectStatement = "SELECT MAX(UserHighScore) FROM Users";

            // you need a command object
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                    // open the connection
                conn.Open();

                    // execute the command
                score = Convert.ToInt16(selectCommand.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return score;
        }
        public static void UpdateUserScores(User player)
        {
            int numRows = 0;
            SqlConnection conn = YahtzeeDBA.GetYahtzeeConnection();

            string updateStatement = "Update Users set UserHighScore = @NewUserHighScore, " +
                "UserNumberOfGamesPlayed = @NewUserNumberOfGamesPlayed " +
                "WHERE Username = @theUserName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@NewUserHighScore", player.UserHighScore);
            updateCommand.Parameters.AddWithValue("@NewUserNumberOfGamesPlayed", player.UserNumberOfGamesPlayed);
            updateCommand.Parameters.AddWithValue("@theUserName", player.Username);

            try
            {
                conn.Open();
                numRows = updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return;
        }
    }
}
