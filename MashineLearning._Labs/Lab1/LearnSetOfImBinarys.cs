using System;
using System.Collections.Generic;
using System.Linq;

namespace MashineLearning.Classification
{
    class LearnSetOfImBinarys
    {
        private byte _heightIm = 1, _widthIm = 1;
        private Dictionary<string, List<ImBinary>> _set = new Dictionary<string,List<ImBinary>>();
        private int _count = 0;

        public byte HeightIm
        {
          get { return _heightIm; }
        }

        public byte WidthIm
        {
          get { return _widthIm; }
        }

        public int Count
        {
          get { return _count; }
        }

        public string[] Types
        {
            get
            {
                return _set.Keys.ToArray();
            }
        }

        public ImBinary[] ImBinarys
        {
            get
            {
                List<ImBinary> result = new List<ImBinary>();
                foreach (List<ImBinary> samplesOfType in _set.Values)
                    result.AddRange(samplesOfType);
                return result.ToArray();
            }
        }

        public double GetFrequencyType(string type)
        {
            if (type != null)
                if (_set.ContainsKey(type))
                    return (double)_set[type].Count / _count;

            return 0;
        }

        public double GetFrequencyType(int index)
        {
            if ((index >= 0) && (index < _set.Count))
                return (double)(_set.Values.ToArray<List<ImBinary>>()[index].Count) / _count;
            else
                return 0;
        }

        public bool Add(ImBinary im)
        {
            if ((im != null) && (im.Type != null) && (im.Type != "") && (im.RowCount == this._heightIm) && (im.ColumnCount == this._widthIm))
            {
                if (_set.ContainsKey(im.Type))
                    _set[im.Type].Add(im);
                else
                    _set.Add(im.Type, new List<ImBinary>(new ImBinary[] { im }));
                _count++;
                return true;
            }
            else
                return false;
        }

        public LearnSetOfImBinarys[] Split(uint index_prop)
        {
            if (index_prop < _heightIm * _widthIm)
            {
                LearnSetOfImBinarys[] result = new LearnSetOfImBinarys[2]{ new LearnSetOfImBinarys(this._heightIm, this._widthIm), 
                                                                           new LearnSetOfImBinarys(this._heightIm, this._widthIm)};
                foreach (List<ImBinary> samplesOfType in _set.Values)
                    for (int i = 0; i < samplesOfType.Count; i++)
                        result[samplesOfType[i].GetProp(index_prop)].Add(samplesOfType[i]);
                return result;
            }
            else
                return null;
        }

        public LearnSetOfImBinarys(byte hIm, byte wIm)
        {
            this._heightIm = hIm;
            this._widthIm = wIm;
        }

        public LearnSetOfImBinarys(ImBinary[] set)
        {
            if (set != null)
            {
                this._heightIm = set[0].RowCount;
                this._widthIm = set[0].ColumnCount;
                for (int i = 0, n = set.Length; i < n; i++)
                    this.Add(set[i]);
            }
        }          
    }
}
