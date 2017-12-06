using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Matrix2D
    {
        public const int MAXCOUNTROWS = ushort.MaxValue,
                         MAXCOUNTCOLUMNS = ushort.MaxValue;

        private double[,] _matrixElements;

        public int RowCount
        {
            get
            {
                return _matrixElements.GetLength(0);
            }
        }

        public int ColCount
        {
            get
            {
                return _matrixElements.GetLength(1);
            }
        }

        public double GetElement(int indexRow, int indexCol)
        {
            if ((indexRow >= 0) && (indexRow < this.RowCount) && (indexCol >= 0) && (indexCol < this.ColCount))
                return _matrixElements[indexRow, indexCol];
            else
                return double.NaN;
        }

        public double[] GetRow(int index)
        {
            if ((index >= 0) && (index < this.RowCount))
            {
                double[] result = new double[this.ColCount];
                for (int j = 0; j < result.Length; j++)
                    result[j] = this._matrixElements[index, j];
                return result;
            }
            else
                return null;
        }

        public double[] GetColumn(int index)
        {
            if ((index >= 0) && (index < this.ColCount))
            {
                double[] result = new double[this.RowCount];
                for (int i = 0; i < result.Length; i++)
                    result[i] = this._matrixElements[i, index];
                return result;
            }
            else
                return null;
        }

        public bool SetElement(double newValue, int indexRow, int indexCol)
        {
            if ((indexRow >= 0) && (indexRow < this.RowCount) && (indexCol >= 0) && (indexCol < this.ColCount))
            {
                this._matrixElements[indexRow, indexCol] = newValue;
                return true;
            }
            else
                return false;
        }

        public bool SetRow(double[] newRow, int index)
        {
            if ((index >= 0) && (index < this.RowCount) && (newRow.Length == this.RowCount))
            {
                for (int j = 0; j < newRow.Length; j++)
                    this._matrixElements[index, j] = newRow[j];

                return true;
            }
            else
                return false;
        }

        public bool SetColumn(double[] newColumn, int index)
        {
            if ((index >= 0) && (index < this.ColCount) && (newColumn.Length == this.ColCount))
            {
                for (int i = 0; i < newColumn.Length; i++)
                    this._matrixElements[i, index] = newColumn[i];

                return true;
            }
            else
                return false;
        }

        public static Matrix2D operator -(Matrix2D m)
        {
            Matrix2D result = new Matrix2D(m._matrixElements);
            int r = result._matrixElements.GetLength(0),
                c = result._matrixElements.GetLength(1);
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    result._matrixElements[r, c] = -result._matrixElements[r, c];

            return result;
        }        

        public static Matrix2D operator *(double alfa, Matrix2D m)
        {          
            Matrix2D result = new Matrix2D((ushort)m.RowCount, (ushort)m.ColCount);
            for (int i = 0; i < result.RowCount; i++)
                for (int j = 0; j < result.ColCount; j++)
                    result._matrixElements[i, j] = m._matrixElements[i, j] * alfa;
            return result;
        }

        public static Matrix2D operator *(Matrix2D m, double alfa)
        {
            return alfa * m;
        }

        public static Matrix2D operator *(Matrix2D m, Vector v) //?
        {
            if (m.ColCount == v.Length) //?
            {
                Matrix2D result = new Matrix2D(m.RowCount, 1);
                for (int i = 0; i < result.RowCount; i++)
                    for (int k = 0; k < v.Length; k++)
                        result._matrixElements[i, 0] += m._matrixElements[i, k] * v[k];

                return result;
            }
            else
                return null;
        }

        public static Matrix2D operator *(Vector v, Matrix2D m) //?
        {
            if (v.Length == m.RowCount) //?
            {
                Matrix2D result = new Matrix2D(1, m.ColCount);
                for (int j = 0; j < result.ColCount; j++)
                    for (int k = 0; k < v.Length; k++)
                        result._matrixElements[0, j] += m._matrixElements[k, j] * v[k];

                return result;
            }
            else
                return null; 
        }

        public static Matrix2D operator *(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            if (leftMatrix.ColCount == rightMatrix.RowCount)
            {
                Matrix2D result = new Matrix2D(leftMatrix.RowCount, rightMatrix.ColCount);
                for (int i = 0; i < result.RowCount; i++)
                    for (int j = 0; j < result.ColCount; j++)
                        for (int k = 0; k < leftMatrix.ColCount; k++)
                            result._matrixElements[i, j] += leftMatrix._matrixElements[i, k] * rightMatrix._matrixElements[k, j];

                return result;
            }
            else
                return null; //лучше бросить специальное исключение  
        }

        public static Matrix2D operator +(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            if ((leftMatrix.RowCount == rightMatrix.RowCount) && (leftMatrix.ColCount == rightMatrix.ColCount))
            {
                Matrix2D result = new Matrix2D((ushort)leftMatrix.RowCount, (ushort)leftMatrix.ColCount);
                for (int i = 0; i < result.RowCount; i++)
                    for (int j = 0; j < result.ColCount; j++)
                        result._matrixElements[i, j] = leftMatrix._matrixElements[i, j] + rightMatrix._matrixElements[i, j];
                return result;
            }
            else
                return null; //лучше бросить специальное исключение  
        }

        public static Vector operator +(Matrix2D m, Vector v)  //довольно странная операция. ПРОКОНСУЛЬТИРОВАТЬСЯ!!!
        {
            if ((m.ColCount == 1) && (m.RowCount == v.Length))
            {
                Vector result = Vector.CreateVector(m.RowCount);
                for (int i = 0; i < result.Length; i++)
                    result[i] = m._matrixElements[i, 0] + v[i];

                return result;
            }
            else
                return null;
        }

        public static Vector operator +(Vector v, Matrix2D m)  //довольно странная операция. ПРОКОНСУЛЬТИРОВАТЬСЯ!!!
        {
            if ((m.RowCount == 1) && (m.ColCount == v.Length))
            {
                Vector result = Vector.CreateVector(m.ColCount);
                for (int i = 0; i < result.Length; i++)
                    result[i] = v[i] + m._matrixElements[0, i];

                return result;
            }
            else
                return null;
        }

        public static Matrix2D operator -(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            //return leftMatrix + (-rightMatrix);
            if ((leftMatrix.RowCount == rightMatrix.RowCount) && (leftMatrix.ColCount == rightMatrix.ColCount))
            {
                Matrix2D result = new Matrix2D((ushort)leftMatrix.RowCount, (ushort)leftMatrix.ColCount);
                for (int i = 0; i < result.RowCount; i++)
                    for (int j = 0; j < result.ColCount; j++)
                        result._matrixElements[i, j] = leftMatrix._matrixElements[i, j] - rightMatrix._matrixElements[i, j];
                return result;
            }
            else
                return null; //лучше бросить специальное исключение  
        }
        
        public static bool operator ==(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            if (object.ReferenceEquals(leftMatrix, null))
                if (object.ReferenceEquals(null, rightMatrix))
                    return true;
                else
                    return false;
            if (object.ReferenceEquals(null, rightMatrix))
                if (object.ReferenceEquals(leftMatrix, null))
                    return true;
                else
                    return false;
            else
                if ((leftMatrix.RowCount == rightMatrix.RowCount) && (leftMatrix.ColCount == rightMatrix.ColCount))
                {
                    for (int i = 0; i < leftMatrix.RowCount; i++)
                        for (int j = 0; j < leftMatrix.ColCount; j++)
                            if (leftMatrix._matrixElements[i, j] != rightMatrix._matrixElements[i, j])
                                return false;
                }
                else
                    return false; //лучше бросить специальное исключение    

            return true;
        }

        public static bool operator !=(Matrix2D leftMatrix, Matrix2D rightMatrix)
        {
            return !(leftMatrix == rightMatrix);
        }

        public bool IsQuadratic
        {
            get
            {
                return _matrixElements.GetLength(0) == _matrixElements.GetLength(1);
            }
        }

        public bool IsThreediagonal
        {
            get
            {
                if (this.IsQuadratic)
                {
                    int r_c_count = _matrixElements.GetLength(0);
                    for (int i_u = 0, i_l = r_c_count - 1; i_l > 1; i_u++, i_l--)
                        for (int j_r = 0, j_l = r_c_count - 1; j_l > 1 + i_u; j_r++, j_l--)
                            if ((_matrixElements[i_u, j_l] != 0) || (_matrixElements[i_l, j_r] != 0))
                                return false;
                    return true;
                }
                else
                    return false;
            }
        }

        public bool IsSymetricMainDiag
        {
            get
            {
                if (this.IsQuadratic)
                {
                    int r_c_count = _matrixElements.GetLength(0);
                    for (int i = 1; i < r_c_count; i++)
                        for (int r_u, c_l = r_u = 0, c_u, r_l = c_u = i; c_u < r_c_count; r_u++, c_u++, r_l++, c_l++)
                            if (_matrixElements[r_u, c_u] != _matrixElements[r_l, c_l])
                                return false;
                    return true;
                }
                else
                    return false;
            }
        }

        public bool IsNullMatrix
        {
            get
            {
                for (int i = 0; i < this.RowCount; i++)
                    for (int j = 0; j < this.ColCount; j++)
                        if (this._matrixElements[i, j] != 0)
                            return false;
                return true;
            }
        }
        public double AlgebraicalComplement(int row, int col)
        {
            if ((row >= 0) && (row < this.RowCount) && (col >= 0) && (col < this.ColCount))
                return (((row + col) % 2 == 1) ? -1 : 1) * CalcDeterminant(ExpurgationColumnAndRow(this._matrixElements, row, col));
            else
                return double.NaN;
        }

        public double ValueOfDeterminant
        {
            get
            {
                if (this.IsQuadratic)
                    return CalcDeterminant(this._matrixElements);
                else
                    return double.NaN;
            }
        }

        

        private double CalcDeterminant(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            if (n == 1)
                return matrix[0, 0];
            if (n == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
            else
            {
                double result = 0;
                int flag = -1;
                for (int i = 0; i < n; i++)
                {
                    flag = -flag;
                    result += flag * matrix[i, 0] * CalcDeterminant(ExpurgationColumnAndRow(matrix, i, 0));
                }
                return result;
            }
        }

        private double[,] ExpurgationColumnAndRow(double[,] matrix, int row, int col)
        {
            double[,] new_matrix = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            for (int i = 0; i < new_matrix.GetLength(0); i++)                            
                for (int j = 0; j < new_matrix.GetLength(1); j++)                
                    new_matrix[i, j] = matrix[i + ((i < row) ? 0 : 1), j + ((j < col) ? 0 : 1)];                
            
            return new_matrix;
        }

        public void Transposition()
        {
            if (this.IsQuadratic)
            {
                int r_c_count = _matrixElements.GetLength(0);
                double tmp;
                for (int i = 1; i < r_c_count; i++)
                    for (int r_u, c_l = r_u = 0, c_u, r_l = c_u = i; c_u < r_c_count; r_u++, c_u++, r_l++, c_l++)
                    {
                        tmp = _matrixElements[r_u, c_u];
                        _matrixElements[r_u, c_u] = _matrixElements[r_l, c_l];
                        _matrixElements[r_l, c_l] = tmp;
                    }
            }
            else
            {
                int m = this.ColCount,
                    n = this.RowCount;
                double[,] new_matrix = new double[m, n];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        new_matrix[i, j] = this._matrixElements[j, i];
                this._matrixElements = new_matrix;
            }
        }

        public bool SwapLocationColumns(int index_col1, int index_col2)
        {
            if ((index_col1 >= 0) && (index_col1 <= this.ColCount) && (index_col2 >= 0) && (index_col2 <= this.ColCount) && (index_col1 != index_col2))
            {
                double tmp;
                for (int i = 0; i < this.RowCount; i++)
                {
                    tmp = _matrixElements[i, index_col1];
                    _matrixElements[i, index_col1] = _matrixElements[i, index_col2];
                    _matrixElements[i, index_col2] = tmp;
                }
                return true;
            }
            else
                return false;
        }

        public bool SwapLocationRows(int index_row1, int index_row2)
        {
            if ((index_row1 >= 0) && (index_row1 <= this.RowCount) && (index_row2 >= 0) && (index_row2 <= this.RowCount) && (index_row1 != index_row2))
            {
                double tmp;
                for (int j = 0; j < this.ColCount; j++)
                {
                    tmp = _matrixElements[index_row1, j];
                    _matrixElements[index_row1, j] = _matrixElements[index_row2, j];
                    _matrixElements[index_row2, j] = tmp;
                }
                return true;
            }
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Matrix2D)
                return (this as Matrix2D) == (obj as Matrix2D);
            else
                return false;
        }

        public double[,] To2DArray() //проверить
        {
            double[,] res = new double[this.RowCount, this.ColCount];
            this._matrixElements.CopyTo(res, 0);                                               //???
            return res;
        }

        /// <summary>
        /// Норма согласованная с третьей(сферической, или эвклидовой) нормой вектора, но не подчинённая ей
        /// </summary>
        public double Norm
        {
            get
            {
                double result = 0;
                foreach (double x in _matrixElements)
                    result += x * x;
                return Math.Sqrt(result);
            }
        }

        public double Trace
        {
            get
            {
                if (this.ColCount != this.RowCount)
                    return double.NaN;

                double result = 0;
                for (int i = 0, N = this.RowCount; i < N; i++)
                    result += _matrixElements[i, i];

                return result;
            }
        }
        
        public Matrix2D Copy()
        {
            return new Matrix2D(this._matrixElements);
        }

        public static Matrix2D CreateMatrix(int rowcount, int colcount)
        {
            if ((rowcount > 0) && (colcount > 0) && (rowcount <= MAXCOUNTROWS) && (colcount <= MAXCOUNTCOLUMNS))
                return new Matrix2D(rowcount, colcount);
            else
                return null; //лучше бросить специальное исключение                    
        }

        public static Matrix2D CreateMatrix(double[,] matrixElements)
        {
            if ((matrixElements != null) && (matrixElements.GetLength(0) <= MAXCOUNTROWS) && (matrixElements.GetLength(1) <= MAXCOUNTCOLUMNS)) 
                return new Matrix2D(matrixElements);
            else
                return null;  //в случае некорректного двумерного массива лучше бросать исключение, так метод не будет немым
        }

        private Matrix2D(int rowcount, int colcount)
        {
            _matrixElements = new double[rowcount, colcount];
        }

        private Matrix2D(double[,] matrixElements)
            :this(matrixElements.GetLength(0), matrixElements.GetLength(1))
        {
            int rowcount = matrixElements.GetLength(0),
                colcount = matrixElements.GetLength(1);
            for(int i = 0; i < rowcount; i++)
                for(int j = 0; j < colcount; j++)
                    _matrixElements[i, j] = matrixElements[i, j];
        }
    }
}
