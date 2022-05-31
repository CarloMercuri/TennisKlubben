using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisKlubben.Data
{
    public class DataHandling
    {
        DatabaseHandler db = new DatabaseHandler();

        public bool InsertNewUser(string firstName, string lastName, string address, string telephone, DateTime birthDate)
        {
            DatabaseQueryResponse attempt = db.InsertNewUser(firstName, lastName, address, telephone, birthDate);

            return attempt.Success;
        }
    }
}