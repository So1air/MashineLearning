using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashineLearning.Clusterization
{
    class DendrogramInfo
    {
        private List<ClusterizationTreeImBinary> _buildList;

        public ClusterizationTreeImBinary Root
        {
            get
            {
                return _buildList[_buildList.Count - 1];
            }
        }

        public ClusterizationTreeImBinary Cluster(int index)
        {
            return ((0 <= index) && (index < _buildList.Count)) ? _buildList[index] : null;
        }

        public DendrogramInfo(List<ClusterizationTreeImBinary> build)
        {
            _buildList = new List<ClusterizationTreeImBinary>(build);
        }
    }
}
