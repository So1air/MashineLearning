using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashineLearning.Clusterization
{
    //не готов
    class CompositeCluster: ClusterizationTreeImBinary
    {
        private ClusterizationTreeImBinary _leftCl;
        private ClusterizationTreeImBinary _rightCl;
        private int _dist;
        private int _size;

        public override ClusterizationTreeImBinary Left
        {
            get { return _leftCl; }
        }

        public override ClusterizationTreeImBinary Right
        {
            get { return _rightCl; }
        }

        public override List<ImBinary> GetObjects()
        {            
            List<ImBinary> res = new List<ImBinary>(_leftCl.GetObjects()); 
            res.AddRange(_rightCl.GetObjects());            
            return res;
        }        

        public override int Distance()
        {
            return _dist;
        }

        public override int Size
        {
            get { return _size; }
        }

        public CompositeCluster(ClusterizationTreeImBinary lt, ClusterizationTreeImBinary rt, int dist)
        {
            //_embracingCl = null;
            /*((CompositeCluster)(*/_leftCl = lt/*))._embracingCl = this*/;            
            /*((CompositeCluster)(*/_rightCl = rt/*))._embracingCl = this*/;
            _dist = dist;
            _size = _leftCl.Size + _rightCl.Size;
        }
    }
}
