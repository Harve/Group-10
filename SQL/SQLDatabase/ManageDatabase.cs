﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SQLDatabase
{
    class ManageDatabase
    {
        public static void CreateDatabase()
        {
            if (File.Exists("Database.sqlite"))
            {
                File.Delete("Datebase.sqlite");
            }

            SQLiteConnection.CreateFile("Database.sqlite");

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "create table user (userid varchar(8),firstname varchar(20), surname varchar(20), role varchar(30))";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();



            sql = "create table programme (programmeid varchar(8),title varchar(40), userid varchar(8) )";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();



            sql = "create table module (moduleid varchar(8),title varchar(40), programmeid varchar(8))";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table assessment (assessmentid varchar(8),title varchar(40), moduleid varchar(8) )";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table moduleteam( userid varchar(8), moduleid varchar(8), isLeader boolean)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table deadline( moduleid varchar(8), information varchar(80), deadlinedate datetime)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
    }
}