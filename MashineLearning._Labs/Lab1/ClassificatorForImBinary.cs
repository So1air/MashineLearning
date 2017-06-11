using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashineLearning.Classification
{
    abstract class ClassificatorForImBinary
    {
        protected readonly byte _heightIm, _widthIm;

        public byte HeightIm
        {
            get { return _heightIm; }
        } 

        public byte WidthIm
        {
            get { return _widthIm; }
        } 

        public abstract string Classificate(ImBinary im);

        public ClassificatorForImBinary(byte heightIm, byte widthIm)
        {
            _heightIm = heightIm;
            _widthIm = widthIm;
        }
    }
}
