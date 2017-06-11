using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MashineLearning.Classification
{
    public partial class frmMashineLearning : Form
    {
        const char MARK_MODEL = 'M',
                   MARK_NOISE_IMAGE = 'N';
        //lab1
        CollectionOfImBinarys _collectionAvalaibleImages = new CollectionOfImBinarys();
        DrawerImBinary _drawerImages;        
        int _oldSelectIndex = 0;
        bool _multiSelect = false;
        //lab2
        DecisionTreeForImBinary _currClassificator;
        List<DecisionTreeForImBinary> _classificators = new List<DecisionTreeForImBinary>();
        DrawerImBinary _drawerLearnIm;
        Color _colorSelectionImpProp = Color.Yellow;

        public frmMashineLearning()
        {
            InitializeComponent();
            _drawerImages = new DrawerImBinary(ref pcB_Image, (byte)(nUD_RowCount.Value), (byte)(nUD_ColCount.Value));
            _drawerLearnIm = new DrawerImBinary(ref pcB_DemoLearnIm, (byte)(nUD_RowCount.Value), (byte)(nUD_ColCount.Value));
            lblStatusCreateNoisy.Text = "";
            lblStatusNameModel.Text = "";
            lblStatusCreateClassificator.Text = "";
        }    

        private void btnAddModel_Click(object sender, EventArgs e)
        {            
            if (txB_NameTypeModel.Text.Length == 0)
            {
                lblStatusNameModel.ForeColor = Color.Red;
                lblStatusNameModel.Text = "Введіть назву!";
                txB_NameTypeModel.Focus();
            }
            else 
            {
                btnAddModel.Visible = false;
                grB_CreateNoisyImages.Visible = false;
                pnl_SaveAndLoad.Visible = false;
                //btnChangeIm.Visible = false;
                //btnDeleteIm.Visible = false;
                nUD_RowCount.Enabled = true;
                nUD_ColCount.Enabled = true;
                btnAcceptIm.Visible = true;
                btnCancelIm.Visible = true;
                pcB_Image.Enabled = true;
                lblCurrMatrCoord.Visible = true;
                lblCursorPosInMatrCoord.Text = "";
                lblCursorPosInMatrCoord.Visible = true;
            }
        }         
        
        private void pcB_Image_MouseDown(object sender, MouseEventArgs e)
        {
            _drawerImages.DrawBinaryPoint(e.Location);          
        }

        private void pcB_Image_MouseMove(object sender, MouseEventArgs e) //+
        {
            Point p = _drawerImages.GetMatrixCoord(e.Location);
            lblCursorPosInMatrCoord.Text = String.Format("row: {0}; col: {1}", p.Y, p.X);
        }

        private void nUD_RowCount_ValueChanged(object sender, EventArgs e) //+
        {
            _drawerImages.ChangeParamMatrix((byte)(nUD_RowCount.Value), (byte)(nUD_ColCount.Value)); 
        }

        private void btnCreateNoisyImage_Click(object sender, EventArgs e)
        {   
            grB_CreateNoisyImages.Enabled = false;
            if ((cmB_ListOfModels.SelectedIndex >= 0) && (nUD_CountNoisy.Value > 0) && (nUD_EpsNoisy.Value > 0))
            {
                string[] parse = cmB_ListOfModels.Text.Split(new char[2]{'x', '_'}, 3);
                try
                {
                    byte row_cou = Convert.ToByte(parse[0]),
                         col_cou = Convert.ToByte(parse[1]);
                    string typeModel = parse[2];
                    int numberNoiseImage = 0;
                    for (int i = 0; (i < nUD_CountNoisy.Value) && (numberNoiseImage != -1); i++)
                    {
                        numberNoiseImage = _collectionAvalaibleImages.CreateNoiseImageFromModel(row_cou, col_cou, typeModel, (double)nUD_EpsNoisy.Value, CollectionOfImBinarys.TypeNoise.Simple);
                        if (numberNoiseImage != -1)
                        {
                            dUD_ListImage.Items.Add(MARK_NOISE_IMAGE.ToString() + numberNoiseImage + "_" + row_cou + "x" + col_cou + "_" + typeModel);
                            cLB_ListAvalaibleImages.Items.Add(MARK_NOISE_IMAGE.ToString() + numberNoiseImage + "_" + row_cou + "x" + col_cou + "_" + typeModel);
                            lblStatusCreateNoisy.ForeColor = Color.Green;
                            lblStatusCreateNoisy.Text = "Зашумлене зображення успішно додано у позицію " + numberNoiseImage;
                        }
                        else
                        {
                            lblStatusCreateNoisy.ForeColor = Color.Red;
                            lblStatusCreateNoisy.Text = "Неможливо додати зашумлені зображення до вказаного еталону.";
                        }
                    }
                }
                catch (Exception)
                {
                    lblStatusCreateNoisy.ForeColor = Color.Red;
                    lblStatusCreateNoisy.Text = "Сталася неочікувана помилка.";
                }
            }
            grB_CreateNoisyImages.Enabled = true;
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (oFD_Loader.ShowDialog() == DialogResult.OK)
            {
                StreamReader loader = new StreamReader(oFD_Loader.FileName);
                List<string> loadImages = new List<string>();
                try
                {
                    string[] parse = loader.ReadLine().Split(' ');
                    ImBinary loadIm;

                    byte row_cou = Convert.ToByte(parse[0]),
                         col_cou = Convert.ToByte(parse[1]);
                    byte[] prop_s;
                    byte p;
                    bool not_errorInData;
                    int num_noiseIm;
                    while (!loader.EndOfStream)
                    {
                        not_errorInData = true;
                        parse = loader.ReadLine().Split(' ');
                        switch (parse[0][0])
                        {
                            case MARK_MODEL:
                                prop_s = new byte[parse[1].Length];
                                for (int i = 0; not_errorInData && (i < prop_s.Length); i++)
                                    if ((p = Convert.ToByte(parse[1][i].ToString())) > 1)
                                        not_errorInData = false;
                                    else
                                        prop_s[i] = p;

                                if (not_errorInData)
                                {
                                    loadIm = new ImBinary(prop_s, parse[2], row_cou, col_cou);
                                    if (_collectionAvalaibleImages.AddModel(loadIm))
                                    {
                                        cmB_ListOfModels.Items.Add(row_cou + "x" + col_cou + "_" + parse[2]);
                                        cLB_ListAvalaibleImages.Items.Add(MARK_MODEL.ToString() + "_" + cmB_ListOfModels.Items[cmB_ListOfModels.Items.Count - 1]);
                                        dUD_ListImage.Items.Add(cLB_ListAvalaibleImages.Items[cLB_ListAvalaibleImages.Items.Count - 1].ToString());
                                        loadImages.Add(cLB_ListAvalaibleImages.Items[cLB_ListAvalaibleImages.Items.Count - 1].ToString());
                                    }
                                }
                                break;
                            case MARK_NOISE_IMAGE:
                                prop_s = new byte[parse[1].Length];
                                for (int i = 0; not_errorInData && (i < prop_s.Length); i++)
                                    if ((p = Convert.ToByte(parse[1][i].ToString())) > 1)
                                        not_errorInData = false;
                                    else
                                        prop_s[i] = p;

                                if (not_errorInData)
                                {
                                    loadIm = new ImBinary(prop_s, parse[2], row_cou, col_cou);
                                    if ((num_noiseIm = _collectionAvalaibleImages.AddNoiseImage(loadIm)) != -1)
                                    {
                                        cLB_ListAvalaibleImages.Items.Add(MARK_NOISE_IMAGE.ToString() + num_noiseIm + "_" + row_cou + "x" + col_cou + "_" + parse[2]);
                                        dUD_ListImage.Items.Add(cLB_ListAvalaibleImages.Items[cLB_ListAvalaibleImages.Items.Count - 1].ToString());
                                        loadImages.Add(cLB_ListAvalaibleImages.Items[cLB_ListAvalaibleImages.Items.Count - 1].ToString());
                                    }
                                }
                                break;
                            default:
                                row_cou = Convert.ToByte(parse[0]);
                                col_cou = Convert.ToByte(parse[1]);
                                break;
                        }
                    }
                }
                catch (OverflowException oE)
                {
                    MessageBox.Show(oE.Message, "OverflowException");
                }
                catch (FormatException fE)
                {
                    MessageBox.Show(fE.Message, "FormatException");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Exception");
                }
                finally
                {
                    loader.Close();
                    string report;
                    if (loadImages.Count > 0)
                    {
                        dUD_ListImage.SelectedIndex = dUD_ListImage.Items.Count - 1;
                        report = "Додані образи:";
                        foreach (string l_Im in loadImages)
                            report += "\n  + " + l_Im;
                    }
                    else report = "Не вдалося завантажити жодного образу.";
                    MessageBox.Show(report, "Звіт завантаження");
                }
            }
        }

        private void btnSaveInFile_Click(object sender, EventArgs e)
        {
            if (cLB_ListAvalaibleImages.CheckedItems.Count > 0)
            {
                if (sFD_Saver.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter saver = new StreamWriter(sFD_Saver.FileName);
                    try
                    {
                        string[] parse;
                        ImBinary saveIm;
                        byte row_cou, col_cou;

                        int[] orderWrite;
                        List<int> direct_order = new List<int>();
                        for(int i = 0; i < cLB_ListAvalaibleImages.CheckedIndices.Count; i++)
                            direct_order.Add(cLB_ListAvalaibleImages.CheckedIndices[i]);

                        if (chB_RandomOrder.Checked){
                            Random r = new Random();
                            int index;
                            orderWrite = new int[direct_order.Count];
                            for(int i = 0; direct_order.Count > 0; i++){
                                index = r.Next(direct_order.Count - 1);
                                orderWrite[i] = direct_order[index];
                                direct_order.RemoveAt(index);
                            }                           
                        }
                        else 
                            orderWrite = direct_order.ToArray<int>();                        
                        
                        byte old_row_cou = 0, 
                             old_col_cou = 0;
                        foreach (int nextIm in orderWrite)
                        {
                            parse = cLB_ListAvalaibleImages.Items[nextIm].ToString().Split(new char[2]{'_', 'x'}, 4);
                            if (parse.Length > 0)
                            {
                                row_cou = Convert.ToByte(parse[1]);
                                col_cou = Convert.ToByte(parse[2]);                                        
                                if ((row_cou != old_row_cou) || (col_cou != old_col_cou))
                                {
                                    saver.WriteLine(row_cou.ToString() + " " + col_cou.ToString());
                                    old_row_cou = row_cou;
                                    old_col_cou = col_cou;
                                }
                                switch (parse[0][0])
                                {
                                    case MARK_MODEL:
                                        saveIm = _collectionAvalaibleImages.GetModel(row_cou, col_cou, parse[3]);
                                        saver.WriteLine(MARK_MODEL.ToString() + " " + saveIm.ToString());
                                        break;
                                    case MARK_NOISE_IMAGE:
                                        saveIm = _collectionAvalaibleImages.GetNoiseImage(row_cou, col_cou, parse[3], Convert.ToUInt32(parse[0].Substring(1)));
                                        saver.WriteLine(MARK_NOISE_IMAGE.ToString() + " " + saveIm.ToString());
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        saver.Close();
                    }
                }
                else { }
            }
            else MessageBox.Show("Будь ласка, оберіть образи у списку.");
        }

        private void dUD_ListImage_SelectedItemChanged(object sender, EventArgs e)
        {
            ImBinary currIm = null;
            try
            {            
                string[] parse = dUD_ListImage.SelectedItem.ToString().Split(new char[2]{'x', '_'}, 4);

                byte row_cou = Convert.ToByte(parse[1]),
                     col_cou = Convert.ToByte(parse[2]);
                string typeModel = parse[3];
                switch (parse[0][0])
                {
                    case MARK_MODEL:
                        currIm = _collectionAvalaibleImages.GetModel(row_cou, col_cou, typeModel);
                        break;
                    case MARK_NOISE_IMAGE:
                        uint numNoiseImage = Convert.ToUInt32(parse[0].Substring(1));
                        currIm = _collectionAvalaibleImages.GetNoiseImage(row_cou, col_cou, typeModel, numNoiseImage);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception) 
            {
                if (dUD_ListImage.SelectedItem != null)
                    dUD_ListImage.Items.Remove(dUD_ListImage.SelectedItem);
                if (dUD_ListImage.Items.Count != 0)
                    dUD_ListImage.SelectedIndex = dUD_ListImage.Items.Count - 1;
                else
                {
                    dUD_ListImage.Text = "<доступних образів немає>";
                    txB_NumChooseIm.Text = "--/0";
                    _drawerImages.ClearIm();
                }
                return;
            }
            
            if (currIm != null)
            {
                nUD_RowCount.Value = currIm.RowCount;
                nUD_ColCount.Value = currIm.ColumnCount;
                if (!(_drawerImages.DrawIm(currIm)))
                    _drawerImages.ClearIm();
                txB_NumChooseIm.Text = dUD_ListImage.SelectedIndex + 1 + "/" + dUD_ListImage.Items.Count;
            }
            else
            {
                dUD_ListImage.Items.Remove(dUD_ListImage.SelectedItem);
                if (dUD_ListImage.Items.Count != 0)
                    dUD_ListImage.SelectedIndex = dUD_ListImage.Items.Count - 1;
                else
                {
                    dUD_ListImage.Text = "<доступних образів немає>";
                    _drawerImages.ClearIm();
                }
            }
        }

        private void btnAcceptIm_Click(object sender, EventArgs e)
        {
            nUD_RowCount.Enabled = false;
            nUD_ColCount.Enabled = false;
            txB_NameTypeModel.ReadOnly = true;
            btnAcceptIm.Enabled = false;
            btnCancelIm.Visible = false;           

            if (_collectionAvalaibleImages.GetModel((byte)nUD_RowCount.Value, (byte)nUD_ColCount.Value, txB_NameTypeModel.Text) != null)
            {
                lblStatusNameModel.ForeColor = Color.Red;
                lblStatusNameModel.Text = "Еталон такого типу уже є!";
                btnAcceptIm.Enabled = true;
                btnCancelIm.Visible = true;
                nUD_RowCount.Enabled = true;
                nUD_ColCount.Enabled = true;
                txB_NameTypeModel.Focus();
            }
            else
            {   
                pcB_Image.Enabled = false;
                dUD_ListImage.Enabled = false;
                ImBinary newModel = _drawerImages.GetIm();
                newModel.Type = txB_NameTypeModel.Text.Replace(' ', '_');
                if (_collectionAvalaibleImages.AddModel(newModel))
                {
                    dUD_ListImage.Items.Add(MARK_MODEL + "_" + newModel.RowCount + "x" + newModel.ColumnCount + "_" + newModel.Type);
                    cLB_ListAvalaibleImages.Items.Add(MARK_MODEL + "_" + newModel.RowCount + "x" + newModel.ColumnCount + "_" + newModel.Type);
                    dUD_ListImage.SelectedIndex = dUD_ListImage.Items.Count - 1;
                    cmB_ListOfModels.Items.Add(newModel.RowCount + "x" + newModel.ColumnCount + "_" + newModel.Type);
                    lblStatusNameModel.ForeColor = Color.Green;
                    lblStatusNameModel.Text = "Еталон успішно додано.";
                    btnAcceptIm.Visible = false;
                    btnAcceptIm.Enabled = true;
                    lblCursorPosInMatrCoord.Visible = false;
                    lblCursorPosInMatrCoord.Text = "";
                    lblCurrMatrCoord.Visible = false;
                    pcB_Image.Enabled = false;
                    btnCancelIm.Visible = false;
                    btnAcceptIm.Visible = false;
                    nUD_ColCount.Enabled = false;
                    nUD_RowCount.Enabled = false;
                    //btnDeleteIm.Visible = true;
                    //btnChangeIm.Visible = true;
                    pnl_SaveAndLoad.Visible = true;
                    grB_CreateNoisyImages.Visible = true;
                    btnAddModel.Visible = true;
                }
                else
                {
                    lblStatusNameModel.ForeColor = Color.Red;
                    lblStatusNameModel.Text = "Еталон не вдалося додати.";
                    pcB_Image.Enabled = true;
                    btnAcceptIm.Enabled = true;
                    btnCancelIm.Visible = true;
                    nUD_RowCount.Enabled = true;
                    nUD_ColCount.Enabled = true;
                }

                dUD_ListImage.Enabled = true;
            }

            txB_NameTypeModel.ReadOnly = false;
        }

        private void btnCancelIm_Click(object sender, EventArgs e)
        {                         
            lblCursorPosInMatrCoord.Visible = false; 
            lblCursorPosInMatrCoord.Text = "";            
            lblCurrMatrCoord.Visible = false;
            pcB_Image.Enabled = false;
            btnCancelIm.Visible = false;
            btnAcceptIm.Visible = false;
            nUD_ColCount.Enabled = false;
            nUD_RowCount.Enabled = false;
            //btnDeleteIm.Visible = true;
            //btnChangeIm.Visible = true;
            pnl_SaveAndLoad.Visible = true;
            grB_CreateNoisyImages.Visible = true;
            btnAddModel.Visible = true;
            txB_NameTypeModel.ReadOnly = false;
            
            dUD_ListImage_SelectedItemChanged(this.dUD_ListImage, new EventArgs());
        }

        private void cmB_ListOfModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmB_ListOfModels.Items.Count > 0)
                if (cmB_ListOfModels.SelectedIndex >= 0)
                    btnCreateNoisyImage.Enabled = true;
                else
                    btnCreateNoisyImage.Enabled = false;
            else cmB_ListOfModels.Text = "<доступних еталонів немає>";
        }

        private void nUD_EpsNoisy_ValueChanged(object sender, EventArgs e)
        {
            if (nUD_EpsNoisy.Value == 0)
                nUD_EpsNoisy.Value = (decimal)Math.Pow(10, -nUD_EpsNoisy.DecimalPlaces);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _drawerImages.DrawBinaryPoint(0, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(599, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(580, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(19, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(289, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(299, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(280, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(9, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(589, Color.YellowGreen);
            _drawerImages.DrawBinaryPoint(600, Color.YellowGreen);



            return;
            string[] testTypes = _collectionAvalaibleImages.GetTypes(30, 20);
            int count = 0;
            ImBinary currIm;
            foreach (string type in testTypes)
                for (uint i = 0; i < 74; i++)
                {
                    currIm = _collectionAvalaibleImages.GetNoiseImage(30, 20, type, i);
                    count += (currIm.Type == _currClassificator.Classificate(currIm)) ? 1 : 0;
                }
            cmB_Dimensionalitys.Items.Add(((double)count) / 592);

            //{
            //    List<ImBinary> allIm = _collectionAvalaibleImages.GetImBinarys(30, 20);
            //    int count = 0;
            //    for (int i = 0, n = allIm.Count; i < n; i++)
            //        count += (allIm[i].Type == _classificator.Classificate(allIm[i])) ? 1 : 0;
            //    comboBox1.Items.Add(((double)count) / allIm.Count);
            //}
            //ImBinary currIm = null;
            //string[] parse = dUD_ListImage.SelectedItem.ToString().Split(new char[2] { 'x', '_' }, 4);

            //byte row_cou = Convert.ToByte(parse[1]),
            //     col_cou = Convert.ToByte(parse[2]);
            //string typeModel = parse[3];
            //switch (parse[0][0])
            //{
            //    case MARK_MODEL:
            //        currIm = _collectionAvalaibleImages.GetModel(row_cou, col_cou, typeModel);
            //        break;
            //    case MARK_NOISE_IMAGE:
            //        uint numNoiseImage = Convert.ToUInt32(parse[0].Substring(1));
            //        currIm = _collectionAvalaibleImages.GetNoiseImage(row_cou, col_cou, typeModel, numNoiseImage);
            //        break;
            //    default:
            //        break;
            //}
            //comboBox1.Items.Add(_classificator.Classificate(currIm));
            return;
            _currClassificator = DecisionTreeForImBinary.CreateInstance(_collectionAvalaibleImages.GetImBinarys(30, 20).ToArray());
            uint[] t = _currClassificator.NumbersImportantProps;
            foreach (uint p in t) 
                cmB_Dimensionalitys.Items.Add(p);
        }

        private void cLB_ListAvalaibleImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            _oldSelectIndex = dUD_ListImage.SelectedIndex = cLB_ListAvalaibleImages.SelectedIndex;
        }

        private void txB_NumChooseIm_Validated(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(txB_NumChooseIm.Text, out number))
                if ((number > 0) && (number <= dUD_ListImage.Items.Count))                
                    dUD_ListImage.SelectedIndex = number - 1;

            txB_NumChooseIm.Text = dUD_ListImage.SelectedIndex + 1 + "/" + dUD_ListImage.Items.Count;                
        }

        private void txB_NumChooseIm_Enter(object sender, EventArgs e)
        {
            txB_NumChooseIm.Text = "";
        }

        private void txB_NumChooseIm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dUD_ListImage.Focus();
                txB_NumChooseIm.Focus();
            }
        }

        private void chB_CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            bool state = chB_CheckAll.Checked;
            for (int i = 0, n = cLB_ListAvalaibleImages.Items.Count; i < n; i++)
                cLB_ListAvalaibleImages.SetItemChecked(i, state);
        }

        private void cLB_MouseClick(object sender, MouseEventArgs e)
        {
            if (((sender as CheckedListBox).Items.Count > 0) && (e.Button == System.Windows.Forms.MouseButtons.Left))
                if (_multiSelect)
                {
                    int endSelect = (sender as CheckedListBox).IndexFromPoint(e.Location),
                        begSelect;
                    if (_oldSelectIndex > endSelect)
                    {
                        begSelect = endSelect;
                        endSelect = _oldSelectIndex;
                    }
                    else
                        begSelect = _oldSelectIndex;
                    for (int i = begSelect; i < endSelect; i++)
                        (sender as CheckedListBox).SetItemChecked(i, true);
                    _oldSelectIndex = endSelect;
                }
        }

        private void cLB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                _multiSelect = true;
        }

        private void cLB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                _multiSelect = false;
        }

        private void tbP_SelectLearnDataAndAddClassificator_Enter(object sender, EventArgs e)
        {
            cmB_Dimensionalitys.Items.Clear();
            cmB_Dimensionalitys.Items.AddRange(_collectionAvalaibleImages.Dimensions);
            if(cmB_Dimensionalitys.Items.Count > 0)
                cmB_Dimensionalitys.SelectedIndex = 0;
        }

        private void cLB_LearnImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            _drawerLearnIm.DrawIm((ImBinary)cLB_LearnImages.Items[cLB_LearnImages.SelectedIndex]);
            if (_currClassificator != null)
            {
                _drawerLearnIm.DrawBinaryPoints(_currClassificator.NumbersImportantProps, _colorSelectionImpProp);
            }
            _oldSelectIndex = cLB_LearnImages.SelectedIndex;
        }

        private void cmB_Dimensionalitys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmB_Dimensionalitys.Items.Count > 0)
            {
                string[] dim = cmB_Dimensionalitys.SelectedItem.ToString().Split('x');
                cLB_LearnImages.Items.Clear();
                cLB_LearnImages.Items.AddRange(_collectionAvalaibleImages.GetImBinarys(Convert.ToByte(dim[0]), Convert.ToByte(dim[1])).ToArray<ImBinary>());
                cLB_LearnImages.SelectedIndex = 0;
            }
        }

        private void btnCreateClassificator_Click(object sender, EventArgs e)
        {
            if (cLB_LearnImages.CheckedItems.Count > 0)
            {
                ImBinary[] selectLearnImages = new ImBinary[cLB_LearnImages.CheckedItems.Count];
                cLB_LearnImages.CheckedItems.CopyTo(selectLearnImages, 0);
                _classificators.Add(_currClassificator = DecisionTreeForImBinary.CreateInstance(selectLearnImages, DecisionTreeForImBinary.MethodBuild.CART));
                lblStatusCreateClassificator.ForeColor = Color.LimeGreen;
                lblStatusCreateClassificator.Text = _classificators.Count + "-й класифікатор успішно створено.";                

            }
            else
            {
                lblStatusCreateClassificator.ForeColor = Color.OrangeRed;
                lblStatusCreateClassificator.Text = "Оберіть образи зі списку вище!";                
            }
        }
    }
}
