﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLHelloServer
{
    public interface IHelloWorld
    {
        string SayHello();
        string ReturnResponse(string input);
    }
}
