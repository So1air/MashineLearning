using System;
using System.Collections.Generic;

namespace MashineLearning.Clusterization
{
    abstract class ClusterizationTreeImBinary
    {
        //protected ClusterizationTreeImBinary _embracingCl;

        public abstract int Distance();
        public abstract List<ImBinary> GetObjects();
        /*public ClusterizationTreeImBinary Up
        {
            get { return _embracingCl; }
            protected set { _embracingCl = value; }
        }*/
        public abstract ClusterizationTreeImBinary Left { get; }
        public abstract ClusterizationTreeImBinary Right { get; }
        public abstract int Size { get; }
    }
}
