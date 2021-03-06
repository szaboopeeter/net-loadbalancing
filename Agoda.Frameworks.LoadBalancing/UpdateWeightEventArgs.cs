﻿using System;
using System.Collections.Generic;

namespace Agoda.Frameworks.LoadBalancing
{
    public sealed class UpdateWeightEventArgs : EventArgs
    {
        public UpdateWeightEventArgs(IEnumerable<WeightItem> weightItems)
        {
            WeightItems = weightItems;
        }

        public IEnumerable<WeightItem> WeightItems { get; }
    }
}
