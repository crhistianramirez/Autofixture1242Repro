using System;
using System.Collections.Generic;
using System.Text;

namespace Autofixture1242Repro
{
    public class MyOrder: Order<MyOrderXP>
    {
    }

    public class MyOrderXP
    {
        public string Color { get; set; }
    }
}
