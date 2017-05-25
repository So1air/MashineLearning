using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace MashineLearning.Classification
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
        
        private byte _countRowsInMatrix = 1, _countColumnsInMatrix = 1;
        private PictureBox _screen;
        private Graphics _drawer;

        public Point GetMatrixCoord(Point coord_in_screen) //+
        {
            if ((coord_in_screen.X < _screen.Width) && (coord_in_screen.Y < _screen.Height))
                return new Point(coord_in_screen.X / (_screen.Width / _countColumnsInMatrix), coord_in_screen.Y / (_screen.Height / _countRowsInMatrix));
            else return new Point(-1, -1);            
        }
        
        public bool DrawBinaryPoint(Point coord)  //+
        {
            if ((coord.X < _screen.Width) && (coord.Y < _screen.Height))
            {
                int dx = _screen.Width / _countColumnsInMatrix,
                    dy = _screen.Height / _countRowsInMatrix;

                if (EqualityColors(((Bitmap)_screen.Image).GetPixel(coord.X, coord.Y), _color0))
                    _drawer.FillRectangle(new SolidBrush(_color1), (coord.X / dx) * dx, (coord.Y / dy) * dy, dx, dy);
                else                
                    _drawer.FillRectangle(new SolidBrush(_color0), (coord.X / dx) * dx, (coord.Y / dy) * dy, dx, dy);
  
                _screen.Refresh();
                return true;                
            }
            else
                return false;
        }

        private bool EqualityColors(Color c1, Color c2)
        {
            return c1.ToArgb() == c2.ToArgb();
        }

        public bool DrawBinaryPoint(byte index_row, byte index_col) //+
        {
            if ((index_row < _countRowsInMatrix) && (index_col < _countColumnsInMatrix))
            {
                int dx = _screen.Width / _countColumnsInMatrix,
                    dy = _screen.Height / _countRowsInMatrix;

                if (EqualityColors(((Bitmap)_screen.Image).GetPixel(index_col * dx, index_row * dy), _color0))
                    _drawer.FillRectangle(new SolidBrush(_color1), index_col * dx, index_row * dy, dx, dy);
                else
                    _drawer.FillRectangle(new SolidBrush(_color0), index_col * dx, index_row * dy, dx, dy);
                _screen.Refresh();
                return true;
            }
            else
                return false;
        }

        public bool DrawIm(ImBinary im) //+
        {
            if (im != null)
            {
                ChangeParamMatrix(im.RowCount, im.ColumnCount);
                for (byte r = 0; r < im.RowCount; r++)
                    for (byte c = 0; c < im.ColumnCount; c++)
                        if(im.GetProp((uint)(r * im.ColumnCount + c)) == 1) 
                            DrawBinaryPoint(r, c);
                return true;
            }
            else
                return false;
        }

        public ImBinary GetIm() //+
        {
            //if (_screen.Enabled)
            //{
                _screen.Enabled = false;

                ImBinary im = new ImBinary(_countRowsInMatrix, _countColumnsInMatrix);
                int dx = _screen.Width / _countColumnsInMatrix,
                    dy = _screen.Height / _countRowsInMatrix;
                for (byte r = 0; r < _countRowsInMatrix; r++)
                    for (byte c = 0; c < _countColumnsInMatrix; c++)
                        if (EqualityColors(((Bitmap)_screen.Image).GetPixel(c * dx, r * dy), _color0))
                            im.SetProp((uint)(r * _countColumnsInMatrix + c), 0);
                        else
                            im.SetProp((uint)(r * _countColumnsInMatrix + c), 1);

                _screen.Enabled = true;
                return im;
            //}
            //else
            //    return null;
        }

        public bool ClearIm() //+
        {
            if (_drawer != null)
            {
                _drawer.Clear(_color0);
                _screen.Refresh();
                return true;
            }
            else return false;
        }

        public bool ChangeParamMatrix(byte count_rows, byte count_columns) //+
        {
            if ((count_rows > 0) && (count_columns > 0) && (count_rows < _screen.MaximumSize.Height) && (count_columns < _screen.MaximumSize.Width))
            {
                _countRowsInMatrix = count_rows;
                _countColumnsInMatrix = count_columns;

                //змінюємо координати компонента відображення до кратних кількості рядків і стовпців матриці
                _screen.Height = (_screen.MaximumSize.Height / _countRowsInMatrix) * _countRowsInMatrix;
                _screen.Width = (_screen.MaximumSize.Width / _countColumnsInMatrix) * _countColumnsInMatrix;
                ClearIm();
                return true;
            }
            else            
                return false;            
        }

        public DrawerImBinary(ref PictureBox screen, byte count_rows, byte count_columns) //+
        {
            _screen = screen;

            if (screen != null)
            {
                _screen.Image = new Bitmap(_screen.MaximumSize.Width, _screen.MaximumSize.Height);
                _drawer = Graphics.FromImage(screen.Image); 
                ClearIm();
                ChangeParamMatrix(count_rows, count_columns);
               
            }
        }
    }
}
