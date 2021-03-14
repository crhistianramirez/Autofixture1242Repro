using System;
using System.Collections.Generic;
using System.Text;
using OrderCloud.SDK;

namespace Autofixture1242Repro
{

    public class MyOrder : Order<MyOrderXP, User, Address>
    {
        
    }

    public class MyOrderXP
    {
        public string Color { get; set; }
    }

}
