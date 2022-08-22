using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockMangement
{
    public class Stock
    {
            
        public List<Banking> banking;
        public List<Finance> finance;
        public List<Metals> metals;
        public List<Health> health;
    }

    public class Banking
    {
        public string stockName;
        public int numberOfShares;
        public int price;
    }
    public class Finance
    {
        public string stockName;
        public int numberOfShares;
        public int price;
    }
    public class Metals
    {
        public string stockName;
        public int numberOfShares;
        public int price;
    }
    public class Health
    {
        public string stockName;
        public int numberOfShares;
        public int price;
    }

}
