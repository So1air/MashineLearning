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
            if (new_object == null)
                return false;
            if ((this.Objects.Count != 0) && ((this.Objects[0].ColumnCount != new_object.ColumnCount) || (this.Objects[0].RowCount != new_object.RowCount)))
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

        public ClusterImBinary(List<ImBinary> start_objects, string label)
            : this(label)
        {
            this.Objects.AddRange(start_objects);
        }
    }

    class ClusterSeparationImBinary
    {
        public readonly int HeightIm, WidthIm;
        public readonly ClusterImBinary[] Separation;

        public double FunctionalQShtrich2 //отладить //детермінант матриці внутрішньокластерних коваріацій -> min
        {
            get
            {
                int N = 0, Nl, p = HeightIm * WidthIm;
                Lab2.Matrix2D Sigma_B = Lab2.Matrix2D.CreateMatrix(p, p);
                Lab2.Matrix2D Sigma_l = Lab2.Matrix2D.CreateMatrix(p, p);
                Lab2.Matrix2D Sigma_l1 = Lab2.Matrix2D.CreateMatrix(p, 1);
                Lab2.Matrix2D Sigma_l2 = Lab2.Matrix2D.CreateMatrix(1, p);
                
                ImBinary centerCluster_l;                
                for (int l = 0, K = Separation.Length; l < K; l++)
                {
                    N += (Nl = Separation[l].Size);
                    centerCluster_l = Separation[l].GetCenter();
                    for (int i = 0; i < Nl; i++)
                    {
                        for (uint j = 0; j < p; j++)
                        {
                            Sigma_l1.SetElement(Separation[l].Object(i).GetProp(j) - centerCluster_l.GetProp(j), (int)j, 0);
                            Sigma_l2.SetElement(Separation[l].Object(i).GetProp(j) - centerCluster_l.GetProp(j), 0, (int)j);
                        }
                        Sigma_l += (Sigma_l1 * Sigma_l2); 
                    }
                    Sigma_l *= 1d / Nl;
                    Sigma_B += Sigma_l;
                }
                return (Sigma_B * (1d / N)).ValueOfDeterminant;
            }
        }

        public double FunctionalQ2 //отладить //cума внутрішньокластерних дисперсій -> min
        {
            get
            {
                int N = 0, Nl, p = HeightIm * WidthIm;
                Lab2.Matrix2D Sigma_B = Lab2.Matrix2D.CreateMatrix(p, p);
                Lab2.Matrix2D Sigma_l = Lab2.Matrix2D.CreateMatrix(p, p);
                Lab2.Matrix2D Sigma_l1 = Lab2.Matrix2D.CreateMatrix(p, 1);
                Lab2.Matrix2D Sigma_l2 = Lab2.Matrix2D.CreateMatrix(1, p);

                ImBinary centerCluster_l;
                for (int l = 0, K = Separation.Length; l < K; l++)
                {
                    N += (Nl = Separation[l].Size);
                    centerCluster_l = Separation[l].GetCenter();
                    for (int i = 0; i < Nl; i++)
                    {
                        for (uint j = 0; j < p; j++)
                        {
                            Sigma_l1.SetElement(Separation[l].Object(i).GetProp(j) - centerCluster_l.GetProp(j), (int)j, 0);
                            Sigma_l2.SetElement(Separation[l].Object(i).GetProp(j) - centerCluster_l.GetProp(j), 0, (int)j);
                        }
                        Sigma_l += (Sigma_l1 * Sigma_l2);
                    }
                    Sigma_l *= (1d / Nl);
                    Sigma_B += Sigma_l;
                    Sigma_l = Lab2.Matrix2D.CreateMatrix(p, p);
                }
                return (Sigma_B * (1d / N)).Trace;
            }
        }

        public double FunctionalQ3 //отладить //cума попарних внутрішньокластерних відстаней -> min
        {
            get
            {
                double result = 0;
                for (int l = 0; l < Separation.Length; l++)
                    for (int i = 0, Nl_1 = Separation[l].Size - 1; i < Nl_1; i++)
                        for (int q = i + 1; q <= Nl_1; q++) 
                            result += Separation[l].Object(i).DistanceTo(Separation[l].Object(q));
                return result;
            }
        }

        public double FunctionalQ4 //отладить //cума міжкластерних відстаней -> max
        {
            get
            {
                double result = 0;
                for (int l = 0, K_1 = Separation.Length - 1; l < K_1; l++)
                    for (int i = 0; i < Separation[l].Size; i++)
                        for (int h = l + 1; h <= K_1; h++)
                            for (int q = 0; q < Separation[h].Size; q++)
                                result += Separation[l].Object(i).DistanceTo(Separation[h].Object(q));
                return result;
            }
        }

        public double FunctionalQ5 //отладить //відношення функціоналів -> min
        {
            get
            {
                long SumMultiNlNl_1 = 0, MultiNl = 0;
                for (int l = 0; l < Separation.Length; l++)
                {
                    SumMultiNlNl_1 += Separation[l].Size * (Separation[l].Size - 1);
                    for (int h = l + 1; h < Separation.Length; h++)
                        MultiNl += Separation[l].Size * Separation[h].Size;
                }
                return 2 * FunctionalQ3 * MultiNl / (FunctionalQ4 * SumMultiNlNl_1);
            }
        }

        public double FunctionalForK_means //отладить 
        {
            get
            {
                double result = 0;
                ImBinary centerCluster_l;
                for (int l = 0; l < Separation.Length; l++)
                {
                    centerCluster_l = Separation[l].GetCenter();
                    for (int i = 0; i < Separation[l].Size; i++)
                        result += Math.Pow(Separation[l].Object(i).DistanceTo(centerCluster_l), 2);
                }
                return result;
            }
        }

        public ClusterSeparationImBinary(int heightIm, int widthIm, uint K = 2)
        {
            HeightIm = heightIm;
            WidthIm = widthIm;
            Separation = new ClusterImBinary[K];
        }
    }
}
