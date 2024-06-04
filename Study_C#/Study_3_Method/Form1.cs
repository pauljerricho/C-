using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_3_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbox1.Text);
            int iNumB = int.Parse(tbox2.Text);

            // int iResult = iNumA + iNumB;
            // tboxResult.Text = iResult.ToString();

            tboxResult.Text = fPlus(iNumA, iNumB).ToString(); // 숫자 -> 문자
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbox1.Text);
            int iNumB = int.Parse(tbox2.Text);

            // int iResult = iNumA - iNumB;
            // tboxResult.Text = iResult.ToString();

            tboxResult.Text = fMinus(iNumA, iNumB).ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbox1.Text);
            int iNumB = int.Parse(tbox2.Text);

            // int iResult = iNumA * iNumB;
            // tboxResult.Text = iResult.ToString();

            tboxResult.Text = fMul(iNumA, iNumB).ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbox1.Text);
            int iNumB = int.Parse(tbox2.Text);

            // int iResult = iNumA / iNumB;
            // tboxResult.Text = iResult.ToString();

            tboxResult.Text = fdiv(iNumA, iNumB).ToString();
        }





        private int fPlus(int iNumA, int iNumB)
        {
            // 반환 값을 적어줄 때는 초기화 값을 적어주는게 좋다.
            int iResult = 0;

            iResult = iNumA + iNumB;

            return iResult;
        }

        private int fMinus(int iNumA, int iNumB)
        {
            // 반환 값을 적어줄 때는 초기화 값을 적어주는게 좋다.
            int iResult = 0;

            iResult = iNumA - iNumB;

            return iResult;
        }

        private int fMul(int iNumA, int iNumB)
        {
            // 반환 값을 적어줄 때는 초기화 값을 적어주는게 좋다.
            int iResult = 0;

            iResult = iNumA * iNumB;

            return iResult;
        }

        private int fdiv(int iNumA, int iNumB)
        {
            // 반환 값을 적어줄 때는 초기화 값을 적어주는게 좋다.
            int iResult = 0;

            iResult = iNumA / iNumB;

            return iResult;
        }
    }
}
