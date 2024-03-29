﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model.Interface
{
    public interface ITelnetClient
    {
        void Connect(string ip, int port);
        void Write(string command);
        void Disconnect();
    }
}