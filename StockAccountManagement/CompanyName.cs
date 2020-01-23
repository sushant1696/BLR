using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.StockAccountManagement
{
    /// <summary>
    /// This class created for implementing the company name
    /// where CompanyName is class 
    /// </summary>
    class CompanyName
    {
         private List<Amazon> amazon = new List<Amazon>();
        private List<Flipkart> flip = new List<Flipkart>();
        private List<Tcs> tcs = new List<Tcs>();

        public List<Amazon> Amazon { get => amazon; set => amazon = value; }
        public List<Flipkart> Flipcart { get => flip; set => flip = value; }
       public List<Tcs> Tcs { get => tcs; set => tcs = value; }
    }
}
