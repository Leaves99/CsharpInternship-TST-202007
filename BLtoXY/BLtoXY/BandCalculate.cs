using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLtoXY
{
    class BandCalculate
    {
        public void BandCompute(double Num, double CooSys, double X1, double Y1,double L0, out double[] B, out double[] L)
        {
            //ZCalculate zCalculate = new ZCalculate();
            //初始化X，Y数组
            //X2 = new double[100];
            //Y2 = new double[100];
            B = new double[100];
            double[] l = new double[100];
            L = new double[100];
            double a, f1;
            a = 6378245;
            f1 = 1 / 298.3;
            //判断是那个坐标系，若三个坐标系都不是，则提示检查文件
            if (CooSys == 54)
            {
                a = 6378245;
                f1 = 1 / 298.3;
            }
            else if (CooSys == 80)
            {
                a = 6378140;
                f1 = 1 / 298.257;
            }
            else if (CooSys == 84)
            {
                a = 6378137;
                f1 = 1 / 298.257223563;
            }
            else
            {
                MessageBox.Show("对不起，请检查你的txt文件中的数据——" + Num + "," + CooSys + "," + X1 + "," + Y1);
            }
            //计算X2，Y2
            for (int i=0;i<100;i++)
            {
                double b, e1f ,	e2f;   //短半轴，极点处的子午线曲率半径，第一偏心率，第二偏心率
                double Bf, Yita2,N, M;
                Y1 = Y1 - 500000;//因为正算时是加了500km的
                X1 = X1 - 500000;
                //计算一些基本常量
                b = a * (1 - f1);//计算短半轴
                e1f = (a * a - b * b) / (a * a);//计算第一偏心率的平方
                e2f = e1f / (1 - e1f);//计算第二偏心率的平方
                double a0, a2, a4, a6, a8;//一些基本常量
                double m0, m2, m4, m6, m8;//一些基本常量
                //计算m0, m2, m4, m6, m8
                m0 = a * (1 - e1f);
                m2 = 1.5 * e1f * m0;
                m4 = 5 * e1f * m2;
                m6 = 7 * e1f * m4 / 6;
                m8 = 1.125 * e1f * m6;
                //计算a0, a2, a4, a6, a8
                a0 = m0 + m2 / 2 + 3 * m4 / 8 + 5 * m6 / 16 + 35 * m8 / 128;
                a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
                a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
                a6 = m6 / 32 + m8 / 16;
                a8 = m8 / 128;
                //迭代计算Bf
                double Bf1, Bfi0, Bfi1, FBfi;
                Bf1 = X1 / a0;
                Bfi0 = Bf1;
                Bfi1 = 0;
                FBfi = 0;
                int n = 0;
                //开始迭代
                {
                    do
                    {
                        n = 0;
                        FBfi = -a2 * Math.Sin(2 * Bfi0) / 2 + a4 * Math.Sin(4 * Bfi0) / 4 - a6 * Math.Sin(6 * Bfi0) / 6 + a8 * Math.Sin(8 * Bfi0) / 8;
                        Bfi1 = (X1 - FBfi) / a0;
                        if (Math.Abs(Bfi1 - Bfi0) > 0.00000000001)
                        {
                            n = 1;
                            Bfi0 = Bfi1;
                        }
                    }
                    while (n == 1);
                }

                Bf = Bfi1;
                double t, t2, SB, CB;//简化计算的一些参数
                t = Math.Tan(Bf); //tanB
                t2 = t * t;//tanB的平方
                SB = Math.Sin(Bf);//SinB
                CB = Math.Cos(Bf);//CosB
                N = a / Math.Sqrt(1 - e1f * SB * SB);//计算子午圈曲率半径N
                M = a * (1 - e1f) / Math.Pow(Math.Sqrt(1 - e1f * SB * SB), 3);//计算M
                Yita2 = e2f * CB * CB;
                B[i] = Bf - t * Y1 * Y1 / (2 * M * N)
                    + t * (5 + 3 * t2 + Yita2 - 9 * Yita2 * t2) * Math.Pow(Y1, 4) / (24 * M * Math.Pow(N, 3))
                    - t * (61 + 90 * t2 + 45 * t2 * t2) * Math.Pow(Y1, 6) / (720 * M * Math.Pow(N, 5));
                l[i] = Y1 / (N * CB) - Math.Pow(Y1, 3) * (1 + 2 * t2 + Yita2) / (6 * Math.Pow(N, 3) * CB)
                    + Math.Pow(Y1, 5) * (5 + 28 * t2 + 24 * t2 * t2 + 6 * Yita2 + 8 * Yita2 * t2) / (120 * CB * Math.Pow(N, 5));
                L[i] = l[i] + L0;
                //zCalculate.Compute(Num, CooSys, B[i], L[i], out double[] X, out double[] Y);
                //X2[i] = X[i];
                //Y2[i] = Y[i];
            }
        }
    }
}
