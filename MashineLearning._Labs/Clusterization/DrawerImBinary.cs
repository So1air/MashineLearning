using System;
using System.Drawing;
using System.Windows.Forms;


namespace MashineLearning.Clusterization
{
    class DrawerImBinary
    {
        private Color _color0 = Color.White,
                      _color1 = Color.Black;        

        public Color Color0
        {
            get { return _color0; }
            set 
            {
                if (_color1 != value)
                    _color0 = value; 
            }
        }

        public Color Color1
        {
            get { return _color1; }
            set 
            {
                if(_color0 != value)
                _color1 = value; 
            }
        }
        
        protected byte _countRowsInMatrix = 1, _countColumnsInMatrix = 1;
        protected short _dx, _dy;
        protected PictureBox _screen;
        protected Graphics _drawer;

        public Point GetMatrixCoord(Point coord_in_screen) 
        {
            if ((coord_in_screen.X < _screen.Width) && (coord_in_screen.Y < _screen.Height))
                return new Point(coord_in_screen.X / _dx /*(_screen.Width / _countColumnsInMatrix)*/, coord_in_screen.Y / _dy /* (_screen.Height / _countRowsInMatrix)*/);
            else return new Point(-1, -1);            
        }
        
        public bool DrawBinaryPoint(Point coord)  
        {
            if ((coord.X < _screen.Width) && (coord.Y < _screen.Height))
            {
                //int dx = _screen.Width / _countColumnsInMatrix,
                //    dy = _screen.Height / _countRowsInMatrix;

                if (EqualityColors(((Bitmap)_screen.Image).GetPixel(coord.X, coord.Y), _color0))
                    _drawer.FillRectangle(new SolidBrush(_color1), (coord.X / _dx) * _dx, (coord.Y / _dy) * _dy, _dx, _dy);
                else                
                    _drawer.FillRectangle(new SolidBrush(_color0), (coord.X / _dx) * _dx, (coord.Y / _dy) * _dy, _dx, _dy);
  
                _screen.Refresh();
                int w_bugtest = _screen.Image.Width;

                return true;                
            }
            else
                return false;
        }

        protected bool EqualityColors(Color c1, Color c2)
        {
            return c1.ToArgb() == c2.ToArgb();
        }

        public bool DrawBinaryPoint(byte index_row, byte index_col)
        {
            if ((index_row < _countRowsInMatrix) && (index_col < _countColumnsInMatrix))
            {
                if (EqualityColors(((Bitmap)_screen.Image).GetPixel(index_col * _dx, index_row * _dy), _color0))
                    _drawer.FillRectangle(new SolidBrush(_color1), index_col * _dx, index_row * _dy, _dx, _dy);
                else
                    _drawer.FillRectangle(new SolidBrush(_color0), index_col * _dx, index_row * _dy, _dx, _dy);
                _screen.Refresh();
                return true;
            }
            else
                return false;
        }

        public bool DrawBinaryPoint (uint numPoint, Color colorSelection)
        {
            if (numPoint < _countRowsInMatrix * _countColumnsInMatrix)
            {
                _drawer.FillRectangle(new SolidBrush(colorSelection), (numPoint % _countColumnsInMatrix) * _dx + 1, (numPoint / _countColumnsInMatrix) * _dy + 1, _dx - 1, _dy - 1);
                _screen.Refresh();
                return true;
            }
            else
                return false;
        }

        public void DrawBinaryPoints(uint[] numPoints, Color colorSelection)
        {
            foreach(uint numPoint in numPoints)
                if (numPoint < _countRowsInMatrix * _countColumnsInMatrix)
                {
                    _drawer.FillRectangle(new SolidBrush(colorSelection), (numPoint % _countColumnsInMatrix) * _dx + 1, (numPoint / _countColumnsInMatrix) * _dy + 1, _dx - 2, _dy - 2);                
                }
            _screen.Refresh();
        }

        public bool DrawIm(ImBinary im) 
        {
            if (im != null)
            {
                ChangeParamMatrix(im.RowCount, im.ColumnCount);
                for (byte r = 0; r < im.RowCount; r++)
                    for (byte c = 0; c < im.ColumnCount; c++)
                        if(im.GetProp((uint)(r * im.ColumnCount + c)) == 1) 
                            _drawer.FillRectangle(new SolidBrush(_color1), c * _dx, r * _dy, _dx, _dy);
                _screen.Refresh();
                return true;
            }
            else
                return false;
        }

        public ImBinary GetIm() 
        {
            //if (_screen.Enabled)
            //{
                _screen.Enabled = false;

                ImBinary im = new ImBinary(_countRowsInMatrix, _countColumnsInMatrix);
                //int dx = _screen.Width / _countColumnsInMatrix,
                //    dy = _screen.Height / _countRowsInMatrix;
                for (byte r = 0; r < _countRowsInMatrix; r++)
                    for (byte c = 0; c < _countColumnsInMatrix; c++)
                        if (EqualityColors(((Bitmap)_screen.Image).GetPixel(c * _dx, r * _dy), _color0))
                            im.SetProp((uint)(r * _countColumnsInMatrix + c), 0);
                        else
                            im.SetProp((uint)(r * _countColumnsInMatrix + c), 1);

                _screen.Enabled = true;
                return im;
            //}
            //else
            //    return null;
        }

        public bool ClearIm() 
        {
            if (_drawer != null)
            {
                _drawer.Clear(_color0);
                _screen.Refresh();
                return true;
            }
            else return false;
        }

        public bool ChangeParamMatrix(byte count_rows, byte count_columns) 
        {
            if ((count_rows > 0) && (count_columns > 0) && (count_rows < _screen.MaximumSize.Height) && (count_columns < _screen.MaximumSize.Width))
            {
                _countRowsInMatrix = count_rows;
                _countColumnsInMatrix = count_columns;

                _dy = (short)(_screen.MaximumSize.Height / _countRowsInMatrix);
                _dx = (short)(_screen.MaximumSize.Width / _countColumnsInMatrix);
                if (_dx > _dy) //это условие делает точки на изображении квадратами
                    _dx = _dy;
                else
                    _dy = _dx;

                //змінюємо координати компонента відображення до кратних кількості рядків і стовпців матриці
                _screen.Height = _dy * _countRowsInMatrix;
                _screen.Width = _dx * _countColumnsInMatrix;

                //костыльное исправление массштабирования битмапа 
                _screen.Image = new Bitmap(_screen.Width, _screen.Height);
                _drawer = Graphics.FromImage(_screen.Image);

                ClearIm();
                return true;
            }
            else            
                return false;            
        }

        public DrawerImBinary(ref PictureBox screen, byte count_rows, byte count_columns) 
        {
            _screen = screen;

            if (screen != null)
            {
                //_screen.Image = new Bitmap(_screen.MaximumSize.Width, _screen.MaximumSize.Height);
                //_drawer = Graphics.FromImage(screen.Image); 
                //ClearIm();
                ChangeParamMatrix(count_rows, count_columns);
            }
            else
                throw new ArgumentNullException("screen");
        }
    }
}
