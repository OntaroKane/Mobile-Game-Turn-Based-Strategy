//using System;
//using UnityEngine;
//using System.Data.SqlClient;

//public class ConnectorDB : MonoBehaviour
//{


//    string queryString = "SELECT username, picture, highscore FROM UserInfo";

//    void OpenSqlConnection()
//    {
//        string connectionString = GetConnectionString();

//        using (SqlConnection connection = new SqlConnection())
//        {
//            connection.ConnectionString = connectionString;

//            connection.Open();

//            Console.WriteLine("State: {0}", connection.State);
//            Console.WriteLine("ConnectionString: {0}",
//                connection.ConnectionString);
//        }
//    }

//}