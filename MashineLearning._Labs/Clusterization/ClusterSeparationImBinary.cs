using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashineLearning.Clusterization
{
    enum TypeOfInterclusterDistance {   SingleLinkage,   //Найближчий_сусід
                                        CompleteLinkage, //Найвіддаленіший_сусід
                                        AverageLinkage,  //Середня_зважена 
                                        AverageLinkageSimple, //Середня_незважена
                                        Median,          //Медіанна
                                        CentroidLinkage, //Між_центрами
                                        Ward             //Уорда 
                                    }

    class ClusterImBinary
    {
        public string Label { get; set; }
        private List<ImBinary> Objects;

        public ImBinary Object(int index)
        {
            if ((0 <= index) && (index < Objects.Count))
                return Objects[index];
            return null;
        }

        public int Size
        {
            get { return Objects.Count; }
        }

        public ImBinary GetCenter()
        {
            if ((Objects == null) || (Objects.Count == 0))
                return null;

            ImBinary center = new ImBinary(Objects[0].RowCount, Objects[0].ColumnCount);
            for (uint i = 0, p = (uint)Objects[0].Size, propSumm; i < p; i++)
            {
                propSumm = 0;
                foreach (ImBinary obj in Objects)
                    propSumm += obj.GetProp(i);
                if (2 * propSumm > Objects.Count)
                    center.SetProp(i, 1);
            }
            return center;
        }

        public bool UnionWith(ClusterImBinary otherCl)
        {
            if ((this.Objects[0].ColumnCount != otherCl.Objects[0].ColumnCount) || (this.Objects[0].RowCount != otherCl.Objects[0].RowCount))
                return false;
            this.Objects.Union<ImBinary>(otherCl.Objects);
            return true;
        }

        public bool AddObject(ImBinary new_object)
        {
            if /*(*/(new_object == null)/* || (this.Objects[0].ColumnCount != new_object.ColumnCount) || (this.Objects[0].RowCount != new_object.RowCount))*/
                return false;
            this.Objects.Add(new_object);
            return true;
        }

        public void Clear()
        {
            this.Objects.Clear();
        }

        public int DistanceTo(ClusterImBinary otherCl, TypeOfInterclusterDistance typeDist = TypeOfInterclusterDistance.CompleteLinkage)
        {
            if ((this.Objects == null) || (this.Objects.Count == 0) || (otherCl.Objects == null) || (otherCl.Objects.Count == 0))
                return -1;

            int res = -1;
            switch (typeDist)
            {
                case TypeOfInterclusterDistance.SingleLinkage:
                    res = this.Objects[0].DistanceTo(otherCl.Objects[0]);
                    for (int i = 0, N1 = this.Objects.Count, N2 = otherCl.Objects.Count, tmpDist; i < N1; i++)
                        for (int j = 0; j < N2; j++)
                        {
                            tmpDist = this.Objects[i].DistanceTo(otherCl.Objects[j]);
                            if (res > tmpDist)
                                res = tmpDist;
                        }
                    break;
                    //return res;

                case TypeOfInterclusterDistance.CompleteLinkage:
                    res = this.Objects[0].DistanceTo(otherCl.Objects[0]);
                    if (res == -1) 
                        return res;
                    
                    for (int i = 0, N1 = this.Objects.Count, N2 = otherCl.Objects.Count, tmpDist; i < N1; i++)
                        for (int j = 0; j < N2; j++)
                        {
                            tmpDist = this.Objects[i].DistanceTo(otherCl.Objects[j]);
                            if (res < tmpDist)
                                res = tmpDist;
                        }
                    break;    
                //return res;
                case TypeOfInterclusterDistance.AverageLinkage:
                    res = 0;
                    for (int i = 0, N1 = this.Objects.Count, N2 = otherCl.Objects.Count; i < N1; i++)
                        for (int j = 0; j < N2; j++)                        
                            res += this.Objects[i].DistanceTo(otherCl.Objects[j]);
                    res /= this.Objects.Count * otherCl.Objects.Count; 
                    break;

                case TypeOfInterclusterDistance.AverageLinkageSimple:
                    res = 0;                    
                    for (int i = 0, N1 = this.Objects.Count, N2 = otherCl.Objects.Count; i < N1; i++)
                        for (int j = 0; j < N2; j++)                        
                            res += this.Objects[i].DistanceTo(otherCl.Objects[j]);
                    res /= 4;
                    break;

                case TypeOfInterclusterDistance.Median:
                    res = this.GetCenter().DistanceTo(otherCl.GetCenter()) / 2;
                    break;

                case TypeOfInterclusterDistance.CentroidLinkage:
                    res = this.GetCenter().DistanceTo(otherCl.GetCenter());
                    break;

                case TypeOfInterclusterDistance.Ward:
                    res = (int)((this.Objects.Count * otherCl.Objects.Count / (double)(this.Objects.Count + otherCl.Objects.Count)) * Math.Pow(this.GetCenter().DistanceTo(otherCl.GetCenter()), 2));
                    break;
            }
            return res;
        }

        public override string ToString()
        {            
            return Label + "(" + this.Objects.Count + " el.)";
        }

        public ClusterImBinary()
            :this("Cluster")
        {            
        }

        public ClusterImBinary(string label)
        {
            Objects = new List<ImBinary>();
            this.Label = label;
        }

        public ClusterImBinary(ImBinary start_object)
            :this()
        {           
            if (start_object == null) 
                Objects.Add(start_object);
                //throw new ArgumentNullException("start_object", "Кластер не може бути пустим");
        }

        public ClusterImBinary(ImBinary start_object, string label)
            :this(start_object)
        {
            Label = label;
        }
    }

    class ClusterSeparationImBinary
    {
        public readonly ClusterImBinary[] separation;

        public double FunctionalQ2
        {
            get
            {
                Lab2.Matrix2D Eb = Lab2.Matrix2D.CreateMatrix(separation[0].Object(0).Size, separation[0].Object(0).Size);
                //Lab2.Vector[][] images = new Lab2.Vector[separation.Length][];
                for (int l = 0, K = separation.Length, N = 0; l < K; l++)
                {
                    N += separation[0].Size;
                    for (int i = 0, Nl = separation[0].Size; i < Nl; i++)
                    {

                    }
                }
                throw new NotImplementedException();
            }
        }

        public ClusterSeparationImBinary()
        {
            separation = new ClusterImBinary[2];            
        }

        public ClusterSeparationImBinary(uint K)
        {
            separation = new ClusterImBinary[K];
        }
    }
}
