using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTK;

namespace Demo111
{
    public partial class FrmChangeOrderInfo : Form
    {
        public FrmChangeOrderInfo()
        {
            InitializeComponent();
        }
        public FrmChangeOrderInfo(Order order)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.order = order;
        }

        private Order order;

        private string getWeekDay(string date,string trainCode)
        {
            string sql = "SELECT weekdays FROM TrainNum WHERE trainCode='" + trainCode + "' and startDate= '" + date + "'";

            return SqlHelper.ExecuteScalar(sql).ToString();
        }
        private void FrmOrderInfo_Load(object sender, EventArgs e)
        {
            #region 数据加载
            this.dgvOrderInfo.Rows[0].Cells[0].Value = 1.ToString();
            this.dgvOrderInfo.Rows[0].Cells[1].Value = order.PersonName.ToString();
            this.dgvOrderInfo.Rows[0].Cells[2].Value = order.IDType.ToString();
            this.dgvOrderInfo.Rows[0].Cells[3].Value = order.IDNum.ToString();
            this.dgvOrderInfo.Rows[0].Cells[4].Value = order.passengerType.ToString();
            this.dgvOrderInfo.Rows[0].Cells[5].Value = order.seatType.ToString();
            this.dgvOrderInfo.Rows[0].Cells[6].Value = order.carriageNum;
            this.dgvOrderInfo.Rows[0].Cells[7].Value = order.seatNum + "号";
            this.dgvOrderInfo.Rows[0].Cells[8].Value = order.ticketPrice.ToString();

            this.date.Text = order.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            this.week.Text = getWeekDay(order.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo),order.trainCode);
            this.trainNum.Text = order.TrainType + order.trainCode;
            this.startSite.Text = order.startSite;
            this.endSite.Text = order.endSite;
            this.startTime.Text = order.startTime;
            this.endTime.Text = order.endTime; 
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            //设置打印纸张大小
            this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 500, 300);
            //调用打印事件
            this.printDocument1.PrintPage += new PrintPageEventHandler(this.MyPrintDocument_PrintPage);
            //打印预览
            printPreviewDialog1.Document = printDocument1;
            //显示打印预览
            DialogResult result = printPreviewDialog1.ShowDialog();
        }
        private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*如果需要改变自己 可以在new Font(new FontFamily("黑体"),11）中的“黑体”改成自己要的字体就行了，黑体 后面的数字代表字体的大小
             System.Drawing.Brushes.Blue , 170, 10 中的 System.Drawing.Brushes.Blue 为颜色，后面的为输出的位置 */
            #region 上半部分
            e.Graphics.DrawString(order.startSite, new Font(new FontFamily("黑体"), 22), System.Drawing.Brushes.Black, 40, 30);
            e.Graphics.DrawString("ZiBoZhan", new Font(new FontFamily("黑体"), 12), System.Drawing.Brushes.Black, 45, 60);
            e.Graphics.DrawString(order.endSite, new Font(new FontFamily("黑体"), 22), System.Drawing.Brushes.Black, 350, 30);
            e.Graphics.DrawString("WeiFangZhan", new Font(new FontFamily("黑体"), 12), System.Drawing.Brushes.Black, 345, 60);
            e.Graphics.DrawString(order.TrainType+order.trainCode, new Font(new FontFamily("黑体"), 20), System.Drawing.Brushes.Black, 210, 32);
            //箭头
            float wide = (float)3.0;
            Pen p = new Pen(Color.Black, wide);
            e.Graphics.DrawLine(p, 200, 60, 285, 60);
            e.Graphics.DrawLine(p, 285, 60, 275, 55);
            e.Graphics.DrawString(order.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo).Substring(0,4), new Font(new FontFamily("黑体"), 16), System.Drawing.Brushes.Black, 20, 85);
            e.Graphics.DrawString("年", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 70, 90);
            e.Graphics.DrawString(order.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo).Substring(5,2), new Font(new FontFamily("黑体"), 16), System.Drawing.Brushes.Black, 80, 85);
            e.Graphics.DrawString("月", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 105, 90);
            e.Graphics.DrawString(order.startDate.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo).Substring(8,2), new Font(new FontFamily("黑体"), 16), System.Drawing.Brushes.Black, 120, 85);
            e.Graphics.DrawString("日", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 145, 90);
            e.Graphics.DrawString(order.startTime, new Font(new FontFamily("黑体"), 16), System.Drawing.Brushes.Black, 165, 85);
            e.Graphics.DrawString("开", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 240, 90);
            e.Graphics.DrawString(order.carriageNum, new Font(new FontFamily("黑体"), 16), System.Drawing.Brushes.Black, 350, 85);
            e.Graphics.DrawString("车", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 375, 90);
            e.Graphics.DrawString(order.seatNum, new Font(new FontFamily("黑体"), 16), System.Drawing.Brushes.Black, 390, 85);
            e.Graphics.DrawString("号", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 415, 90);
            e.Graphics.DrawString("¥"+order.ticketPrice, new Font(new FontFamily("黑体"), 16), System.Drawing.Brushes.Black, 27, 110);
            e.Graphics.DrawString("元", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 105, 115);
            e.Graphics.DrawString("支", new Font(new FontFamily("黑体"), 12), System.Drawing.Brushes.Black, 200, 115);
            e.Graphics.DrawString("新空调硬座", new Font(new FontFamily("黑体"), 14), System.Drawing.Brushes.Black, 340, 113);
            e.Graphics.DrawString("限乘当日当次车", new Font(new FontFamily("黑体"), 14), System.Drawing.Brushes.Black, 22, 135);

            #endregion
            #region 下半部分
            e.Graphics.DrawString("3707861992****0919", new Font(new FontFamily("黑体"), 18), System.Drawing.Brushes.Black, 20, 170);
            e.Graphics.DrawString("张三", new Font(new FontFamily("黑体"), 18), System.Drawing.Brushes.Black, 255, 170);

            //曲线矩形
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; //虚线
            //pen.DashPattern = new float[] { 2, 2 };
            e.Graphics.DrawRectangle(pen, 30, 200, 300, 50);
            e.Graphics.DrawString("买票请到12306发货请到95306", new Font(new FontFamily("黑体"), 12), System.Drawing.Brushes.Black, 60, 205);
            e.Graphics.DrawString("中国铁路祝您旅途愉快", new Font(new FontFamily("黑体"), 12), System.Drawing.Brushes.Black, 80, 230);
            //绘制二维码
            Image image = new Bitmap("F://c#//WPF 学习//Printer-master//Test//7qr.png");
            Point point = new Point(350, 165);
            Size size = new Size(110, 110);
            Rectangle rectangle = new Rectangle(point, size);
            e.Graphics.DrawImage(image, rectangle);
            e.Graphics.DrawString("723244546756839024175", new Font(new FontFamily("黑体"), 14), System.Drawing.Brushes.Black, 20, 255);
            e.Graphics.DrawString("淄博售", new Font(new FontFamily("黑体"), 15), System.Drawing.Brushes.Black, 230, 255);
            #endregion

        }
    }
}
