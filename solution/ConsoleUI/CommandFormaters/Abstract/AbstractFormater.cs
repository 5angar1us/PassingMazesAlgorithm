﻿using PassingMazesAlgorithm.Core.Graph.Model;
using System.Collections.Generic;
using System.Text;

namespace PassingMazesAlgorithm.Core
{
    public abstract class AbstractFormater<TEdge>
        where TEdge : DataEdge
    {
        protected Dictionary<ENeighborSide, string> _pairs = new Dictionary<ENeighborSide, string>();

        protected AbstractFormater()
        {
            _pairs.Add(ENeighborSide.Left, "L");
            _pairs.Add(ENeighborSide.Top, "U");
            _pairs.Add(ENeighborSide.Right, "R");
            _pairs.Add(ENeighborSide.Bottom, "D");
        }

        public virtual void Format(StringBuilder sb, TEdge edge)
        {
        }

    }
}
