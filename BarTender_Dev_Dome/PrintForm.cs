using Seagull.BarTender.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BarTender_Dev_Dome
{
    public partial class PrintForm : Form
    {
        private string _bmp_path = Application.StartupPath + @"\exp.jpg";
        private string _btw_path = "";
        string _PrinterName = "";
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            Printers printers = new Printers();
            foreach (Printer printer in printers)
            {
                printer_comboBox.Items.Add(printer.PrinterName);
            }

            if (printers.Count > 0)
            {
                // Automatically select the default printer.
                printer_comboBox.SelectedItem = printers.Default.PrinterName;
            }
        }

        private void openFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//多个文件
            dialog.Title = "请选择要烧录的文件";
            dialog.Filter = "bwt文件(*.btw)|*.btw";
            dialog.InitialDirectory = Application.StartupPath;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _btw_path = dialog.FileName;
                fileNametBox.Text = dialog.SafeFileName;
                fileNametBox.BackColor = Color.LightGreen;

                pictureBox.Image = null;
                using (Engine btEngine = new Engine(true))
                {
                    LabelFormatDocument labelFormat = btEngine.Documents.Open(_btw_path);

                    if (labelFormat != null)
                    {
                        Seagull.BarTender.Print.Messages m;
                        labelFormat.ExportPrintPreviewToFile(Application.StartupPath,  @"\exp.bmp", ImageType.JPEG, Seagull.BarTender.Print.ColorDepth.ColorDepth24bit, new Resolution(300,300), System.Drawing.Color.White, OverwriteOptions.Overwrite, true, true, out m);
                        labelFormat.ExportImageToFile(_bmp_path, ImageType.JPEG, Seagull.BarTender.Print.ColorDepth.ColorDepth24bit, new Resolution(300, 300), OverwriteOptions.Overwrite);

                        Image image = Image.FromFile(_bmp_path);
                        Bitmap NmpImage = new Bitmap(image);
                        pictureBox.Image = NmpImage;
                        image.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("生成图片错误", "操作提示");
                    }
                }
            }
        }

        private void printer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PrinterName = printer_comboBox.Text;
        }

        void PrintBar(bool isPreView = false)
        {
            if (_btw_path.Length < 5)
            {
                fileNametBox.BackColor = Color.Red;
                return;
            }
            using (Engine btEngine = new Engine(true))
            {
                LabelFormatDocument labelFormat = btEngine.Documents.Open(_btw_path);

                try
                {
                    labelFormat.SubStrings.SetSubString("name", name_textBox.Text);
                    labelFormat.SubStrings.SetSubString("age", age_textBox.Text);
                    labelFormat.SubStrings.SetSubString("ID", id_textBox.Text);
                    labelFormat.SubStrings.SetSubString("code", num_textBox.Text);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("修改内容出错 " + ex.Message, "操作提示");
                }

                if (labelFormat != null)
                {
                    //Generate a thumbnail for it.
                    labelFormat.ExportImageToFile(_bmp_path, ImageType.BMP, Seagull.BarTender.Print.ColorDepth.ColorDepth24bit, new Resolution(407, 407
                        ), OverwriteOptions.Overwrite);

                    System.Drawing.Image image = System.Drawing.Image.FromFile(_bmp_path);
                    Bitmap NmpImage = new Bitmap(image);
                    pictureBox.Image = NmpImage;
                    image.Dispose();
                }
                else
                {
                    MessageBox.Show("生成图片错误", "操作提示");
                }

                if (isPreView) return;

                if (_PrinterName != "")
                {
                    labelFormat.PrintSetup.PrinterName = _PrinterName;
                    labelFormat.Print("BarPrint" + DateTime.Now, 3 * 1000);
                }
                else
                {
                    MessageBox.Show("请先选择打印机", "操作提示");
                }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintBar();
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            PrintBar(true);
        }
    }
}
