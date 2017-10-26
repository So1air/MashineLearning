using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashineLearning.Clusterization
{
    //не готов
    class ElementaryCluster: ClusterizationTreeImBinary
    {
        private ImBinary _im;

        public override List<ImBinary> GetObjects()
        {
            List<ImBinary> res = new List<ImBinary>(1);
            res.Add(_im);
            return res;
        }

        public override int Distance()
        {
            return 0;
        }

        public override ClusterizationTreeImBinary Left
        {
            get { return null; }
        }

        public override ClusterizationTreeImBinary Right
        {
            get { return null; }
        }

        public override int Size
        {
            get { return 1; }
        }

        public ElementaryCluster(ImBinary im)
        {
            _im = im;
        }
    }
}
