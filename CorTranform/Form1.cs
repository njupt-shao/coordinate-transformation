using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CorTranform
{
    public partial class Form1 : Form
    {
        string _inputPath;
        string _outputPath;

        public Form1()
        {
            InitializeComponent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //37.065 128.543 128.54944656269413 37.07113427883019
            this.textBox_bd.Text = "";
            this.textBox_hx.Text = "";
            this.textBox_wgs84.Text = "";
        }



        private Cor readFromTextBox(string text)
        {
            Cor cor;
            cor.lat = 0;
            cor.lng = 0;
            string[] vs = text.Split(new char[] { ',', ' ', '\t' });

            if (vs.Length < 2)
            {
                return cor;
            }
            try
            {
                cor.lng = Convert.ToDouble(vs[0]);
                cor.lat = Convert.ToDouble(vs[1]);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return cor;
        }

        private string printCor(Cor cor)
        {
            string lng = Convert.ToString(cor.lng);
            string lat = Convert.ToString(cor.lat);
            return lng + ',' + lat;
        }

        private void bd2hx_Click(object sender, EventArgs e)
        {
            Cor bd;
            bd.lat = 0;
            bd.lng = 0;
            bd = readFromTextBox(this.textBox_bd.Text);
            Cor hx = Transformer.bd09togcj02(bd);
            string hxStr = printCor(hx);
            // MessageBox.Show(hxStr);
            this.textBox_hx.Text = hxStr;
        }
        private void bd2wgs84_Click(object sender, EventArgs e)
        {
            Cor bd;
            bd.lat = 0;
            bd.lng = 0;
            bd = readFromTextBox(this.textBox_bd.Text);
            Cor hx = Transformer.bd09togcj02(bd);
            Cor wgs84 = Transformer.gcj02towgs84(hx);
            string wgs84Str = printCor(wgs84);
            //MessageBox.Show(wgs84Str);
            this.textBox_wgs84.Text = wgs84Str;
        }
        private void hx2wgs84_Click(object sender, EventArgs e)
        {
            Cor hx;
            hx.lat = 0;
            hx.lng = 0;
            hx = readFromTextBox(this.textBox_hx.Text);
            Cor wgs84 = Transformer.gcj02towgs84(hx);
            string wgs84Str = printCor(wgs84);
            //MessageBox.Show(wgs84Str);
            this.textBox_wgs84.Text = wgs84Str;
        }



        private void hx2bd_Click(object sender, EventArgs e)
        {
            Cor hx;
            hx.lat = 0;
            hx.lng = 0;
            hx = readFromTextBox(this.textBox_hx.Text);
            Cor bd = Transformer.gcj02tobd09(hx);
            string bdStr = printCor(bd);
            //MessageBox.Show(bdStr);
            this.textBox_bd.Text = bdStr;
        }

        private void wgs84tobd_Click(object sender, EventArgs e)
        {
            Cor wgs84;
            wgs84.lat = 0;
            wgs84.lng = 0;
            wgs84 = readFromTextBox(this.textBox_wgs84.Text);
            Cor hx = Transformer.wgs84togcj02(wgs84);
            Cor bd = Transformer.gcj02tobd09(hx);
            string bdStr = printCor(bd);
            //MessageBox.Show(bdStr);
            this.textBox_bd.Text = bdStr;

        }

        private void wgs84toHx_Click(object sender, EventArgs e)
        {
            Cor wgs84;
            wgs84.lat = 0;
            wgs84.lng = 0;
            wgs84 = readFromTextBox(this.textBox_wgs84.Text);
            Cor hx = Transformer.wgs84togcj02(wgs84);
            string hxStr = printCor(hx);
            //MessageBox.Show(hxStr);
            this.textBox_hx.Text = hxStr;
        }

        private void selectCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.csv)|*.csv";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                _inputPath = file;
                _outputPath = Path.Combine(Path.GetDirectoryName(_inputPath),Path.GetFileNameWithoutExtension(_inputPath)+'_'+ GetTimeStamp() + ".csv");
                this.label4.Text = "输出：" + _outputPath;

            }

        }
        public string GetTimeStamp()
        {

            return DateTime.Now.ToString("yyyyMMddhhmmss");
        }

        private void bd2hx_2_Click(object sender, EventArgs e)
        {
            this.label5.Text = bd2hx_2.Text;
        }

        private void bd2W84_Click(object sender, EventArgs e)
        {
            this.label5.Text = bd2W84.Text;
        }

        private void hx2W84_Click(object sender, EventArgs e)
        {
            this.label5.Text = hx2W84.Text;
        }

        private void hx2bd_2_Click(object sender, EventArgs e)
        {
            this.label5.Text = hx2bd_2.Text;
        }

        private void w84tobd_Click(object sender, EventArgs e)
        {
            this.label5.Text = w84tobd.Text;
        }

        private void w84tohx_Click(object sender, EventArgs e)
        {
            this.label5.Text = w84tohx.Text;
        }

        private void start_t_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_outputPath) || string.IsNullOrEmpty(_outputPath))
            {
                MessageBox.Show("请选择输入文件");
                return;
            }
            if (string.IsNullOrEmpty(this.label5.Text) || string.IsNullOrWhiteSpace(this.label5.Text))
            {
                MessageBox.Show("请选择输入类型");
                return;
            }
            string _type = this.label5.Text;


            try
            {
                var lineCount = File.ReadLines(_inputPath).Count();
                this.label8.Text = "总条数：" + Convert.ToString(lineCount);
                FileStream fs = new FileStream(_inputPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                FileStream fs1 = new FileStream(_outputPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                StreamWriter sr1 = new StreamWriter(fs1);


                string strLine;
                long finished = 0;
                while ((strLine = sr.ReadLine()) != null)
                {

                    Cor cor = readFromTextBox(strLine);
                    Cor transedCor = Transformer.transform(cor, _type);
                    string newCorStr = printCor(transedCor);
                    finished++;
                    sr1.WriteLine(newCorStr);
                }
                this.label9.Text = "已完成："+ Convert.ToString(finished);
                sr.Close();
                fs.Close();
                sr1.Close();
                fs1.Close();

            }
            catch (Exception)
            {

                throw;
            }
            myInit();


        }

        private void myInit()
        {
            _inputPath = "";
            _outputPath = "";
    
        }
    }
}
