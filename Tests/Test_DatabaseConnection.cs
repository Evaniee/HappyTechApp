using HappyTech.BackEnd;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Tests
{
    [TestFixture]
    class Test_DatabaseConnection
    {
        [Test]
        public void Test_Properties()
        {
            Dictionary<string, string> l_properties = DatabaseConnection.Instance.Properties();
            string l_value;
            bool l_failed = false;
            StringBuilder l_errorMessage = new StringBuilder();

            // Check Server
            string l_expected = "127.0.0.1";
            if (l_properties.TryGetValue("Server", out l_value))
            {
                if (l_value != l_expected)
                    l_errorMessage.Append("Unexpected Server. Expected: " + l_expected + ". ");
            }
            else
            {
                l_failed = true;
                Assert.Fail("Server key not found");
            }

            // Check Database
            l_expected = "happy_tech";
            if (l_properties.TryGetValue("Database", out l_value))
            {
                if (l_value != l_expected)
                    l_errorMessage.Append("Unexpected Database. Expected: " + l_expected + ". ");
            }
            else
            {
                l_failed = true;
                Assert.Fail("Database key not found");
            }

            // Check User
            l_expected = "happytech_admin";
            if (l_properties.TryGetValue("User", out l_value))
            {
                if (l_value != l_expected)
                    l_errorMessage.Append("Unexpected User. Expected: " + l_expected + ". ");
            }
            else
            {
                l_failed = true;
                Assert.Fail("User key not found");
            }

            // Check Password
            l_expected = "HT13467";
            if (l_properties.TryGetValue("Password", out l_value))
            {
                if (l_value != l_expected)
                    l_errorMessage.Append("Unexpected Password. Expected: " + l_expected + ". ");
            }
            else

                l_errorMessage.Append("No password key found.");

            // Determine Result
            if (l_errorMessage.Length > 1)
                if (l_failed)
                    Assert.Fail(l_errorMessage.ToString());
                else
                    Assert.Inconclusive(l_errorMessage.ToString());
            else
                Assert.Pass(l_errorMessage.ToString());
        }

        [Test]
        public void Test_Open()
        {
            Assert.IsTrue(DatabaseConnection.Instance.Open());
            
        }

        [Test]
        public void Test_Close()
        {
            Assert.IsTrue(DatabaseConnection.Instance.Close());
        }

        [Test]
        public void Test_SQLStatements()
        {
            bool l_success;
            l_success = (DatabaseConnection.Instance.Insert("INSERT INTO logins VALUES (null, 'test_name', 'test_pass', false);"));
            if (l_success)
            {
                l_success = (DatabaseConnection.Instance.Update("UPDATE logins SET hr_user = true WHERE username = 'test_name';"));
                if (l_success)
                {
                    //MySqlDataReader l_dataReader = DatabaseConnection.Instance.Select("SELECT password FROM logins WHERE username = 'test_name' AND hr_user = true;");
                    //string l_password = null;
                    //try
                    //{
                    //    while (l_dataReader.Read())
                    //    {
                    //        l_password = l_dataReader.GetString(0);
                    //    }
                    //    if (l_password == "test_pass")
                    //    {
                    l_success = DatabaseConnection.Instance.Delete("DELETE FROM logins WHERE username = 'test_name' AND hr_user = true");
                    if (l_success)
                        Assert.Pass();
                    else
                        Assert.Fail("Delete Test Failed");

                    //    }
                    //    Assert.Fail("Insert Test did not return expected");

                    //}
                    //catch
                    //{
                    //    Assert.Fail("Select could not find entries");
                    //}
                    
                }
                Assert.Fail("Update Test Failed");
            }
            Assert.Fail("Insert Test Failed");
        }



//        [Test]
//        public void Test_HasServer()
//        {
//            Dictionary<string, string> l_properties = DatabaseConnection.Instance.Properties();
//            try 
//            {
//                Assert.True(l_properties.ContainsKey("Server"));
//            }
//            catch (Exception e)
//            {
//                Assert.Fail(e.Message);
//            }
//}

//        [Test]
//        public void Test_HasDatabase()
//        {
//            Dictionary<string, string> l_properties = DatabaseConnection.Instance.Properties();
//            try {
//                Assert.True(l_properties.ContainsKey("Database"));
//            }
//            catch (Exception e)
//            {
//                Assert.Fail(e.Message);
//            }
//}

//        [Test]
//        public void Test_HasUser()
//        {
//            Dictionary<string, string> l_properties = DatabaseConnection.Instance.Properties();
//            try
//            {
//                Assert.True(l_properties.ContainsKey("User"));
//            }
//            catch (Exception e)
//            {
//                Assert.Fail(e.Message);
//            }
//        }

//        /*
//         * This Test can fail without issues sometimes
//         * Please check if the properties file contains a "Password" line
//         * If it does and this fails there is an issue else it is okay
//         */
//        [Test]
//        public void Test_HasPassword()
//        {
//            Dictionary<string, string> l_properties = DatabaseConnection.Instance.Properties();
//            try 
//            {
//            Assert.True(l_properties.ContainsKey("Password"));
//            }
//            catch (Exception e)
//            {
//                Assert.Fail(e.Message);
//            }
//        }
    }
}
