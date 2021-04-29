using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CsharpGUI
{
	public partial class Form1 : Form
	{
		int angle = 0;//角度
		int picture = 0;//照片數
		int minute = 0;//時間
		int perAngle;
		int perPicture;
		SerialPort myport = new SerialPort();

		public Form1()
		{
			InitializeComponent();
			label5.Text = "Arduino連線狀態：尚未連線";
			myport.BaudRate = 9600; //需跟arduno設定的一樣
			myport.DataBits = 8;
			myport.StopBits = StopBits.One;
			myport.Parity = Parity.None;
			timer1.Interval = 50;
			button1.Enabled = false;
			button2.Enabled = false;
			button4.Enabled = false;
			textBox1.Enabled = false;
			textBox2.Enabled = false;
			comboBox1.Items.AddRange(SerialPort.GetPortNames());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("輸入錯誤，請重新輸入");
			}
			else
			{
				if (textBox1.Text.All(char.IsDigit) && textBox2.Text.All(char.IsDigit))
				{
					angle = Convert.ToInt32(textBox1.Text);
					minute = Convert.ToInt32(textBox2.Text);
					perAngle = angle / minute;//一分鐘轉幾度
					string fmt = "000";
					string transPerAngle = perAngle.ToString(fmt);
					Console.WriteLine(transPerAngle);
					MessageBox.Show("傳送資料中..");
					myport.Write(transPerAngle);
				}
				else
				{
					MessageBox.Show("輸入錯誤，請輸入數字，勿輸入其他字元");
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			angle = 0;
			picture = 0;
			minute = 0;
			textBox1.Text = "";
			textBox2.Text = "";
			myport.Write("0");
			//MessageBox.Show("等待轉盤歸零前，請勿動作");
		}
		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "")
			{
				MessageBox.Show("請去裝置管理員查詢arduino連接阜");
				Console.WriteLine(SerialPort.GetPortNames());
			}
			else
			{
				try
				{
					label5.Text = "Arduino連線狀態：已連線";
					//un-comment this line to cause the arduino to re-boot when the serial connects
					//port.DtrEnabled = true;
					myport.PortName = comboBox1.Text; //指定PortName 
					myport.Open();
					Console.WriteLine("start read");
					timer1.Enabled = true;
					button1.Enabled = true;
					button2.Enabled = true;
					button4.Enabled = true;
					textBox1.Enabled = true;
					textBox2.Enabled = true;
					button3.Enabled = false;
				}
				catch (Exception ex)
				{
					label5.Text = "Arduino連線狀態：斷線";
					timer1.Enabled = false;
					//alert the user that we could not connect to the serial port
				}
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			label5.Text = "Arduino連線狀態：斷線";
			timer1.Enabled = false;
			button1.Enabled = false;
			button2.Enabled = false;
			button4.Enabled = false;
			textBox1.Enabled = false;
			textBox2.Enabled = false;
			//myport.Write("0");
			myport.Close();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			string data = myport.ReadLine();
			Console.WriteLine(data);
		}

		
	}
}

