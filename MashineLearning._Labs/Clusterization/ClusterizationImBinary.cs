using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashineLearning.Clusterization
{
    struct RibOfGraph: IComparer<RibOfGraph> 
    {
        public readonly int V1, V2, Weight;

        public RibOfGraph(int v1, int v2, int weight)
        {
            V1 = v1;
            V2 = v2;
            Weight = weight;
        }

        public int Compare(RibOfGraph x, RibOfGraph y)
        {
            return (x.Weight > y.Weight) ? 1 : ((x.Weight == y.Weight) ? 0 : -1);
        }
    }

    static class ClusterizationImBinary
    {
        static Random accidenceFactor = new Random();
        public static DendrogramInfo HierarchicalAgglomerativeMethod(ImBinary[] objects, TypeOfInterclusterDistance tdist = TypeOfInterclusterDistance.CompleteLinkage) //отладить
        {
            List<ClusterizationTreeImBinary> buildList = new List<ClusterizationTreeImBinary>();  //список всех построенных кластеров, все листья ElementaryCluster и узлы, располженные в порядке возрастания расстояния, CompositeCluster
            List<Dictionary<int, int>> tableOfDistances = new List<Dictionary<int, int>>();
            List<int> indexisClustersInSection = new List<int>(); //индексы, связывающие таблицу расстояний и список кластеров
            int ind = 0;
            foreach (ImBinary obj in objects)
            {
                buildList.Add(new ElementaryCluster(obj));
                indexisClustersInSection.Add(ind++);
            }

            for (int i = 0, N = objects.Length - 1; i < N; i++)
            {
                tableOfDistances.Add(new Dictionary<int,int>());
                for (int j = i; j >= 0; j--)
                    tableOfDistances[i].Add(j, objects[i + 1].DistanceTo(objects[j]));
            }

            int minDist, tmpDist, l, h, m, i_m;
            int l_h = objects.Length - 1; //индекс последнего кластера
            double alfa_l = 0, alfa_h = 0, beta = 0, hamma = 0;
            #region Выбор значений альфа-эль, альфа-аш, бэта, гамма
            switch (tdist) 
            {
                case TypeOfInterclusterDistance.SingleLinkage:
                    alfa_l = 0.5;  alfa_h = 0.5; /*beta = 0;*/  hamma = -0.5;
                    break;
                case TypeOfInterclusterDistance.CompleteLinkage:
                    alfa_l = 0.5;  alfa_h = 0.5; /*beta = 0;*/  hamma = 0.5;
                    break;
                case TypeOfInterclusterDistance.AverageLinkage:
                    //hamma = 0;                    
                    break;
                case TypeOfInterclusterDistance.AverageLinkageSimple:
                    alfa_l = 0.5;  alfa_h = 0.5; //beta = 0;  //hamma = 0;
                    break;
                case TypeOfInterclusterDistance.Median:
                    alfa_l = 0.5;  alfa_h = 0.5; beta = -0.25;  //hamma = 0;
                    break;
                case TypeOfInterclusterDistance.CentroidLinkage:
                    //hamma = 0;                    
                    break;
                case TypeOfInterclusterDistance.Ward:
                    //hamma = 0;                   
                    break;
                default:                    
                    throw new NotImplementedException();
            }
            #endregion
            while (indexisClustersInSection.Count > 2)
            {
                #region Нахождение минимального расстояния и соответсвующих индексов кластеров
                minDist = tableOfDistances[(h = indexisClustersInSection[1]) - 1][l = indexisClustersInSection[0]];
                for (int i = 2, N = indexisClustersInSection.Count; i < N; i++)
                {
                    for (int j = i - 1; j >= 0; j--)
                        if (minDist > (tmpDist = tableOfDistances[indexisClustersInSection[i] - 1][indexisClustersInSection[j]])) 
                        {
                            minDist =  tmpDist; 
                            h = indexisClustersInSection[i]; 
                            l = indexisClustersInSection[j];
                        }
                }
                #endregion
                buildList.Add(new CompositeCluster(buildList[l], buildList[h], minDist));
                indexisClustersInSection.Remove(l);
                indexisClustersInSection.Remove(h);                
                tableOfDistances.Add(new Dictionary<int, int>());
                l_h++;  //индекс нового кластера
                #region Пересчёт расстояний к новому кластеру
                switch (tdist)
                {
                    case TypeOfInterclusterDistance.AverageLinkage:
                        alfa_l = buildList[l].Size / (double)buildList[l_h].Size;
                        alfa_h = buildList[h].Size / (double)buildList[l_h].Size;
                        //beta = 0;
                        break;
                    case TypeOfInterclusterDistance.CentroidLinkage:
                        alfa_l = buildList[l].Size / (double)buildList[l_h].Size;
                        alfa_h = buildList[h].Size / (double)buildList[l_h].Size;
                        beta = -alfa_l * alfa_h;
                        break;
                    case TypeOfInterclusterDistance.Ward:                        
                        break;
                    default:                        
                        break;
                }
                i_m = 0;
                //m = indexisClustersInSection[0];
                if (tdist == TypeOfInterclusterDistance.Ward)
                {                    
                    while((i_m < indexisClustersInSection.Count) && ((m = indexisClustersInSection[i_m]) < l))
                    {
                        alfa_l = (double)(buildList[m].Size + buildList[l_h].Size);
                        alfa_h = (buildList[m].Size + buildList[h].Size) / alfa_l;
                        beta = -buildList[m].Size / alfa_l;
                        alfa_l = (buildList[m].Size + buildList[l].Size) / alfa_l;
                        tableOfDistances[l_h - 1].Add(m, (int)Math.Round(alfa_l * tableOfDistances[l - 1][m] + alfa_h * tableOfDistances[h - 1][m] + beta * minDist /*tableOfDistances[h - 1][l]*/ + hamma * Math.Abs(tableOfDistances[l - 1][m] - tableOfDistances[h - 1][m])));
                        i_m++;                        
                    }                    
                    while ((i_m < indexisClustersInSection.Count) && ((m = indexisClustersInSection[i_m]) < h))
                    {
                        alfa_l = (double)(buildList[m].Size + buildList[l_h].Size);
                        alfa_h = (buildList[m].Size + buildList[h].Size) / alfa_l;
                        beta = -buildList[m].Size / alfa_l;
                        alfa_l = (buildList[m].Size + buildList[l].Size) / alfa_l;
                        tableOfDistances[l_h - 1].Add(m, (int)Math.Round(alfa_l * tableOfDistances[m - 1][l] + alfa_h * tableOfDistances[h - 1][m] + beta * minDist /*tableOfDistances[h - 1][l]*/ + hamma * Math.Abs(tableOfDistances[m - 1][l] - tableOfDistances[h - 1][m])));
                        i_m++;
                    }
                    while (i_m < indexisClustersInSection.Count)                        
                    {
                        m = indexisClustersInSection[i_m];
                        alfa_l = (double)(buildList[m].Size + buildList[l_h].Size);
                        alfa_h = (buildList[m].Size + buildList[h].Size) / alfa_l;
                        beta = -buildList[m].Size / alfa_l;
                        alfa_l = (buildList[m].Size + buildList[l].Size) / alfa_l;
                        tableOfDistances[l_h - 1].Add(m, (int)Math.Round(alfa_l * tableOfDistances[m - 1][l] + alfa_h * tableOfDistances[m - 1][h] + beta * minDist /*tableOfDistances[h - 1][l]*/ + hamma * Math.Abs(tableOfDistances[m - 1][l] - tableOfDistances[m - 1][h])));
                        i_m++;
                    }
                }
                else
                {
                    while ((i_m < indexisClustersInSection.Count) && ((m = indexisClustersInSection[i_m]) < l))
                    {                        
                        tableOfDistances[l_h - 1].Add(m, (int)Math.Round(alfa_l * tableOfDistances[l - 1][m] + alfa_h * tableOfDistances[h - 1][m] + beta * minDist /*tableOfDistances[h - 1][l]*/ + hamma * Math.Abs(tableOfDistances[l - 1][m] - tableOfDistances[h - 1][m])));
                        i_m++;
                    }
                    while ((i_m < indexisClustersInSection.Count) && ((m = indexisClustersInSection[i_m]) < h))
                    {
                        tableOfDistances[l_h - 1].Add(m, (int)Math.Round(alfa_l * tableOfDistances[m - 1][l] + alfa_h * tableOfDistances[h - 1][m] + beta * minDist /*tableOfDistances[h - 1][l]*/ + hamma * Math.Abs(tableOfDistances[m - 1][l] - tableOfDistances[h - 1][m])));
                        i_m++;
                    }
                    while (i_m < indexisClustersInSection.Count)
                    {
                        m = indexisClustersInSection[i_m];
                        tableOfDistances[l_h - 1].Add(m, (int)Math.Round(alfa_l * tableOfDistances[m - 1][l] + alfa_h * tableOfDistances[m - 1][h] + beta * minDist /*tableOfDistances[h - 1][l]*/ + hamma * Math.Abs(tableOfDistances[m - 1][l] - tableOfDistances[m - 1][h])));
                        i_m++;
                    }
                }
                #endregion
                indexisClustersInSection.Add(l_h);
            }
            if (indexisClustersInSection.Count == 2)
                buildList.Add(new CompositeCluster(buildList[indexisClustersInSection[0]], buildList[indexisClustersInSection[1]], tableOfDistances[indexisClustersInSection[1] - 1][indexisClustersInSection[0]]));

            return new DendrogramInfo(buildList);            
        }

        public static ClusterSeparationImBinary KmeansByLloyd(ImBinary[] objects, uint K) //улучшить
        {
            ImBinary[] centersClusters_old = new ImBinary[K],
                       centersClusters_curr = new ImBinary[K];
            SortedSet<int> index_centers = new SortedSet<int>();
            ClusterSeparationImBinary result = new ClusterSeparationImBinary(K);

            do
            {
                index_centers.Add(accidenceFactor.Next(objects.Length - 1));
            } while (index_centers.Count != K); //К центров будет тогда, когда получим К разных индексов

            for (int i = 0; i < K; i++)
            {
                centersClusters_old[i] = objects[index_centers.ElementAt<int>(i)]; //заполняем центры
                result.separation[i] = new ClusterImBinary("Cluster" + i);
            }

            bool stabilization;
            int countIteration = 0;
            int index_center_for_join, min_distance, tmp_distance;
            int min_diff = (int)(0.05 * objects[0].Size);
            
            do 
            {
                countIteration++;
                for (int i = 0, n = objects.Length; i < n; i++)
                {
                    index_center_for_join = 0;
                    min_distance = objects[i].DistanceTo(centersClusters_old[0]);                    
                    for(int h = 1; h < K; h++)
                        if ((tmp_distance = objects[i].DistanceTo(centersClusters_old[h])) < min_distance)
                        {
                            index_center_for_join = h;
                            min_distance = tmp_distance;
                        }
                    result.separation[index_center_for_join].AddObject(objects[i]);
                }
                stabilization = true;
                for (int h = 0; h < K; h++)
                    if (centersClusters_old[h].DistanceTo(centersClusters_curr[h] = result.separation[h].GetCenter()) > min_diff)
                        stabilization = false;
                 centersClusters_curr.CopyTo(centersClusters_old, 0);
            } 
            while (!stabilization && (countIteration < 50));

            return result;
        }

        public static ClusterSeparationImBinary KmeansByMacQueen(ImBinary[] objects, uint K) //улучшить
        {
            ImBinary[] centersClusters_old = new ImBinary[K],
                       centersClusters_curr = new ImBinary[K];
            SortedSet<int> index_centers = new SortedSet<int>();
            ClusterSeparationImBinary result = new ClusterSeparationImBinary(K);

            do
            {
                index_centers.Add(accidenceFactor.Next(objects.Length - 1));
            } while (index_centers.Count != K); //К центров будет тогда, когда получим К разных индексов

            for (int i = 0; i < K; i++)
            {
                centersClusters_curr[i] = centersClusters_old[i] = objects[index_centers.ElementAt<int>(i)]; //заполняем центры
                result.separation[i] = new ClusterImBinary("Cluster" + i);
            }

            bool stabilization;
            int countIteration = 0;
            int index_center_for_join, min_distance, tmp_distance;
            int min_diff = (int)(0.05 * objects[0].Size);
            do
            {
                countIteration++;
                for (int i = 0, n = objects.Length; i < n; i++)
                {
                    index_center_for_join = 0;
                    min_distance = objects[i].DistanceTo(centersClusters_curr[0]);
                    for (int h = 1; h < K; h++)
                        if ((tmp_distance = objects[i].DistanceTo(centersClusters_curr[h])) < min_distance)
                        {
                            index_center_for_join = h;
                            min_distance = tmp_distance;
                        }
                    result.separation[index_center_for_join].AddObject(objects[i]);
                    centersClusters_curr[index_center_for_join] = result.separation[index_center_for_join].GetCenter();
                }
                stabilization = true;
                for (int h = 0; h < K; h++)
                    if (centersClusters_old[h].DistanceTo(centersClusters_curr[h]) > min_diff)
                        stabilization = false;
                centersClusters_curr.CopyTo(centersClusters_old, 0);
            }
            while (!stabilization && (countIteration < 50));

            return result;
        }

        public static ClusterSeparationImBinary FOREL2(ImBinary[] objects, uint K)//содержит ошибку
        {
            ClusterSeparationImBinary result;

            int R = 0, tmpR;
            for (int i = 0, n = objects.Length; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if ((tmpR = objects[i].DistanceTo(objects[j])) > R)
                        R = tmpR;

            int dR = R;
            int min_diff = (int)(0.05 * objects[0].Size);
            List<ImBinary> tmpStoreObjects = new List<ImBinary>();
            ImBinary centerCluster, centerCluster_next;
            do
            {
                dR /= 2;
                if (tmpStoreObjects.Count == 0)
                    R -= dR;
                else
                    R += dR;
                tmpStoreObjects = new List<ImBinary>(objects);
                result = new ClusterSeparationImBinary(K);
                for (int i = 0; (i < K) && (tmpStoreObjects.Count > 0); i++)
                {
                    centerCluster_next = tmpStoreObjects[accidenceFactor.Next(tmpStoreObjects.Count - 1)];
                    result.separation[i] = new ClusterImBinary("Cluster " + i);
                    do
                    {
                        result.separation[i].Clear();
                        centerCluster = centerCluster_next;
                        for (int j = 0; j < tmpStoreObjects.Count; j++)
                            if (centerCluster.DistanceTo(tmpStoreObjects[j]) <= R)
                            {
                                result.separation[i].AddObject(tmpStoreObjects[j]);
                                tmpStoreObjects.RemoveAt(j);
                                j--;
                            }
                        centerCluster_next = result.separation[i].GetCenter();            //почему-то возникает пустой кластер. Как???
                    }
                    while (centerCluster.DistanceTo(centerCluster_next) != 0);
                }
            }
            while ((dR > min_diff) && (tmpStoreObjects.Count != 0) && (result.separation[K - 1] == null));

            return result;
        }

        public static ClusterSeparationImBinary KRAB(ImBinary[] objects, uint K) //доделать
        {
            int index1MinTmpDist = 0, index2MinTmpDist = 0;
            int[][] distance = new int[objects.Length - 1][];
            List<int> vertexesInGraph = new List<int>(), 
                      vertexesOutGraph = new List<int>();
            for (int i = 1, n = objects.Length; i < n; i++)
            {
                distance[i] = new int[i];
                for (int j = 0; j < i; j++)
                {
                    distance[i - 1][j] = objects[i].DistanceTo(objects[j]);
                    if (distance[i - 1][j] < distance[index1MinTmpDist][index2MinTmpDist])
                    {
                        index1MinTmpDist = i - 1;
                        index2MinTmpDist = j;
                    }
                }
                vertexesOutGraph.Add(i - 1);
            }
            #region Алгоритм Прима
            vertexesOutGraph.Remove(index1MinTmpDist);
            vertexesOutGraph.Remove(index2MinTmpDist);
            vertexesInGraph.Add(index1MinTmpDist);
            vertexesInGraph.Add(index2MinTmpDist);
            List<RibOfGraph> USP = new List<RibOfGraph>();  //Unclosed Shortest Path           
            USP.Add(new RibOfGraph(index1MinTmpDist, index2MinTmpDist, distance[index1MinTmpDist][index2MinTmpDist]));
            
            for (int r = 0, n = objects.Length - 2; r < n; r++)
            {                
                index1MinTmpDist = vertexesInGraph[0];
                index2MinTmpDist = vertexesOutGraph[1];
                foreach (int i in vertexesInGraph)
                    foreach (int o in vertexesOutGraph)
                        if (distance[i][o] < distance[index1MinTmpDist][index2MinTmpDist])
                        {
                            index1MinTmpDist = i;
                            index2MinTmpDist = o;
                        }
                vertexesOutGraph.Remove(index2MinTmpDist);
                vertexesInGraph.Add(index2MinTmpDist);   
                USP.Add(new RibOfGraph(index1MinTmpDist, index2MinTmpDist, distance[index1MinTmpDist][index2MinTmpDist]));
            }
            #endregion

            List<RibOfGraph> tmpUSP = new List<RibOfGraph>(USP);

            throw new NotImplementedException();
        }
    }
}
