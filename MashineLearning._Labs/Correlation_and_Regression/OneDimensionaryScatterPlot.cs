using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correlation_and_Regression
{
    class PointData
    {
        public readonly double y;
        public readonly double x;

        public static PointData operator -(PointData pd)
        {
            return new PointData(-pd.y, -pd.x);
        }

        public static PointData operator -(PointData pd1, PointData pd2)
        {
            return new PointData(pd1.y - pd2.y, pd1.x - pd2.x);
        }

        public static PointData operator +(PointData pd1, PointData pd2)
        {
            return new PointData(pd1.y + pd2.y, pd1.x + pd2.x);
        }

        public static PointData operator *(double a, PointData pd)
        {
            return new PointData(a * pd.y, a * pd.x);
        }

        public static double Distance(PointData pd1, PointData pd2)
        {
            return Math.Sqrt(Math.Pow(pd2.y - pd1.y, 2) + Math.Pow(pd2.x - pd1.x, 2));
        }

        public PointData(double yvalue, double xvalue)
        {
            y = yvalue;
            x = xvalue;
        }
    }

    class LinearRegressionInfo
    {
        public Func<double, double> F { private set; get; }       
        public double LevelSignificance { private set; get; }
        public double A0 { private set; get; } 
        public double Dispersion_A0 { private set; get; } 
        public double Stat_A0 { private set; get; } 
        public bool Significance_A0 { private set; get; } 
        public double A0_bottom { private set; get; } 
        public double A0_top { private set; get; }    
        public double A1 { private set; get; } 
        public double Dispersion_A1 { private set; get; } 
        public double Stat_A1 { private set; get; } 
        public bool Significance_A1 { private set; get; } 
        public double A1_bottom { private set; get; } 
        public double A1_top { private set; get; }                                                                          
        public Func<double, double> F_bottom { private set; get; } 
        public Func<double, double> F_top { private set; get; } 
        public Func<double, double> Y_bottom { private set; get; } 
        public Func<double, double> Y_top { private set; get; }                                                                          
        public double DeterminitionCoefficient { private set; get; } 
        public double F_statistic { private set; get; } 
        public bool SignificanceRegression { private set; get; }

        public LinearRegressionInfo(double aljfa, double a0, double dev_a0, double stat_a0, bool significance_a0, double a0_bottom, double a0_top,
                                                  double a1, double dev_a1,  double stat_a1,  bool significance_a1,  double a1_bottom,  double a1_top,
                                                  Func<double, double> f_bottom,  Func<double, double> f_top,  Func<double, double> y_bottom,  Func<double, double> y_top,
                                                  double R_2,  double F_stat,  bool significanceRegression)
        {
            F = (x) => (a0 + a1 * x);
            LevelSignificance = aljfa;
            A0 = a0;
            Dispersion_A0 = dev_a0;
            Stat_A0 = stat_a0;
            Significance_A0 = significance_a0;
            A0_bottom = a0_bottom;
            A0_top = a0_top;
            A1 = a1;
            Dispersion_A1 = dev_a1;
            Stat_A1 = stat_a1;
            Significance_A1 = significance_a1;
            A1_bottom = a1_bottom;
            A1_top = a1_top;
            F_bottom = f_bottom;
            F_top = f_top;
            Y_bottom = y_bottom;
            Y_top = y_top;
            DeterminitionCoefficient = R_2;
            F_statistic = F_stat;
            SignificanceRegression = significanceRegression;
        }
    }

    enum CharacteristicsPolinomialCoefs { PointEstimation, Dispersion, Statistic, Significance, LowBound, HighBound }

    class PolinomialRegressionInfo
    {
        public Func<double, double> F { private set; get; }        
        public double LevelSignificance { private set; get; }
        
        public int Degree
        {
            get
            {
                return _a.Length - 1;
            }
        }
        private double[] _a; 
        private double[] _D_a;
        private double[] _stat_a;
        private bool[] _sign_a;
        private double[] _a_low;
        private double[] _a_high; 
        public double this[CharacteristicsPolinomialCoefs charact, int index]
        {
            get
            {
                if ((index < 0) || (index > this.Degree))
                    throw new ArgumentOutOfRangeException("index");

                switch (charact)
                {
                    case CharacteristicsPolinomialCoefs.PointEstimation:
                        return _a[index];
                    case CharacteristicsPolinomialCoefs.Dispersion:
                        return _D_a[index];
                    case CharacteristicsPolinomialCoefs.Statistic:
                        return _stat_a[index];
                    case CharacteristicsPolinomialCoefs.Significance:
                        return Convert.ToDouble(_sign_a[index]);
                    case CharacteristicsPolinomialCoefs.LowBound:
                        return _a_low[index];
                    case CharacteristicsPolinomialCoefs.HighBound:
                        return _a_high[index];
                    default:
                        throw new ArgumentOutOfRangeException("charact");
                }
            }
        } 
        
        public Func<double, double> F_bottom { private set; get; }
        public Func<double, double> F_top { private set; get; }
        public Func<double, double> Y_bottom { private set; get; }
        public Func<double, double> Y_top { private set; get; }
        public double DeterminitionCoefficient { private set; get; }
        public double F_statistic { private set; get; }
        public bool SignificanceRegression { private set; get; }

        public PolinomialRegressionInfo(double aljfa, double[] a, double[] D_a, double[] stat_a, bool[] sign_a, double[] a_low, double[] a_high, 
                                                          Func<double, double> f_bottom,  Func<double, double> f_top,  Func<double, double> y_bottom,  Func<double, double> y_top,
                                                          double R_2,  double F_stat,  bool significanceRegression)
        {
            if (a == null)
                throw new ArgumentNullException("a");
            if (D_a == null)
                throw new ArgumentNullException("D_a");
            if (stat_a == null)
                throw new ArgumentNullException("stat_a");
            if (sign_a == null)
                throw new ArgumentNullException("sign_a");
            if (a_low == null)
                throw new ArgumentNullException("a_low");
            if (a_high == null)
                throw new ArgumentNullException("a_high");

            if (a.Length < 1)
                throw new ArgumentException("a");
            if (a.Length != D_a.Length)
                throw new ArgumentException("D_a");
            if (a.Length != stat_a.Length)
                throw new ArgumentException("stat_a");
            if (a.Length != sign_a.Length)
                throw new ArgumentException("sign_a");
            if (a.Length != a_low.Length)
                throw new ArgumentException("a_low");
            if (a.Length != a_high.Length)
                throw new ArgumentException("a_high");
            
            _a = a;
            _D_a = D_a;
            _stat_a = stat_a;
            _sign_a = sign_a;
            _a_low = a_low;
            _a_high = a_high;            

            F = (x) =>
            {
                double result = _a[0],
                       x_p = 1;
                for (int i = 1, p = this.Degree; i <= p; i++)
                    result += _a[i] * (x_p *= x);
                return result;
            };
            LevelSignificance = aljfa;           
            F_bottom = f_bottom;
            F_top = f_top;
            Y_bottom = y_bottom;
            Y_top = y_top;
            DeterminitionCoefficient = R_2;
            F_statistic = F_stat;
            SignificanceRegression = significanceRegression;
        }
    }

    class OneDimensionaryScatterPlot
    {
        lab1_2.DataSet _y;
        lab1_2.DataSet _x;

        public PointData this[int index]
        {            
            get
            {
                return new PointData(_y[index], _x[index]);
            }       
        }

        public int Count
        {
            get
            {
                return _y.Size; //~ return _x.Size;
            }
        }

        public double PearsonCorrelationCoefficient(double aljfa, out double stat, out double quanOfStudent, out bool significance, out double r_bottom, out double r_top)
        {
            int N = this.Count;
            double xy_ = 0;
            for (int i = 0; i < N; i++)
                xy_ += _x[i] * _y[i];
            xy_ /= N;
            double r = (xy_ - _x.ArithmeticAverage * _y.ArithmeticAverage) / (((double)(N - 1) / N) * Math.Sqrt(_x.Deviation * _y.Deviation));

            if ((aljfa <= 0) || (aljfa >= 1))
                throw new ArgumentOutOfRangeException("aljfa");

            stat = r * Math.Sqrt(_x.Size - 2) / Math.Sqrt(1 - r * r);
            if (significance = Math.Abs(stat) > (quanOfStudent = (new LibraryOfQuantiles.QuantileOfTheDistributionOfStudent(1 - aljfa / 2, N - 2).Value)))
            {
                double c1 = r + r * (1 - r * r) / (2 * N), 
                       c2 = (new LibraryOfQuantiles.QuantileOfTheNormalDistribution(1 - aljfa / 2)).Value * (1 - r * r) / Math.Sqrt(N - 1);
                r_bottom = c1 - c2;
                r_top = c1 + c2;
            }
            else
            {
                r_bottom = double.NaN;
                r_top = double.NaN;
            }

            return r;
        }

        public double SpearmansRankCorrelationCoefficient(double aljfa, out double stat, out double quanOfStudent, out bool significance, out double tau_s_bottom, out double tau_s_top)
        {
            int N = this.Count;
            double[] sort_x = _x.CloneData();
            Dictionary<double, List<int>> index_x = new Dictionary<double, List<int>>();
            for (int i = 0; i < N; i++)
                if (index_x.ContainsKey(sort_x[i]))
                    index_x[sort_x[i]].Add(i);
                else
                {
                    index_x.Add(sort_x[i], new List<int>());
                    index_x[sort_x[i]].Add(i);
                }
            Array.Sort(sort_x);
            float[] rx = new float[N];
            double A = 0;
            for (int i = 0, old_i, j = 0, add; i < N; i++)
            {
                try
                {
                    while (sort_x[i] == sort_x[i + ++j]) ;
                }
                catch (IndexOutOfRangeException)
                {
                }
                finally
                {
                    old_i = i;
                    i += j - 1;
                    add = j - 1;
                    if (j > 1)
                        A += j * j * j - j;
                    while (--j > -1) rx[i - j] = 1 + old_i + add * 0.5f;
                    j++;
                }
            }
            A /= 12d;

            double[] sort_y = _y.CloneData();
            Dictionary<double, float> ry = new Dictionary<double, float>();            
            Array.Sort(sort_y);            
            double B = 0;
            for (int i = 0, old_i, j = 0, add; i < N; i++)
            {
                try
                {
                    while (sort_y[i] == sort_y[i + ++j]) ;
                }
                catch (IndexOutOfRangeException)
                {
                }
                finally
                {
                    old_i = i;
                    i += j - 1;
                    add = j - 1;
                    if (j > 1)
                        B += j * j * j - j;
                    ry.Add(sort_y[old_i], 1 + old_i + add * 0.5f);
                    j = 0;
                }
            }
            B /= 12d;

            double tau_s = 0;
            for (int i = 0; i < N; i++)
            {
                tau_s += Math.Pow(rx[i] - ry[_y[index_x[sort_x[i]][0]]], 2);
                index_x[sort_x[i]].RemoveAt(0);
            }

            if ((A == 0) && (B == 0))
                tau_s = 1d - 6d * tau_s / (N * (N * N - 1));
            else
            {
                double C = N * (N * N - 1) / 6d;
                tau_s = (C - tau_s - A - B) / Math.Sqrt((C - 2 * A) * (C - 2 * B)); 
            }

            if (significance = Math.Abs(stat = tau_s * Math.Sqrt(N - 2) / Math.Sqrt(1 - tau_s * tau_s)) > (quanOfStudent = new LibraryOfQuantiles.QuantileOfTheDistributionOfStudent(1 - aljfa / 2, N - 2).Value))
            {
                //?????????????????
                tau_s_bottom = tau_s - quanOfStudent * (1 - tau_s * tau_s) / Math.Sqrt(N);
                tau_s_top = tau_s + (tau_s - tau_s_bottom);
            }
            else
            {
                tau_s_bottom = double.NaN;
                tau_s_top = double.NaN;
                //?????????????????
            }
            return tau_s;
        }

        public double KendallsRankCorrelationCoefficient(double aljfa, out double stat, out double quanOfNormDistr, out bool significance, out double tau_k_bottom, out double tau_k_top)
        {
            int N = this.Count;
            double[] sort_x = _x.CloneData();
            Dictionary<double, List<int>> index_x = new Dictionary<double, List<int>>();
            for (int i = 0; i < N; i++)
                if (index_x.ContainsKey(sort_x[i]))
                    index_x[sort_x[i]].Add(i);
                else
                {
                    index_x.Add(sort_x[i], new List<int>());
                    index_x[sort_x[i]].Add(i);
                }
            Array.Sort(sort_x);
            float[,] r = new float[N, 2];
            double C = 0;
            for (int i = 0, old_i, j = 0, add; i < N; i++)
            {
                try
                {
                    while (sort_x[i] == sort_x[i + ++j]) ;
                }
                catch (IndexOutOfRangeException)
                {
                }
                finally
                {
                    old_i = i;
                    i += j - 1;
                    add = j - 1;
                    if (j > 1)
                        C += j * (j - 1);
                    while (--j > -1) r[i - j, 0] = 1 + old_i + add * 0.5f;
                    j++;
                }
            }
            C /= 2d;

            double[] sort_y = _y.CloneData();
            Dictionary<double, float> ry = new Dictionary<double, float>();
            Array.Sort(sort_y);
            double D = 0;
            for (int i = 0, old_i, j = 0, add; i < N; i++)
            {
                try
                {
                    while (sort_y[i] == sort_y[i + ++j]) ;
                }
                catch (IndexOutOfRangeException)
                {
                }
                finally
                {
                    old_i = i;
                    i += j - 1;
                    add = j - 1;
                    if (j > 1)
                        D += j * (j - 1);
                    ry.Add(sort_y[old_i], 1 + old_i + add * 0.5f);
                    j = 0;
                }
            }
            D /= 2d;
            
            for (int i = 0; i < N; i++)
            {
                r[i, 1] = ry[_y[index_x[sort_x[i]][0]]];
                index_x[sort_x[i]].RemoveAt(0);
            }

            double tau_k = 0;
            if (C == 0 && D == 0)
            {
                for (int i = 0, n = N - 1; i < n; i++)
                    for (int j = i + 1; j < N; j++)
                        tau_k += (r[i, 1] > r[j, 1]) ? -1 : 1;
                tau_k *= 2d;
                tau_k /= N * (N - 1); 
            }
            else
            {
                for (int i = 0, n = N - 1; i < n; i++)
                    for (int j = i + 1; j < N; j++)
                        tau_k += (r[i, 0] == r[j, 0]) ? 0 : (r[i, 1] < r[j, 1]) ? 1 : (r[i, 1] > r[j, 1]) ? -1 : 0;
               
                tau_k /= Math.Sqrt((N * (N - 1) / 2d - C) * (N * (N - 1) / 2d - D));
            }

            significance = Math.Abs(stat = tau_k * Math.Sqrt(9 * N * (N - 1)) / Math.Sqrt(2 * (2 * N + 5))) > (quanOfNormDistr = new LibraryOfQuantiles.QuantileOfTheNormalDistribution(1 - aljfa / 2).Value);
            //?????????????????
            tau_k_bottom = double.NaN;
            tau_k_top = double.NaN;
            //?????????????????            
            return tau_k;
        }

        public LinearRegressionInfo RestoreLinearRegression(double aljfa, out double quanOfStudent, out double quanOfFisher)
        {
            if ((aljfa <= 0) || (aljfa >= 1))
                throw new ArgumentOutOfRangeException("aljfa");
            int N = this.Count;
            Func<double, double> f;

            double xy_ = 0;
            for (int i = 0; i < N; i++)
                xy_ += _x[i] * _y[i];
            xy_ /= N;
            double a1 = (xy_ - _x.ArithmeticAverage * _y.ArithmeticAverage) / ((N - 1) * _x.Deviation / N);
            double a0 = (_y.ArithmeticAverage - a1 * _x.ArithmeticAverage);
            f = (x) => (a0 + a1 * x);

            double S2_residual = 0;
            for (int i = 0; i < N; i++)
                S2_residual += Math.Pow(_y[i] - f(_x[i]), 2);
            S2_residual /= N - 2;

            double dev_a0 = S2_residual * (1d / N + _x.ArithmeticAverage * _x.ArithmeticAverage / ((N - 1) * _x.Deviation));
            double dev_a1 = S2_residual / ((N - 1) * _x.Deviation);

            double a0_bottom, a0_top, stat_a0;
            bool significance_a0;
            if (significance_a0 = Math.Abs(stat_a0 = a0 / Math.Sqrt(dev_a0)) > (quanOfStudent = new LibraryOfQuantiles.QuantileOfTheDistributionOfStudent(1 - aljfa / 2, N - 2).Value))
            {
                a0_bottom = a0 - quanOfStudent * Math.Sqrt(dev_a0);
                a0_top = a0 + (a0 - a0_bottom)/* == quanOfStudent * Math.Sqrt(dev_a1)*/;
            }
            else            
                a0_top = a0_bottom = double.NaN;

            double a1_bottom, a1_top, stat_a1;
            bool significance_a1;
            if (significance_a1 = Math.Abs(stat_a1 = a1 / Math.Sqrt(dev_a1)) > quanOfStudent)
            {
                a1_bottom = a1 - quanOfStudent * Math.Sqrt(dev_a1);
                a1_top = a1 + (a1 - a1_bottom)/* == quanOfStudent * Math.Sqrt(dev_a1)*/;
            }
            else
                a1_top = a1_bottom = double.NaN;

            double value_quanOfStudent = quanOfStudent;
            Func<double, double> dev_f = (x) => (S2_residual / N + dev_a1 * Math.Pow(x - _x.ArithmeticAverage, 2));
            Func<double, double> f_bottom = (x) => (f(x) - value_quanOfStudent * Math.Sqrt(dev_f(x)));
            Func<double, double> f_top = (x) => (f(x) + value_quanOfStudent * Math.Sqrt(dev_f(x)));
            Func<double, double> y_bottom = (x) => (f(x) - value_quanOfStudent * Math.Sqrt(dev_f(x) + S2_residual));
            Func<double, double> y_top = (x) => (f(x) + value_quanOfStudent * Math.Sqrt(dev_f(x) + S2_residual));
            // or 
            /*y_bottom = (x) => (f(x) - value_quanOfStudent * Math.Sqrt(S2_residual));
            y_top = (x) => (f(x) + value_quanOfStudent * Math.Sqrt(S2_residual));*/

            double R_2 = 1 - (N - 2) * S2_residual / ((N - 1) * _y.Deviation),
                   F_stat;
            bool significanceRegression = (F_stat = R_2 * (N - 2) / (1 - R_2)) > (quanOfFisher = new LibraryOfQuantiles.QuantileOfTheDistributionOfFisher(1 - aljfa, 1, N - 2).Value);

            return new LinearRegressionInfo(aljfa, a0, dev_a0, stat_a0, significance_a0, a0_bottom, a0_top, a1, dev_a1, stat_a1, significance_a1, a1_bottom, a1_top, f_bottom, f_top, y_bottom, y_top, R_2, F_stat, significanceRegression);
        }

        public PolinomialRegressionInfo RestorePolinomialRegression(int p/*degree*/, double aljfa, out double quanOfStudent, out double quanOfFisher)
        {
            if (p >= (this.Count - 1))
                throw new ArgumentOutOfRangeException("p");
            if ((aljfa <= 0) || (aljfa >= 1))
                throw new ArgumentOutOfRangeException("aljfa");
            int N = this.Count;            
            Func<double, double> f;

            Lab2.Matrix2D A = Lab2.Matrix2D.CreateMatrix(p + 1, p + 1);            
            Lab2.Vector b = Lab2.Vector.CreateVector(p + 1);
            double[] x_p_y_ = new double[p];
            double[] x_p_ = new double[2 * p];
            double x_i_p;
            for (int i = 0; i < N; i++)
            {
                x_i_p = 1;
                for (int j = 0; j < p; j++)
                {
                    x_p_y_[j] += (x_i_p *= _x[i]) * _y[i];
                    x_p_[j] += x_i_p;
                }
                for (int j = p; j < x_p_.Length; j++)
                    x_p_[j] += (x_i_p *= _x[i]);                
            }
            b[0] = _y.ArithmeticAverage;
            A.SetElement(1, 0, 0);
            for (int j = 1; j <= p; j++)
            {
                b[j] = x_p_y_[j - 1] / N;
                x_p_[j - 1] /= N;
                for (int k = 0; k <= j; k++)
                    A.SetElement(x_p_[j - 1], k, j - k);
            }
            for (int j = p; j < x_p_.Length; j++)
            {
                x_p_[j] /= N;
                for (int k = j - p; k < p; k++)
                    A.SetElement(x_p_[j], k + 1, j - k);
            }

            Lab2.Vector a = Lab2.SystemOfLinearAlgebraicEquations.CreateSystem(A, b).GetSolution(Lab2.SystemOfLinearAlgebraicEquations.MethodsForSolution.Square_RootMethod); 
            
            f = (x) =>
            {
                double result = a[0],
                       x_p = 1;
                for (int i = 1; i <= p; i++)
                    result += a[i] * (x_p *= x);
                return result;
            };

            double S2_residual = 0;
            for (int i = 0; i < N; i++)
                S2_residual += Math.Pow(_y[i] - f(_x[i]), 2);
            S2_residual /= N - p - 1;

            double S2_detA = S2_residual / (A = N * A).ValueOfDeterminant;
            double[] D_a = new double[p + 1];
            for (int i = 0; i <= p; i++)            
                D_a[i] = S2_detA * A.AlgebraicalComplement(i, i);  
            
            //double[][] cov_a = null;
            //double[][] cov_a2 = null;
            //if (p > 0)
            //{
            //    cov_a = new double[p + 1][];
            //    cov_a2 = new double[p + 1][];
            //    for (int i = 0; i < p; i++)
            //        cov_a2[i] = new double[p - i];
            //    for (int i = 1; i <= p; i++)
            //    {
            //        cov_a[i] = new double[i];
            //        for (int j = 0; j < i; j++)
            //        {
            //            cov_a[i][j] = S2_detA * A.AlgebraicalComplement(j, i);
            //            cov_a2[j][i - j - 1] = S2_detA * A.AlgebraicalComplement(i, j);
            //        }
            //    }                
            //}

            double[,] cov_a = new double[p + 1, p + 1];
            for (int i = 0; i <= p; i++)
                for (int j = 0; j <= p; j++)
                    cov_a[i, j] = S2_detA * A.AlgebraicalComplement(j, i);

            double[] a_bottom = new double[p + 1], 
                     a_top = new double[p + 1], 
                     stat_a = new double[p + 1];
            bool[] significance_a = new bool[p + 1];
            quanOfStudent = new LibraryOfQuantiles.QuantileOfTheDistributionOfStudent(1 - aljfa / 2, N - p - 1).Value;
            for (int i = 0; i <= p; i++)
                if (significance_a[i] = Math.Abs(stat_a[i] = a[i] / Math.Sqrt(D_a[i])) > quanOfStudent)
                {
                    a_bottom[i] = a[i] - quanOfStudent * Math.Sqrt(D_a[i]);
                    a_top[i] = a[i] + (a[i] - a_bottom[i])/* == quanOfStudent * Math.Sqrt(D_a[i])*/;
                }
                else
                    a_top[i] = a_bottom[i] = double.NaN;
           
            //???????????????
            Func<double, double> dev_f = (x) => 
            {
                //double res = D_a[0],
                //       x_pow = 1;
                //for (int pow = 1; pow < p; pow++)
                //{
                //    x_pow *= x;
                //    for (int i = pow, j = 0; j < i; i--, j++)
                //        res += 2 * cov_a[i][j] * x_pow;
                //    pow++;
                //    x_pow *= x;
                //    for (int i = pow, j = 0; j < i; i--, j++)
                //        res += 2 * cov_a[i][j] * x_pow;
                //    res += D_a[pow / 2] * x_pow;
                //}
                //for (int pow = p, maxpow = 2 * p + 1; pow < maxpow; pow++)
                //{
                //    x_pow *= x;
                //    for (int i = p, j = pow - p; j < i; i--, j++)
                //        res += 2 * cov_a[i][j] * x_pow;
                //    pow++;
                //    x_pow *= x;
                //    for (int i = p, j = pow - p; j < i; i--, j++)
                //        res += 2 * cov_a[i][j] * x_pow;
                //    res += D_a[pow / 2] * x_pow;
                //}

                //double res = D_a[0];
                //for (int i = 1; i <= p; i++)
                //{
                //    for (int j = 0; j < i; j++)
                //        res += (cov_a2[j][i - j - 1] + cov_a[i][j]) * Math.Pow(x, i + j);
                //    res += D_a[i] * Math.Pow(x, i + i);
                //}

                double res = 0;
                for (int i = 0; i <= p; i++)
                    for (int j = 0; j <= p; j++)
                        res += cov_a[i, j] * Math.Pow(x, i + j); 
                return res;
            };
            //???????????????
            double value_quanOfStudent = quanOfStudent;
            Func<double, double> f_bottom = (x) => (f(x) - value_quanOfStudent * Math.Sqrt(dev_f(x)));
            Func<double, double> f_top = (x) => (f(x) + value_quanOfStudent * Math.Sqrt(dev_f(x)));
            Func<double, double> y_bottom = (x) => (f(x) - value_quanOfStudent * Math.Sqrt(dev_f(x) + S2_residual));
            Func<double, double> y_top = (x) => (f(x) + value_quanOfStudent * Math.Sqrt(dev_f(x) + S2_residual));
            // or 
            /*y_bottom = (x) => (f(x) - value_quanOfStudent * Math.Sqrt(S2_residual));
            y_top = (x) => (f(x) + value_quanOfStudent * Math.Sqrt(S2_residual));*/

            double R_2 = 1 - (N - p - 1) * S2_residual / ((N - 1) * _y.Deviation),
                   F_stat;
            bool significanceRegression = (F_stat = R_2 * (N - p - 1) / (p * (1 - R_2))) > (quanOfFisher = new LibraryOfQuantiles.QuantileOfTheDistributionOfFisher(1 - aljfa, p, N - p - 1).Value);

            return new PolinomialRegressionInfo(aljfa, a.ToArray(), D_a, stat_a, significance_a, a_bottom, a_top, f_bottom, f_top, y_bottom, y_top, R_2, F_stat, significanceRegression);
        }

        public OneDimensionaryScatterPlot(double[] y, double[] x)
        {
            if (y == null || x == null)
                throw new ArgumentNullException();

            if ((y.Length == 0) || (x.Length == 0) || (y.Length != x.Length))
                throw new ArgumentException();

            _y = new lab1_2.DataSet(y);
            _x = new lab1_2.DataSet(x);
        }
    }
}
