﻿using System;
using System.Collections.Generic;

namespace CA.Domain.Custom
{
    public class MetaData<T>
    {
        public Pagination Paging { get; set; }
        public IEnumerable<T> DataSet { get; set; }
        public NavLinks Links { get; set; }
    }
}
