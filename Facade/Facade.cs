﻿using Facade.SubSystem1;
using Facade.SubSystem2;
using Facade.SubSystem3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        public void DoSomething()
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            Class3 c3 = new Class3();

            c1.Action1();
            c2.Action2();
            c3.Action3();
        }
    }
}
