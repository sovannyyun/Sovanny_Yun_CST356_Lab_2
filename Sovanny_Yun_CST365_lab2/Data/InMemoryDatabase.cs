using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sovanny_Yun_CST356_Lab2.Data.Entities;

namespace Sovanny_Yun_CST356_Lab2.Data
{
    public class InMemoryDatabase    // SingleTon: Access strictly through class name
    {
        public static List<User> Users { get; set; }
    }
}