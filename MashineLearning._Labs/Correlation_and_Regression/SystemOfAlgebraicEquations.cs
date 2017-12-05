using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SystemOfLinearAlgebraicEquations
    {        
        public enum MethodsForSolution { MethodOfGaussianElimination, Square_RootMethod, ThreediagonalMatrixAlgorithm, MethodOfSuccessiveIteration, SeidelMethod }

        private Matrix2D _a;
        private Vector _f;
        private static double _epsInSolution = 0.00001;        

        public Matrix2D A
        {
            get { return _a; }
        }

        public Vector F
        {
            get { return _f; }
        }
        
        public static double EpsInSolution
        {
            get 
            { 
                return _epsInSolution; 
            }

            set 
            {
                if (value > 0)
                    _epsInSolution = value; 
            }
        }

        private Vector MethodOfGaussianElimination() //только для квадратных матриц
        {
            Vector x;
            Matrix2D a = _a.Copy();
            Vector f = _f.Copy();

            short[] permutation = new short[_a.ColCount];
            for (short ord_num = 0; ord_num < permutation.Length; permutation[ord_num] = ord_num++)
                ;

            int n = _a.RowCount;
            {

                int ind_swapCol;
                short tmp;
                double pivot_elem/*ведущий элемент*/, nullable_elem/*обнуляемый элемент*/;
                for (int i = 0; i < n; i++)
                {
                    if (a.GetElement(i, i) == 0)
                    {
                        ind_swapCol = i;
                        while (a.GetElement(i, ++ind_swapCol) == 0) ;
                        a.SwapLocationColumns(i, ind_swapCol);
                        tmp = permutation[i];
                        permutation[i] = permutation[ind_swapCol];
                        permutation[ind_swapCol] = tmp;
                    }
                    pivot_elem = a.GetElement(i, i);
                    a.SetElement(1, i, i);
                    for (int k = i + 1; k < n; k++)
                        a.SetElement(a.GetElement(i, k) / pivot_elem, i, k);
                    f[i] /= pivot_elem;
                    for (int j = i + 1; j < n; j++)
                    {
                        nullable_elem = a.GetElement(j, i);
                        a.SetElement(0, j, i);
                        for (int k = i + 1; k < n; k++)
                            a.SetElement(a.GetElement(j, k) - a.GetElement(i, k) * nullable_elem, j, k);
                        f[j] -= f[i] * nullable_elem;
                    }
                }
            }
            {
                double[] x_perm = new double[n];
                double tmp_summ;
                for (int i = n - 1; i >= 0; i--)
                {
                    tmp_summ = 0;
                    for (int j = n - 1; j > i; j--)
                        tmp_summ += a.GetElement(i, j) * x_perm[j];
                    x_perm[i] = f[i] - tmp_summ;
                }

                x = Vector.CreateVector(n);
                for (int i = 0; i < permutation.Length; i++)
                    x[i] = x_perm[permutation[i]];
            }
            return x;
        }

        private Vector Square_RootMethod()
        {
            int n = _a.ColCount;
            Matrix2D S = Matrix2D.CreateMatrix(n, n);

            double tmp_summ;
            for (int i = 0; i < n; i++)
            {   
                tmp_summ = 0;
                for(int j = 0; j < i; j++)
                    tmp_summ += S.GetElement(i, j) * S.GetElement(i, j);
                S.SetElement(Math.Sqrt(_a.GetElement(i, i) - tmp_summ), i, i);
                for (int k = i + 1; k < n; k++)
                {
                    tmp_summ = 0;
                    for (int j = 0; j < i; j++)
                        tmp_summ += S.GetElement(i, j) * S.GetElement(k, j);
                    S.SetElement((_a.GetElement(k, i) - tmp_summ) / S.GetElement(i, i), k, i);
                }
            }

            Vector y = Vector.CreateVector(n);
            for (int i = 0; i < n; i++)
            {
                tmp_summ = 0;
                for (int j = 0; j < i; j++)
                    tmp_summ += S.GetElement(i, j) * y[j];
                y[i] = (_f[i] - tmp_summ) / S.GetElement(i, i);
            }

            S.Transposition();

            Vector x = Vector.CreateVector(n);
            for (int i = n - 1; i >= 0; i--)
            {
                tmp_summ = 0;
                for (int j = n - 1; j > i; j--)
                    tmp_summ += S.GetElement(i, j) * x[j];
                x[i] = (y[i] - tmp_summ) / S.GetElement(i, i);
            }

            return x;
        }

        private Vector ThreediagonalMatrixAlgorithm()
        { 
            Vector result = Vector.CreateVector(_a.ColCount);

            int n = result.Length - 1;
            double[] e = new double[n],
                     m = new double[n];
            e[0] = _f[0] / _a.GetElement(0, 0);
            m[0] = _a.GetElement(0, 1) / _a.GetElement(0, 0);
           
            //Func<double> res_final = () => { return result[result.Length - 1] = (_f[n] - _a.GetElement(n, n - 1) * e[n - 1]) / (_a.GetElement(n, n) - _a.GetElement(n, n - 1) * m[n - 1]); };
            //Func<int, double> 
            //res = (i) => { return (result[i] = (i == n) ? 
            //                                   res_final() : 
            //                                   (e[i] = (_f[i] - _a.GetElement(i, i - 1) * e[i - 1]) / (_a.GetElement(i, i) - _a.GetElement(i, i - 1) * m[i - 1])) - (m[i] = _a.GetElement(i - 1, i) / (_a.GetElement(i, i) - _a.GetElement(i, i - 1) * m[i - 1])) * res(i + 1)); };
            result[0] = e[0] - m[0] * res(1, n, ref result, ref e, ref m);

            return result;
        }

        double res_final(int n, ref Vector result, ref double[] e, ref double[] m)
        { 
            return result[n] = (_f[n] - _a.GetElement(n, n - 1) * e[n - 1]) / (_a.GetElement(n, n) - _a.GetElement(n, n - 1) * m[n - 1]); 
        }

        double res(int i, int n, ref Vector result, ref double[] e, ref double[] m) 
        {            
            return (result[i] = (i == n) ?
                                res_final(n, ref result, ref e, ref m) :
                                (e[i] = (_f[i] - _a.GetElement(i, i - 1) * e[i - 1]) / (_a.GetElement(i, i) - _a.GetElement(i, i - 1) * m[i - 1])) 
                                - (m[i] = _a.GetElement(i, i + 1) / (_a.GetElement(i, i) - _a.GetElement(i, i - 1) * m[i - 1])) * res(i + 1, n, ref result, ref e, ref m));
        }    

        private Vector MethodOfSuccessiveIteration()
        {
            if (this._a.IsQuadratic)
                if (this._a.ValueOfDeterminant != 0)
                {
                    Vector x;

                    int n = this._f.Length;
                    Vector g = this._f.Copy();
                    Matrix2D B = this._a.Copy();
                    {
                        int ind_swapRow;
                        double tmp;
                        double pivot_elem/*ведущий элемент*/;
                        for (int i = 0; i < n; i++)
                        {
                            if (B.GetElement(i, i) == 0)
                            {
                                ind_swapRow = i;
                                while (B.GetElement(++ind_swapRow, i) == 0) ;
                                B.SwapLocationRows(i, ind_swapRow);
                                tmp = g[i];
                                g[i] = g[ind_swapRow];
                                g[ind_swapRow] = tmp;
                            }
                            pivot_elem = B.GetElement(i, i);
                            B.SetElement(0, i, i);
                            for (int k = 0; k < n; k++)
                                if (k != i)
                                    B.SetElement(-(B.GetElement(i, k) / pivot_elem), i, k);
                            g[i] /= pivot_elem;
                        }
                    }

                    bool ok;
                    {
                        x = g;
                        //Vector x_before = Vector.CreateVector(x.Length);
                        double eps_iter = double.PositiveInfinity;
                        do
                        {
                            //x.CopyTo(x_before);
                            //x = B * x + g;
                        }
                        while ((ok = (eps_iter > (eps_iter = (x - (x = B * x + g)).Norm))) && (eps_iter > _epsInSolution));
                    }

                    if (ok)
                        return x;
                    else
                        return UnknownResult();              //задать вопрос: МОЖЕТ ЛИ БЫТЬ ТАК, ЧТО МЕТОД РАСХОДИТСЯ, НО СИСТЕМА ИМЕЕТ РЕШЕНИЕ?
                }
                else
                    return null;
            else
                return UnknownResult();
        }

        private Vector SeidelMethod()
        {
            if (this._a.IsQuadratic) 
                if (this._a.ValueOfDeterminant != 0)
                {
                    Vector x;

                    int n = this._f.Length;
                    Vector g = this._f.Copy();
                    Matrix2D B = this._a.Copy();
                    {
                        int ind_swapRow;
                        double tmp;
                        double pivot_elem/*ведущий элемент*/;
                        for (int i = 0; i < n; i++)
                        {
                            if (B.GetElement(i, i) == 0)
                            {
                                ind_swapRow = i;
                                while (B.GetElement(++ind_swapRow, i) == 0) ;
                                B.SwapLocationRows(i, ind_swapRow);
                                tmp = g[i];
                                g[i] = g[ind_swapRow];
                                g[ind_swapRow] = tmp;
                            }
                            pivot_elem = B.GetElement(i, i);
                            B.SetElement(0, i, i);
                            for (int k = 0; k < n; k++)
                                if (k != i)
                                    B.SetElement(-(B.GetElement(i, k) / pivot_elem), i, k);
                            g[i] /= pivot_elem;
                        }
                    }

                    bool ok;
                    {
                        x = Vector.CreateVector(n);
                        g.CopyTo(x);
                        Vector x_before = Vector.CreateVector(x.Length);
                        double eps_iter = double.PositiveInfinity;
                        do
                        {
                            x.CopyTo(x_before);
                            for (int i = 0; i < n; i++)
                            {
                                x[i] = 0;
                                for (int j = 0; j < i; j++)
                                    x[i] += B.GetElement(i, j) * x[j];
                                for (int j = i; j < n; j++)
                                    x[i] += B.GetElement(i, j) * x_before[j];
                                x[i] += g[i];
                            }
                        }
                        while ((ok = (eps_iter > (eps_iter = (x_before - x).Norm))) && (eps_iter > _epsInSolution));
                    }

                    if (ok)
                        return x;
                    else
                        return UnknownResult();              //задать вопрос: МОЖЕТ ЛИ БЫТЬ ТАК, ЧТО МЕТОД РАСХОДИТСЯ, НО СИСТЕМА ИМЕЕТ РЕШЕНИЕ?
                }
                else
                    return null;
            else
                return UnknownResult();
        }

        public Vector GetSolution()
        {
            if (_a.IsQuadratic)
                if (_a.ValueOfDeterminant != 0)
                {
                    if (_a.IsThreediagonal)
                        return this.ThreediagonalMatrixAlgorithm();

                    if (_a.IsSymetricMainDiag)
                        return this.Square_RootMethod();

                    return this.MethodOfGaussianElimination();
                }
                else
                    return null;
            else
                return UnknownResult();
        }

        private Vector UnknownResult()
        {
            double[] unknown_result = new double[_a.ColCount];
            for (int i = 0; i < unknown_result.Length; i++)
                unknown_result[i] = double.NaN;

            return Vector.CreateVector(unknown_result);
        }

        public Vector GetSolution(MethodsForSolution method)
        {             
            switch (method)
            {
                case MethodsForSolution.MethodOfGaussianElimination:
                    if (_a.IsQuadratic)
                        if (_a.ValueOfDeterminant != 0)
                            return this.MethodOfGaussianElimination();
                        else
                            return null;
                    else
                        return UnknownResult();

                case MethodsForSolution.Square_RootMethod:
                    if (_a.IsSymetricMainDiag)
                        if (_a.ValueOfDeterminant != 0)
                            return this.Square_RootMethod();
                        else
                            return null;
                    else
                        return UnknownResult();

                case MethodsForSolution.ThreediagonalMatrixAlgorithm:
                    if (_a.IsThreediagonal)
                        if (_a.ValueOfDeterminant != 0)
                            return this.ThreediagonalMatrixAlgorithm();
                        else
                            return null;
                    else
                        return UnknownResult();

                case MethodsForSolution.MethodOfSuccessiveIteration:
                    return this.MethodOfSuccessiveIteration();

                case MethodsForSolution.SeidelMethod:
                    return this.SeidelMethod();

                default:
                    throw new NotImplementedException();
            }
        }

        public SystemOfLinearAlgebraicEquations Copy()
        {
            return new SystemOfLinearAlgebraicEquations(this._a, this._f);
        }

        public static SystemOfLinearAlgebraicEquations CreateSystem(Matrix2D coefficientsOfTheSystem, Vector constantTerms)
        {
            if ((coefficientsOfTheSystem != null) && (constantTerms != null) && (coefficientsOfTheSystem.RowCount == constantTerms.Length))
                return new SystemOfLinearAlgebraicEquations(coefficientsOfTheSystem, constantTerms);
            else
                return null;
        }

        private SystemOfLinearAlgebraicEquations(Matrix2D coefficientsOfTheSystem, Vector constantTerms)
        {
            _a = coefficientsOfTheSystem.Copy();
            _f = constantTerms.Copy();
        }
    }
}
