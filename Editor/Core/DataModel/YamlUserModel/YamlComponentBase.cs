﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YamlUserModel
{
    public abstract class YamlComponentBase : YamlObjBase
    {
        public InFileHold m_GameObject { get; set; }
    }
}
