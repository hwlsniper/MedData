﻿using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Message.Twd
{
    public class TwdUpdatedMessage
    {
        public List<YdhlTwd> Twds { get; set; }
    }
}