﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebex.Net;

namespace InternetTime.Data
{
    static class NtpConnector
    {
        static NtpConnector()
        {
            Ntp connectedNtp = new Ntp(ServerChooser.FinalServerAddress);
        }
    }
}