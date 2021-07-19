using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
    
        private void Form1_Load(object sender, EventArgs e)
        {   //呼叫Init事件
            this.Init();
        }
      private void btnReset_Click(object sender, EventArgs e)
        {   //呼叫Init事件
            this.Init();
        }
      private void btnCalculate_Click(object sender, EventArgs e)
        {   
            
            

            this.label5.Text = $"使用期間: " +
                this.dateTimePicker1.Value.ToString("yyyy/MM/dd") + " ~ " + //字串與字串連接要用 + 來連接
                this.dateTimePicker2.Value.ToString("yyyy/MM/dd");
            this.label8.Text = $"計算天數: 天";
            this.label9.Text = $"汽缸CC數: ";
            this.label10.Text = $"用途: ";
            this.label11.Text = $"計算公式: 元";
            this.label12.Text = $"應納稅額: 共 元";

        }
      private void cbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxtype2.Items.Clear();
            cbxtype2.Items.Add(cbxtype2.Text);

            if()
            {
                this.cbxtype2.Text = $"150以下/12PH以下(12.2PS以下)";
                this.cbxtype2.Text = $"151-250/12.1-20HP(12.3~20.3PS)";
                this.cbxtype2.Text = $"251-500/20.1HP以上(20.4PS以上)";
                this.cbxtype2.Text = $"501-600";
                this.cbxtype2.Text = $"601-1200";
                this.cbxtype2.Text = $"1201-1800";
                this.cbxtype2.Text = $"1801或以上";
            }
            if()
            {
                this.cbxtype2.Text = $"500以上";
                this.cbxtype2.Text = $"501-600";
                this.cbxtype2.Text = $"601-1200";
                this.cbxtype2.Text = $"1201-1800";
                this.cbxtype2.Text = $"1801-2400";
                this.cbxtype2.Text = $"2401-3000/138HP以下(140.1PS以下)";
                this.cbxtype2.Text = $"3001-3600";
                this.cbxtype2.Text = $"3601-4200/138.1-200HP(140.2-203.0PS)";
                this.cbxtype2.Text = $"4201-4800";
                this.cbxtype2.Text = $"4801-5400/200.1-247HP(203.1-250.7PS)";
                this.cbxtype2.Text = $"5401-6000";
                this.cbxtype2.Text = $"6001-6600/247.1-286HP(250.8-290.3PS)";
                this.cbxtype2.Text = $"6601-7200";
                this.cbxtype2.Text = $"7201-7800/286.1-336HP(290.4-341.0PS)";
                this.cbxtype2.Text = $"7801-8400";
                this.cbxtype2.Text = $"8401-9000/336.1-361HP(341.1-366.4PS)";
                this.cbxtype2.Text = $"9001-9600";
                this.cbxtype2.Text = $"9601-10200/361.1HP以上(366.5PS以上)";
                this.cbxtype2.Text = $"10201以上";
            }
        }

            #region "custom methods"
            private void Init()
        {   //設定初始畫面
            this.cbxtype.SelectedIndex = 0;
            this.cbxtype2.SelectedIndex = 0;
        }
        //計算日期的期間差
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //    lblDayStart.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        //    lblDayEnd.Text = dateTimePicker2.Value.ToString();
        //    TimeSpan ts;   
        //    ts = dateTimePicker2.Value.Subtract(dateTimePicker1.Value);  //ts為天數差
        //    lblTimeSpan.Text = Convert.ToString(ts.TotalDays);
        }

        private double GetTaxPercentage()
        {   
            string taxType = this.cbxtype2.Text;

            //合理的話就跑這段，下拉選單對到什麼就回傳什麼值回去
            switch (taxType)
            {
                case "150以下 / 12PH以下(12.2PS以下)":
                    return 0;
                case "151 - 250 / 12.1 - 20HP(12.3~20.3PS)":
                    return 800;
                case "251 - 500 / 20.1HP以上(20.4PS以上)":
                    return 1620;
                case "501 - 600":
                    return 2160;
                case "601 - 1200":
                    return 4320;
                case "1201 - 1800":
                    return 7120;
                case "1801或以上":
                    return 11230;

                default:
                    return 0;
            }
            #endregion
        }

    }
}
