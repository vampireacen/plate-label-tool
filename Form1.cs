using ImageLabel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace License_Plate
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        int index = 0;  // 当前图片 index
        int plate_num = 0; //当前车牌
        ImageLib imglib = new ImageLib();
        int enter_time = 0;
        string temp_plate;
        public Form1()
        {
            InitializeComponent();
            InitDataGridView();
            //KeyBoardHook k_hook = new KeyBoardHook();
            //k_hook.OnKeyUpEvent += new KeyEventHandler(KeyUp);//关联处理函数
            ////k_hook.OnKeyUpEvent += new KeyEventHandler(KeyUp);
            //k_hook.Start();
        }
        public new void KeyUpTest(object sender, KeyEventArgs e) //这是我用的，你自己处理自己需要的
        {
            
            try
            {
                if (this.PlateText.Focused == false)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D:
                            if (NextImageButton.Enabled == true)
                                NextImageButton_Click(sender, e);
                            break;
                        case Keys.A:
                            if (PreImgaeButton.Enabled == true)
                                PreImgaeButton_Click(sender, e);
                            break;
                        case Keys.C:
                            if (NextPlateButton.Enabled == true)
                                NextPlateButton_Click(sender, e);
                            break;
                        case Keys.Z:
                            if (PrePlateButton.Enabled == true)
                                PrePlateButton_Click(sender, e);
                            break;
                        case Keys.Q:
                            if (CopyButton.Enabled == true && PlateText.ReadOnly == false)
                                CopyButton_Click(sender, e);
                            break;
                        case Keys.E:
                            if (ClearButton.Enabled == true && PlateText.ReadOnly == false)
                                ClearButton_Click(sender, e);
                            break;
                        case Keys.Enter:
                            if (SaveButton.Enabled == true)
                                SaveButton_Click(sender, e);
                            break;
                    }
                }
                else
                {
                    if (e.KeyCode.Equals(Keys.Enter))
                    {
                        SaveButton_Click(sender, e);
                        enter_time++;
                        MessageBox.Show("Saved");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }


        }


        private void ImagePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBDialog = new FolderBrowserDialog();//创建FolderBrowserDialog对象
            if (FBDialog.ShowDialog() == DialogResult.OK)//判断是否选择了文件夹
            {

                string path = FBDialog.SelectedPath;//记录选择的文件夹
                imglib.ImageFromDirector(path);
                
                ImagePathText.Text = imglib.directorPath;//用textBox记录获取的路径
                NumberText.Text = "0";
                PictureBox.Image = Image.FromFile(imglib.directorPath + imglib.imgNameList[0]);

            }
            if (imglib.isChanged == 1)
            {
                //imglib.SaveLabel();
                PictureBox_Draw(index);
            }
            
        }
        private void FilePathButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    imglib.labelFilePath = openFileDialog.FileName;
                    FilePathText.Text = imglib.labelFilePath;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string line;

                        // 从文件读取并显示行，直到文件的末尾 
                        while ((line = reader.ReadLine()) != null)
                        {
                            imglib.AddLabel(line);
                        }
                    }
                    imglib.isChanged = 1;
                    if (imglib.imgCount != 0)
                    {
                        //imglib.SaveLabel();
                        NumberText.Text = 0.ToString();
                        JumpButton_Click(sender, e);
                        StartDataGridView();
                    }
                }
            }
        }
        private void PlatePathButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    imglib.plateFilePath = openFileDialog.FileName;
                    PlatePathText.Text = imglib.plateFilePath;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string line = reader.ReadLine();
                        string image_index = "";
                        int plate_index = 0;
                        while (line!= null && line != "")
                        {
                            string img_index = line.Split(' ')[0];
                            int length = line.Split(' ').Length;
                            string plate = line.Split(' ')[length-1];

                            if (img_index.Equals(image_index))
                            {
                                plate_index++;
                            }
                            else 
                            {
                                plate_index = 0;  
                            }
                            imglib.AddPlate(img_index, plate_index, plate);
                            image_index = img_index;
                            line = reader.ReadLine();

                        }
                    }
                    imglib.isChanged = 1;
                    if (imglib.imgCount != 0)
                    {
                        //imglib.SavePlate();
                        NumberText.Text = 0.ToString();
                        JumpButton_Click(sender, e);
                        StartDataGridView();
                    }
                }
            }
        }
        private void PictureBox_Draw(int picIndex)
        {
            if (!imglib.boxDict.TryGetValue(imglib.imgNameList[picIndex], out var boxList))
                return;
            for (int i = 0; i < boxList.Count; i++)
            {
                Box box = boxList[i];
            }
        }

        private void PictureBox_DrawRect(int no, string label, int x0, int y0, int x1, int y1, Color color)
        {
            Image img = PictureBox.Image;
            Graphics g = Graphics.FromImage(img);
            Pen pen = new Pen(color,5);
            g.DrawRectangle(pen, new Rectangle(x0, y0, x1 - x0, y1 - y0));

            // Create string to draw.
            string drawString = no.ToString();
            //string drawString = no.ToString() + label;

            // Create font and brush.
            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            // Create point for upper-left corner of drawing.
            float x = (float)(x0 + 1.0);
            float y = (float)(y0 + 1.0);

            g.DrawString(drawString, drawFont, drawBrush, x, y);
            g.Dispose();
            PictureBox.Image = img;
        }

        private void InitDataGridView()
        {
            DataGridView.AllowUserToAddRows = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn
            {
                Name = "No",
                HeaderText = "ID",
                Width = 45,
                ReadOnly = true
            };
            DataGridView.Columns.Insert(0, col1);

            DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn
            {
                Name = "label",
                HeaderText = "标签",
                Width = 123
            };
            foreach (string label in imglib.classList)
            {
                col2.Items.Add(label);
            }

            col2.DisplayIndex = 1;
            DataGridView.Columns.Insert(1, col2);

            DataGridView.CellValueChanged -= DataGridView_CellValueChanged;//line added after solution given
            DataGridView.CellValueChanged += DataGridView_CellValueChanged;//line added after solution given
        }
        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            var currentBox = imglib.GetBoxListByIndex(index)[rowIndex];
            string newValue = DataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            if (DataGridView.Columns[columnIndex].Name == "label" && !currentBox.label.Equals(newValue))
            {
                imglib.boxDict[imglib.imgNameList[index]][rowIndex].label = newValue;
            }
            PictureBox_Draw(index);
        }
        private void StartDataGridView()
        {
            var boxList = imglib.GetBoxListByIndex(index);
            DataGridView.Rows.Clear();
            for (int i = 0; i < boxList.Count; i++)
            {
                string label = boxList[i].label;
                DataGridView.Rows.Add(i, imglib.classList.Contains(label) ? label : imglib.classList[0]);
            }

        }
        private void PreImgaeButton_Click(object sender, EventArgs e)
        {
            if (index >= 1)
            {
                NumberText.Text = (index - 1).ToString();
                JumpButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("当前图片为第一张");
            }
            NextImageButton.Enabled = true;
            plate_num = 0;
        }
        private void NextImageButton_Click(object sender, EventArgs e)
        {
            if (index < imglib.imgCount)
            {
                NumberText.Text = (index + 1).ToString();
                JumpButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("当前图片为最后一张");
            }
            PreImgaeButton.Enabled = true;
            plate_num = 0;
        }
        private void JumpButton_Click(object sender, EventArgs e)
        {
            //imglib.SaveLabel();
            plate_num = 0;
            try
            {
                int jump = int.Parse(NumberText.Text);
                if (jump >= 0 && jump < imglib.imgCount)
                {
                    index = jump;
                    ReloadPicture();
                }
                else
                {
                    throw new IndexOutOfRangeException("标号超出限制！");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }


        private void ReloadPicture()
        {
            if (PictureBox.Image != null)
            {
                PictureBox.Image.Dispose();
            }
            if (index >= imglib.imgCount || index < 0)
                return;
            PictureBox.Image = Image.FromFile(imglib.directorPath + imglib.imgNameList[index]);

            int imgCount = imglib.imgNameList.Count;
            float percent = index / (float)imgCount * 100;
            string process = index.ToString() + "/" + imgCount.ToString() + "（" + percent.ToString("0.0") + "%)  ";
            //LabelFilename.Text = process + "./" + imglib.imgNameList[index];
            plate_num = 0;
            PictureBox_Draw(index);
            StartDataGridView();
            ClipImage();
        }

        private void ClipImage() 
        {
            if (PlatePictrueBox.Image != null)
            {
                PlatePictrueBox.Image.Dispose();
            }
            PlateText.ReadOnly = false;
            SaveButton.Enabled = true;
            ClearButton.Enabled = true;
            UnclearButton.Enabled = true;
            try
            {
                bitmap = new Bitmap(imglib.directorPath + imglib.imgNameList[index]);
                var boxList = imglib.GetBoxListByIndex(index);
                PictureBox.Image = bitmap;
                Bitmap new_bitmap = new Bitmap(boxList[0].p2.X - boxList[0].p1.X + 1, boxList[0].p2.Y - boxList[0].p1.Y + 1);
                for (int m = 0, i = boxList[0].p1.X; i <= boxList[0].p2.X; i++, m++)
                {
                    for (int n = 0, j = boxList[0].p1.Y; j <= boxList[0].p2.Y; j++, n++)
                    {
                        new_bitmap.SetPixel(m, n, bitmap.GetPixel(i, j));
                    }
                }
                PlatePictrueBox.Image = new_bitmap;
                var box = boxList[0];
                PlateText.Text = box.plate;
                Color color = Color.FromArgb(255,0,0);
                PictureBox_DrawRect(0, box.label, box.p1.X, box.p1.Y, box.p2.X, box.p2.Y, color);
                if (boxList.Count > 1)
                {
                    NextPlateButton.Enabled = true;
                    NextImageButton.Enabled = false;
                }
                else 
                {
                    PrePlateButton.Enabled = false;
                    NextPlateButton.Enabled = false;
                }
                
            }
            catch
            {
                PrePlateButton.Enabled = false;
                NextPlateButton.Enabled = false;
                PlateText.Text = "当前图片暂无车牌";
                PlateText.ReadOnly = true;
                SaveButton.Enabled = false;
                ClearButton.Enabled = false;
                UnclearButton.Enabled = false;
            }
            
        }

        private void NextPlateButton_Click(object sender, EventArgs e)
        {
            plate_num++;
            PrePlateButton.Enabled = true;
            bitmap = new Bitmap(imglib.directorPath + imglib.imgNameList[index]);
            PictureBox.Image = bitmap;
            var boxList = imglib.GetBoxListByIndex(index);
            Bitmap new_bitmap = new Bitmap(boxList[plate_num].p2.X - boxList[plate_num].p1.X + 1, boxList[plate_num].p2.Y - boxList[plate_num].p1.Y + 1);
            for (int m = 0, i = boxList[plate_num].p1.X; i <= boxList[plate_num].p2.X; i++, m++)
            {
                for (int n = 0, j = boxList[plate_num].p1.Y; j <= boxList[plate_num].p2.Y; j++, n++)
                {
                    new_bitmap.SetPixel(m, n, bitmap.GetPixel(i, j));
                }
            }
            PlatePictrueBox.Image = new_bitmap;
            var box = boxList[plate_num];
            Color color = Color.FromArgb(255, 0, 0);
            PictureBox_DrawRect(plate_num, box.label, box.p1.X, box.p1.Y, box.p2.X, box.p2.Y, color);
            PlateText.Text = box.plate;
            //this.DataGridView.BindingContext[this.DataGridView.DataSource].Position = plate_num;
            this.DataGridView.CurrentCell = DataGridView.Rows[plate_num].Cells[0];
            if (plate_num == boxList.Count - 1)
            {
                NextPlateButton.Enabled = false;
                NextImageButton.Enabled = true;
            }
            else
            {
                NextPlateButton.Enabled = true;
                PrePlateButton.Enabled = true;
            }
            //saveButton();
        }

        private void PrePlateButton_Click(object sender, EventArgs e)
        {
            plate_num--;
            NextPlateButton.Enabled = true;
            bitmap = new Bitmap(imglib.directorPath + imglib.imgNameList[index]);
            PictureBox.Image = bitmap;
            var boxList = imglib.GetBoxListByIndex(index);
            Bitmap new_bitmap = new Bitmap(boxList[plate_num].p2.X - boxList[plate_num].p1.X + 1, boxList[plate_num].p2.Y - boxList[plate_num].p1.Y + 1);
            for (int m = 0, i = boxList[plate_num].p1.X; i <= boxList[plate_num].p2.X; i++, m++)
            {
                for (int n = 0, j = boxList[plate_num].p1.Y; j <= boxList[plate_num].p2.Y; j++, n++)
                {
                    new_bitmap.SetPixel(m, n, bitmap.GetPixel(i, j));
                }
            }
            PlatePictrueBox.Image = new_bitmap;
            var box = boxList[plate_num];
            Color color = Color.FromArgb(255, 0, 0);
            PictureBox_DrawRect(plate_num, box.label, box.p1.X, box.p1.Y, box.p2.X, box.p2.Y, color);
            PlateText.Text = box.plate;
            this.DataGridView.CurrentCell = DataGridView.Rows[plate_num].Cells[0];
            if (plate_num == 0)
            {
                PrePlateButton.Enabled = false;
            }
            else
            {
                NextPlateButton.Enabled = true;
                PrePlateButton.Enabled = true;
            }
            //saveButton();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string value = PlateText.Text;
            int plate_index = plate_num; 
            var boxList = imglib.GetBoxListByIndex(index);
            var box = boxList[plate_index];
            string img_index = box.img;
            imglib.AddPlate(img_index, plate_index, value);
            temp_plate = value;
            LeastPlateText.Text = temp_plate;
            JumpNext(sender, e);
        }
        private void ResultButton_Click(object sender, EventArgs e)
        {
            imglib.SavePlate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if(PlateText.ReadOnly==false)
                this.PlateText.Text = null;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            PlateText.Text = LeastPlateText.Text;
        }

        private void UnclearButton_Click(object sender, EventArgs e)
        {
            
            string value = "Unclear";
            int plate_index = plate_num;
            var boxList = imglib.GetBoxListByIndex(index);
            var box = boxList[plate_index];
            string img_index = box.img;
            imglib.AddPlate(img_index, plate_index, value);
            PlateText.Text = "Unclear";
            JumpNext(sender, e);
        }
        private void JumpNext(object sender, EventArgs e) 
        {
            var boxList = imglib.GetBoxListByIndex(index);
            var box = boxList[plate_num];
            if (plate_num == boxList.Count - 1)
            {
                NextImageButton_Click(sender, e);
            }
            else 
            {
                NextPlateButton_Click(sender, e);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.D&&PlateText.Focused==false)
                    if (NextImageButton.Enabled == true)
                        NextImageButton_Click(sender, e);
                if (e.KeyCode == Keys.A && PlateText.Focused == false)
                    if (PreImgaeButton.Enabled == true)
                        PreImgaeButton_Click(sender, e);
                if (e.KeyCode == Keys.C && PlateText.Focused == false)
                    if (NextPlateButton.Enabled == true)
                        NextPlateButton_Click(sender, e);
                if (e.KeyCode == Keys.Z && PlateText.Focused == false)
                    if (PrePlateButton.Enabled == true)
                        PrePlateButton_Click(sender, e);
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Q)
                    if (CopyButton.Enabled == true && PlateText.ReadOnly == false)
                        CopyButton_Click(sender, e);
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
                    if (ClearButton.Enabled == true && PlateText.ReadOnly == false)
                        ClearButton_Click(sender, e);
                if (e.KeyCode == Keys.Enter)
                    if (SaveButton.Enabled == true)
                        SaveButton_Click(sender, e);
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
                    if (UnclearButton.Enabled == true)
                        UnclearButton_Click(sender, e);
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                    ResultButton_Click(sender, e);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
