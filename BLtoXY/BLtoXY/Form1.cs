using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLtoXY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangePages_Click(object sender, EventArgs e)
        {
            int icnt = tabControl1.TabPages.Count;//获得控件的总页数
            if (tabControl1.SelectedIndex < icnt - 1)
                tabControl1.SelectedIndex++;
            else if (tabControl1.SelectedIndex == icnt - 1)
                tabControl1.SelectedIndex = 0;            
        }
        //打开文件并将文件导入到第一个datagridview控件中
        private void OpenBLTXT_Click(object sender, EventArgs e)
        {
            //打开文件
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "文本文件|*.txt";
            //读取文本信息
            if ( dlg.ShowDialog()==DialogResult.OK)
            {
                //新建一个datatable用于保存读入的数据
                DataTable dt = new DataTable();
                //给dudatatable添加4个列标题
                dt.Columns.Add("代号", typeof(String));
                dt.Columns.Add("坐标系", typeof(String));
                dt.Columns.Add("B", typeof(String));
                dt.Columns.Add("L", typeof(String));
                //读入文件
                using (StreamReader reader = new StreamReader(dlg.FileName, Encoding.Default))
                {
                    while(!reader.EndOfStream)
                    {
                        //将每行数据用“,”分成4段
                        string[] data = reader.ReadLine().Split(',');
                        //将读出的数据分段，分别存入4个对应的列中
                        DataRow dr = dt.NewRow();
                        dr[0] = data[0];
                        dr[1] = data[1];
                        dr[2] = data[2];
                        dr[3] = data[3];
                        //将这行数据加入到datatable中
                        dt.Rows.Add(dr);
                    }
                }
                //将datatable绑定到dataGridView1上
                this.dataGridView1.DataSource = dt;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string[] sNum = new string[100];
            string[] sCooSys = new string[100];
            string[] sB = new string[100];
            string[] sL = new string[100];
            double[] Num = new double[100];
            double[] CooSys = new double[100];
            double[] B = new double[100];
            double[] L = new double[100];
            string[] sX = new string[100];
            string[] sY = new string[100];
            //新建一个datatable用于保存读入的数据
            DataTable dt2 = new DataTable();
            //给dt2添加4个列标题
            dt2.Columns.Add("代号", typeof(String));
            dt2.Columns.Add("坐标系", typeof(String));
            dt2.Columns.Add("X", typeof(String));
            dt2.Columns.Add("Y", typeof(String));
            for (int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                for (int j=0;j<dataGridView1.Columns.Count;j++)
                {
                    //str[i,j]= dataGridView1.Rows[i].Cells[j].Value.ToString();
                    //将代号放在一个数组中
                    if (j == 0)
                    {
                        sNum[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        string ssNum = sNum[i];
                        Num[i] = double.Parse(ssNum);
                    }
                    //将坐标系放在一个数组中
                    if (j == 1)
                    {
                        sCooSys[i] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string ssCooSys = sCooSys[i];
                        CooSys[i] = double.Parse(ssCooSys);
                    }
                    //将B(纬度)放在一个数组中
                    if (j == 2)
                    {
                        sB[i] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string ssB = sB[i];
                        B[i] = double.Parse(ssB);
                    }
                    //将L(经度)代号放在一个数组中
                    if (j == 3)
                    {
                        sL[i] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        string ssL = sL[i];
                        L[i] = double.Parse(ssL);
                    }      
                }
                //调用Calucate中的Compute方法
                ZCalculate cal = new ZCalculate();
                cal.Compute(Num[i],CooSys[i],B[i],L[i],out double[] X, out double[] Y);
                //将X，Y装换成string方便在datagridview2中表示
                sX[i]=X[i].ToString();
                sY[i]=Y[i].ToString();
                DataRow dr2 = dt2.NewRow();
                dr2[0] = Num[i] ;
                dr2[1] = CooSys[i];
                dr2[2] = X[i];
                dr2[3] = Y[i];
                //MessageBox.Show(X[i] + "，" + Y[i]);
                dt2.Rows.Add(dr2);  
            }
            this.dataGridView2.DataSource = dt2;
        }

        private void SaveTXT_Click(object sender, EventArgs e)
        {
            //保存数据
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "文本文件|*.txt";
            sf.AddExtension = true;//如果没有扩展名，则自动追加
            if(sf.ShowDialog()==DialogResult.OK)
            {
                //实例化一个文件流与写入文件相关联
                FileStream fs = new FileStream(sf.FileName, FileMode.Create);
                //实例化一个streamwriter与fs先关联
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                if(this.dataGridView2.Rows.Count<1)
                {
                    MessageBox.Show("没有数据，保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            sw.WriteLine(this.dataGridView2.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                }
                //清空缓存区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("退出窗口");
            this.Close();
        }

        private void OpenXYTxt_Click(object sender, EventArgs e)
        {
            //打开文件
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "文本文件|*.txt";
            //读取文本信息
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //新建一个datatable用于保存读入的数据
                DataTable dt3 = new DataTable();
                //给dudatatable添加5个列标题
                dt3.Columns.Add("代号", typeof(String));
                dt3.Columns.Add("坐标系", typeof(String));
                dt3.Columns.Add("X1", typeof(String));
                dt3.Columns.Add("Y1", typeof(String));
                dt3.Columns.Add("L0", typeof(String));
                //读入文件
                using (StreamReader reader = new StreamReader(dlg.FileName, Encoding.Default))
                {
                    while (!reader.EndOfStream)
                    {
                        //将每行数据用“,”分成4段
                        string[] data = reader.ReadLine().Split(',');
                        //将读出的数据分段，分别存入4个对应的列中
                        DataRow dr3 = dt3.NewRow();
                        dr3[0] = data[0];
                        dr3[1] = data[1];
                        dr3[2] = data[2];
                        dr3[3] = data[3];
                        dr3[4] = data[4];
                        //将这行数据加入到datatable中
                        dt3.Rows.Add(dr3);
                    }
                }
                //将datatable绑定到dataGridView1上
                this.dataGridView3.DataSource = dt3;
            }
        }

        private void BandChange_Click(object sender, EventArgs e)
        {
            string[] sNum = new string[100];
            string[] sCooSys = new string[100];
            string[] sX1 = new string[100];
            string[] sY1 = new string[100];
            string[] sL0 = new string[100];
            double[] Num = new double[100];
            double[] CooSys = new double[100];
            double[] X1 = new double[100];
            double[] Y1 = new double[100];
            double[] L0 = new double[100];
            string[] sX2 = new string[100];
            string[] sY2 = new string[100];
            //新建一个datatable用于保存读入的数据
            DataTable dt4 = new DataTable();
            //给dt4添加4个列标题
            dt4.Columns.Add("代号", typeof(String));
            dt4.Columns.Add("坐标系", typeof(String));
            dt4.Columns.Add("X2", typeof(String));
            dt4.Columns.Add("Y2", typeof(String));
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    //str[i,j]= dataGridView1.Rows[i].Cells[j].Value.ToString();
                    //将代号放在一个数组中
                    if (j == 0)
                    {
                        sNum[i] = dataGridView3.Rows[i].Cells[0].Value.ToString();
                        string ssNum = sNum[i];
                        Num[i] = double.Parse(ssNum);
                    }
                    //将坐标系放在一个数组中
                    if (j == 1)
                    {
                        sCooSys[i] = dataGridView3.Rows[i].Cells[1].Value.ToString();
                        string ssCooSys = sCooSys[i];
                        CooSys[i] = double.Parse(ssCooSys);
                    }
                    //将X1放在一个数组中
                    if (j == 2)
                    {
                        sX1[i] = dataGridView3.Rows[i].Cells[2].Value.ToString();
                        string ssX1 = sX1[i];
                        X1[i] = double.Parse(ssX1);
                    }
                    //将Y1放在一个数组中
                    if (j == 3)
                    {
                        sY1[i] = dataGridView3.Rows[i].Cells[3].Value.ToString();
                        string ssY1 = sY1[i];
                        Y1[i] = double.Parse(ssY1);
                    }
                    if (j == 4)
                    {
                        sL0[i] = dataGridView3.Rows[i].Cells[3].Value.ToString();
                        string ssL0 = sL0[i];
                        L0[i] = double.Parse(ssL0);
                    }
                }
                //调用Calucate中的Compute方法
                BandCalculate band = new BandCalculate();
                band.BandCompute(Num[i], CooSys[i], X1[i], Y1[i],L0[i], out double[] B, out double[] L);
                ZCalculate zCalculate = new ZCalculate();
                zCalculate.Compute(Num[i], CooSys[i], B[i], L[i], out double[] X2, out double[] Y2);
                //将X2，Y2装换成string方便在datagridview4中表示
                sX2[i] = X2[i].ToString();
                sY2[i] = Y2[i].ToString();
                DataRow dr4 = dt4.NewRow();
                dr4[0] = Num[i];
                dr4[1] = CooSys[i];
                dr4[2] = sX2[i];
                dr4[3] = sY2[i];
                dt4.Rows.Add(dr4);
            }
            this.dataGridView4.DataSource = dt4;
        }

        private void SaveXYTxt_Click(object sender, EventArgs e)
        {
            //保存数据
            SaveFileDialog sf2 = new SaveFileDialog();
            sf2.Filter = "文本文件|*.txt";
            sf2.AddExtension = true;//如果没有扩展名，则自动追加
            if (sf2.ShowDialog() == DialogResult.OK)
            {
                //实例化一个文件流与写入文件相关联
                FileStream fs2 = new FileStream(sf2.FileName, FileMode.Create);
                //实例化一个streamwriter与fs先关联
                StreamWriter sw2 = new StreamWriter(fs2);
                //开始写入
                if (this.dataGridView4.Rows.Count < 1)
                {
                    MessageBox.Show("没有数据，保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView3.Columns.Count-1; j++)
                        {
                            sw2.WriteLine(this.dataGridView4.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                }
                //清空缓存区
                sw2.Flush();
                //关闭流
                sw2.Close();
                fs2.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void ExitAll_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("退出窗口");
            this.Close();
        }
    }
}
