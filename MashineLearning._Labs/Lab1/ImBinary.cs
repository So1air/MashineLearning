using System;
using System.Collections.Generic;

namespace MashineLearning.Classification
{
    enum Bin: byte
    {
        Null = 0,
        One = 1
    }    

    class ImBinary
    {
        private byte[] _properties;
        private string _type = null;             
        private readonly byte _row_count, _col_count;

        public string Type
        {
            get { return _type; }
            set
            {
                if ((_type == null) && (value != null) && (value.Length != 0))
                    _type = value;
            }
        }

        public byte RowCount
        {
            get { return _row_count; }
        }

        public byte ColumnCount
        {
            get { return _col_count; }
        }
        
        public int Size
        {
            get
            {
                return _properties.Length;
            }
        }

        public byte GetProp(uint i)
        {
            if (i < _properties.Length)
                return _properties[i];
            else return 3;
        }

        public bool SetProp(uint i, byte v) 
        { 
            if ((i < _properties.Length) && (v < 2)) 
            {                
                _properties[i] = v; 
                return true; 
            } 
            else 
                return false; 
        }

        public bool ReverseProp(uint i)
        {
            if (i < _properties.Length)
            {
                if (_properties[i] == 0)
                    _properties[i] = 1;
                else _properties[i] = 0;

                return true;
            }
            else
                return false;
        }

        public ImBinary Copy()
        {
            return new ImBinary(this._properties, this._type, this._row_count, this._col_count);
        }

        public byte[] PropertiesToArray()
        {
            byte[] result = new byte[_properties.Length];
            _properties.CopyTo(result, 0);
            return result;
        }

        public string ToStringData()
        {
            string result = "";
            for (int i = 0; i < _properties.Length; i++)
                result += _properties[i].ToString();
            if (this.Type != null)
                result += " " + this.Type;
            
            return result;
        }

        public override string ToString()
        {
            return (this._row_count + "x" + this._col_count + " - " + this._type);
        }

        public ImBinary(byte rc, byte cc)
        {
            if (rc == 0)
                rc = 1;
            if (cc == 0)
                cc = 1;
            _row_count = rc;
            _col_count = cc;
            _properties = new byte[_row_count * _col_count];
        }

        public ImBinary(byte[] prop_s, byte rc, byte cc)
            : this(rc, cc)
        {
            if (prop_s != null)
            {
                int min_len = (prop_s.Length < _properties.Length) ? prop_s.Length : _properties.Length;
                for (int i = 0; i < min_len; i++)
                    SetProp((uint)i, prop_s[i]);
            }
        }

        public ImBinary(byte[] prop_s, string type, byte rc, byte cc)
            : this(prop_s, rc, cc)
        {
            _type = type;
        }
    }
}
