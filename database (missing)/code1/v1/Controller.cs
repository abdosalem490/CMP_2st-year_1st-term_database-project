using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
    
namespace v1
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        //TODO : EDIT this function to insert a reader
        public int InsertEmployee(string Fname, string Lname, int SSN, DateTime birthDate, string Minit)
        {
            string date = "'" + birthDate.Year + "-" + birthDate.Month + "-" + birthDate.Day + "'";
            string query = "INSERT INTO Employee (Fname, Lname, Minit, Bdate,SSN) " +
                            "Values ('" + Fname + "','" + Lname + "','" + Minit +
                            "'," + date + "," + SSN + ");";
            return dbMan.ExecuteNonQuery(query);
        }

       
        //TODO : EDIT this function to use it to check for the email entered to log in 
        public DataTable SelectAll(string tableName)
        {
            string query = "SELECT * FROM " + tableName + ";";
            return dbMan.ExecuteReader(query);
        }

        

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
