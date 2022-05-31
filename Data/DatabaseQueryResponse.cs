using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TennisKlubben.Data
{
    public class DatabaseQueryResponse
    {
        public bool Success { get; set; }
        public DateTime TimeStamp { get; set; }
        public DataTable Data { get; set; }
        public string ResponseMessage { get; set; }

    }
}