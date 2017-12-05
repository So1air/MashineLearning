using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Vector
    {
        public const int MAXCOUNTCOORDINATS = ushort.MaxValue;

        private double[] _vectorElements;

        public double this[int i]
        {
            get 
            {
                return _vectorElements[i];
            }
            set 
            {
                _vectorElements[i] = value;
            }
        }

        public int Length
        {
            get
            {
                return _vectorElements.Length;
            }
        }

        public static Vector operator -(Vector v)
        {
            Vector result = new Vector(v._vectorElements.Length);
            for(int i = 0; i < result.Length; i++)
                result._vectorElements[i] = - v._vectorElements[i];

            return result;
        }

        public static Vector operator *(double alfa, Vector v)
        {
            Vector result = new Vector(v._vectorElements);
            for (int i = 0; i < result.Length; i++)
                result[i] *= alfa;
            return result;
        }

        public static double operator *(Vector left_v, Vector right_v)
        {
            double result = 0;
            if (left_v.Length == right_v.Length)
                for (int i = 0; i < left_v.Length; i++)
                    result += left_v._vectorElements[i] * right_v._vectorElements[i];
            else
                result = double.NaN;
            return result;
        }

        public static Vector operator +(Vector left_v, Vector right_v)
        {
            Vector result = new Vector(left_v.Length);
            if (left_v.Length == right_v.Length)
                for (int i = 0; i < result.Length; i++)
                    result._vectorElements[i] = left_v._vectorElements[i] + right_v._vectorElements[i];
            else
                result = null;
            return result;
        }

        public static Vector operator -(Vector left_v, Vector right_v)
        {
            //return left_v + (-right_v);
            Vector result = new Vector(left_v.Length);
            if (left_v.Length == right_v.Length)
                for (int i = 0; i < result.Length; i++)
                    result._vectorElements[i] = left_v._vectorElements[i] - right_v._vectorElements[i];
            else
                result = null;
            return result;
        }

        public static bool operator ==(Vector left_v, Vector right_v)
        {
            if (object.ReferenceEquals(left_v, null))
                if (object.ReferenceEquals(null, right_v))
                    return true;
                else
                    return false;
            if (object.ReferenceEquals(null, right_v))
                if (object.ReferenceEquals(left_v, null))
                    return true;
                else
                    return false;
            else
                if (left_v.Length == right_v.Length) 
                {
                    for (int i = 0; i < left_v.Length; i++)
                        if (left_v[i] != right_v[i])
                            return false;
                }
                else
                    return false; //лучше бросить специальное исключение    

            return true;
        }

        public static bool operator !=(Vector left_v, Vector right_v)
        {
            return !(left_v == right_v);
        }

        public bool IsNullVector
        {
            get
            {
                for (int i = 0; i < this._vectorElements.Length; i++)
                    if (this._vectorElements[i] != 0)
                        return false;

                return true;
            }
        }

        /// <summary>
        /// Третя(сферична, або евклідова) норма.
        /// </summary>
        public double Norm
        {
            get
            {
                double result = 0;
                foreach (double x in _vectorElements)
                    result += x * x;
                return Math.Sqrt(result);
            }
        }

        public Vector Copy()
        {
            return new Vector(this._vectorElements);
        }

        public bool CopyTo(Vector target)
        {
            if (target != null)
                if (target.Length == this.Length)
                {
                    for (int i = 0; i < this.Length; i++)
                        target._vectorElements[i] = this._vectorElements[i];
                    return true;
                }

            return false;
        }

        public double[] ToArray()
        {
            double[] copy = new double[_vectorElements.Length];
            _vectorElements.CopyTo(copy, 0);
            return copy;
        }

        public static Vector CreateVector(int length)
        {
            if ((length > 0) && (length <= MAXCOUNTCOORDINATS))
                return new Vector(length);
            else
                return null;
        }             

        public static Vector CreateVector(double[] coordinats)
        {
            if ((coordinats != null) && (coordinats.Length <= MAXCOUNTCOORDINATS))
                return new Vector(coordinats);
            else
                return null;
        }

        private Vector(int len)
        {
            _vectorElements = new double[len];
        }

        private Vector(double[] coordinats)
            :this(coordinats.Length)
        {
            coordinats.CopyTo(_vectorElements, 0);
        }
    }
}
