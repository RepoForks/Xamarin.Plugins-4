﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.PdfRasterizer.Abstractions
{
    public interface IHash
    {
        string Create(string original);
    }
}
