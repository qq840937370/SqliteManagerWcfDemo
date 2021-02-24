using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqliteManagerWcfServiceTest.ServiceReference1;

namespace SqliteManagerWcfServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SqliteManagerWcfSClient sqliteManagerWcfSClient = new SqliteManagerWcfSClient();
            IList<CommentDataModel> ss = sqliteManagerWcfSClient.GetCommentData();
        }
    }
}
