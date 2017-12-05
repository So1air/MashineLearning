using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    class DataSet
    {
        private const double a = -0.000347,
                             b = 0.312449,
                             c = 1.072398;

        private double[] _x;
        private double _arithmeticAverage,
                       _deviation,
                       _median,
                       _assymetry,
                       _excess;       

        public double this[int index]
        {
            get
            {
                return _x[index];
            }            
        }

        public double ArithmeticAverage
        {
            get
            {
                return _arithmeticAverage;
            }
        }

        public double Deviation
        {
            get
            {
                return _deviation;
            }
        }

        public double Median
        {
            get
            {
                return _median;
            }
        }

        public double Excess
        {
            get { return _excess; }
        }

        public double Assymetry
        {
            get { return _assymetry; }
        }

        public int Size
        {
            get
            {
                return _x.Length;
            }
        }

        public double[] CloneData()
        {
            double[] copy = new double[_x.Length];
            _x.CopyTo(copy, 0);
            return copy;
        }

        public double AutocovariationFunc(int tau, int K = 0) //не уверен
        {
            if ((tau < 0) || (K < 0) || (tau >= _x.Length - K) || (K >= _x.Length)) //?
                return double.NaN;
            
            double m1, m2;            
            return AutocovariationFunc(tau, out m1, out m2, K);
        }

        private double AutocovariationFunc(int tau, out double m1, out double m2, int K = 0) //не уверен
        {            
            if ((tau == 0) && (K == 0)) 
            {
                m1 = m2 = _arithmeticAverage;
                return _deviation * (_x.Length - 1) / _x.Length;
            }
            m1 = 0; 
            m2 = 0;
            if (tau == _x.Length - K)
                return 0;
            double cov = 0; 
            int n = _x.Length - tau;
            for (int i = K, i_tau = i + tau; i < n; i++, i_tau++)
            {
                m1 += _x[i];
                m2 += _x[i_tau];
            }
            m1 /= n - K;
            m2 /= n - K;
            for (int i = K, i_tau = i + tau; i < n; i++, i_tau++)
                cov += (_x[i] - m1) * (_x[i_tau] - m2);
            cov /= n - K;
            return cov;
        }

        public double AutocorrelationFunc(int tau, int K = 0) //не уверен
        {
            if ((tau < 0) || (K < 0) || (tau >= _x.Length - K) || (K > _x.Length - 1)) //?
                return double.NaN;
            
            double corr, m1, m2, D1 = 0, D2 = 0;
            double cov_tau = AutocovariationFunc(tau, out m1, out m2, K);
            int n = _x.Length - tau;
            for (int i = K, i_tau = i + tau; i < n; i++, i_tau++)
            {
                D1 += Math.Pow(_x[i] - m1, 2);
                D2 += Math.Pow(_x[i_tau] - m2, 2);
            }
            D1 /= n - 1 - K;
            D2 /= n - 1 - K;            
            corr = n * cov_tau / (Math.Sqrt(D1 * D2) * (n - 1));
            return corr;
        }

        public bool EditAnomalValues1(double aljfa)
        {
            double[] chV;
            return EditAnomalValues1(aljfa, 6, out chV);
        }

        public bool EditAnomalValues1(double aljfa, int k)
        {
            double[] chV;
            return EditAnomalValues1(aljfa, k, out chV);
        }

        public bool EditAnomalValues1(double aljfa, int k, out double[] changeValues/*содержит аномальные значения на их местах, прочие места double.NaN*/) //особенность: считает, что первые два элемента не являются аномальными
        {
            if ((k < 3) || (k > 9))
                throw new ArgumentOutOfRangeException();
            changeValues = new double[_x.Length];
            bool rem = false;
            double sum_x_i = _x[0] + _x[1],
                   av_x_i = sum_x_i / 2,
                   sum_dev_x_i = Math.Pow(_x[0] - av_x_i, 2) + Math.Pow(_x[1] - av_x_i, 2),
                   m_sq_x_i = Math.Sqrt(sum_dev_x_i);
            changeValues[0] = changeValues[1] = double.NaN;
            for (int i = 2; i < _x.Length; i++)
            {
                if ((_x[i] < av_x_i - k * m_sq_x_i) || (av_x_i + k * m_sq_x_i < _x[i]))
                {
                    changeValues[i] = _x[i];
                    _x[i] = 2 * (_x[i - 1] - _x[i - 2]) + _x[i - 2];
                    rem = true;
                }
                else
                    changeValues[i] = double.NaN;
                av_x_i = (sum_x_i += _x[i]) / (i + 1);
                m_sq_x_i = Math.Sqrt((sum_dev_x_i += Math.Pow(_x[i] - av_x_i, 2)) / i);
            }
            _arithmeticAverage = av_x_i;
            _deviation = sum_dev_x_i / (_x.Length - 1);
            ReCalcMedian();
            ReCalcAssymetry();
            ReCalcExcess();
            return rem;
        }

        public bool EditAnomalValues2()
        {
            double[] chV;
            return EditAnomalValues2(out chV);
        }

        public bool EditAnomalValues2(out double[] changeValues/*содержит аномальные значения на их местах, прочие места double.NaN*/) //особенность: считает не аномальными первый и последний элементы
        {
            changeValues = new double[_x.Length];
            bool rem = false;
            double a, b;
            if (_assymetry < -0.2)
            {
                a = _arithmeticAverage - Math.Sqrt((19 * Math.Sqrt(_excess + 2) + 1) * _deviation);
                b = _arithmeticAverage + (2 + 0.2 * Math.Log10(0.04 * _x.Length)) * Math.Sqrt(_deviation);
            }
            else
            {
                a = _arithmeticAverage - (2 + 0.2 * Math.Log10(0.04 * _x.Length)) * Math.Sqrt(_deviation);
                if (_assymetry > 0.2)
                    b = _arithmeticAverage + Math.Sqrt((19 * Math.Sqrt(_excess + 2) + 1) * _deviation);
                else
                    b = _arithmeticAverage + (_arithmeticAverage - a);                
            }
            changeValues[0] = double.NaN;
            for (int i = 1, n = _x.Length - 1; i < n; i++)
                if ((_x[i] <= a) || (_x[i] >= b))
                {
                    changeValues[i] = _x[i];
                    _x[i] = (_x[i - 1] + _x[i + 1]) / 2;
                    rem = true;
                }
                else
                    changeValues[i] = double.NaN;
            changeValues[_x.Length - 1] = double.NaN;
            ReCalcArAverage();
            ReCalcDeviation();
            ReCalcMedian();
            ReCalcAssymetry();
            ReCalcExcess();
            return rem;
        }

        public bool EditAnomalValues3(double aljfa)
        {
            double[] chV;
            return EditAnomalValues3(aljfa, out chV);
        }

        public bool EditAnomalValues3(double aljfa, out double[] changeValues/*содержит аномальные значения на их местах, прочие места double.NaN*/) //особенность: считает не аномальными первый и последний элементы
        {
            changeValues = new double[_x.Length];
            bool rem = false;
            double t, t_aljfa,
                   u = (new LibraryOfQuantiles.QuantileOfTheNormalDistribution(1 - aljfa / 2d)).Value,
                   m_sq = Math.Sqrt(_deviation);
            if ((aljfa == 0.05) && (_x.Length <= 50))
                t_aljfa = _x.Length / (a * _x.Length * _x.Length + b * _x.Length + c);
            else
                t_aljfa = u * Math.Sqrt(2 * (_x.Length - 1) / ((2 * _x.Length - 5 + u * u) + (3 + u * u + 2 * Math.Pow(u, 4)) / (6 * (2 *_x.Length - 5))));
            changeValues[0] = double.NaN;
            for (int i = 1, n = _x.Length - 1; i < n; i++)
                if (((t = (_x[i] - _arithmeticAverage) / m_sq) <= -t_aljfa) || (t >= t_aljfa))
                {
                    changeValues[i] = _x[i];
                    _x[i] = (_x[i - 1] + _x[i + 1]) / 2d;
                    rem = true;
                }
                else
                    changeValues[i] = double.NaN;
            changeValues[_x.Length - 1] = double.NaN;
            ReCalcArAverage();
            ReCalcDeviation();
            ReCalcMedian();
            ReCalcAssymetry();
            ReCalcExcess();
            return rem;
        }

        public DataSet(double[] data)
        {
            _x = new double[data.Length];
            data.CopyTo(_x, 0);

            ReCalcArAverage();
            ReCalcDeviation();
            ReCalcMedian();
            ReCalcAssymetry();
            ReCalcExcess();
        }

        private void ReCalcArAverage()
        {
            _arithmeticAverage = 0;
            for (int i = 0; i < _x.Length; i++)
                _arithmeticAverage += _x[i];
            _arithmeticAverage /= _x.Length;
        }

        private void ReCalcDeviation()
        {
            _deviation = 0;
            for (int i = 0; i < _x.Length; i++)
                _deviation += Math.Pow(_x[i] - _arithmeticAverage, 2);
            _deviation /= _x.Length - 1;
        }

        private void ReCalcMedian()
        {
            double[] sortx = new double[_x.Length];
            _x.CopyTo(sortx, 0);
            Array.Sort(sortx);
            _median = (sortx.Length % 2 == 0) ? (sortx[sortx.Length / 2 - 1] + sortx[sortx.Length / 2]) / 2 : sortx[sortx.Length / 2];
        }

        private void ReCalcAssymetry()
        {
            _assymetry = 0;
            for (int i = 0; i < _x.Length; i++)
                _assymetry += Math.Pow(_x[i] - _arithmeticAverage, 3);
            _assymetry *= Math.Sqrt(_x.Length * (_x.Length - 1));
            _assymetry /= _x.Length * Math.Pow(Math.Sqrt(_deviation), 3) * (_x.Length - 2);
        }
        
        private void ReCalcExcess()
        {
            _excess = 0;
            for (int i = 0; i < _x.Length; i++)
                _excess += Math.Pow(_x[i] - _arithmeticAverage, 4);
            _excess /= _x.Length * _deviation * _deviation;
            _excess = (_x.Length * _x.Length - 1) * ((_excess - 3) + 6d / (_x.Length + 1)) / ((_x.Length - 2) * (_x.Length - 3));
        }        
    }
}
