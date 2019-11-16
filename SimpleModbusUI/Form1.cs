using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace SimpleModbusUI
{
	public partial class Form1 : Form
	{
		bool portState = false;
		public Form1()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;

			button1.Text = "启动";
			btnRead.Enabled = false;
			timer1.Enabled = false;
			btnF1.Enabled = false;
			btnF2.Enabled = false;
			btnF3.Enabled = false;
			btnF4.Enabled = false;
			btnF5.Enabled = false;
			btnF6.Enabled = false;
			btnF7.Enabled = false;
			btnF8.Enabled = false;
			btnF9.Enabled = false;
			btnF10.Enabled = false;
			btnF11.Enabled = false;
			btnF16.Enabled = false;
		}
		private object obj = new object();

		#region DllImport

		[DllImport("czc.dll", EntryPoint = "InitPort", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int InitPort(int portNo);

		[DllImport("czc.dll", EntryPoint = "ClosePort", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern void ClosePort();

		[DllImport("czc.dll", EntryPoint = "SetLed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int SetLed(Byte addr, UInt16 stat);

		[DllImport("czc.dll", EntryPoint = "GetButton", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int GetButton(Byte addr);

		[DllImport("czc.dll", EntryPoint = "SetLed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int SetOneReg(Byte addr, UInt16 regAddr, UInt16 stat);

		[DllImport("czc.dll", EntryPoint = "GetButton", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int GetOneReg(Byte addr, UInt16 regAddr);

		#endregion
		private void closeComm()
		{
			ClosePort();

			
			button1.Text = "启动";
			ledDisplay(0x0000);
			btnRead.Enabled = false;
			timer1.Enabled = false;
			btnF1.Enabled = false;
			btnF2.Enabled = false;
			btnF3.Enabled = false;
			btnF4.Enabled = false;
			btnF5.Enabled = false;
			btnF6.Enabled = false;
			btnF7.Enabled = false;
			btnF8.Enabled = false;
			btnF9.Enabled = false;
			btnF10.Enabled = false;
			btnF11.Enabled = false;
			btnF16.Enabled = false;


		}

		private void openComm()
		{
			InitPort(comboBox1.SelectedIndex + 1);
			
			button1.Text = "关闭";
			btnRead.Enabled = true;
			timer1.Enabled = true;

			btnF1.Enabled = true;
			btnF2.Enabled = true;
			btnF3.Enabled = true;
			btnF4.Enabled = true;
			btnF5.Enabled = true;
			btnF6.Enabled = true;
			btnF7.Enabled = true;
			btnF8.Enabled = true;
			btnF9.Enabled = true;
			btnF10.Enabled = true;
			btnF11.Enabled = true;
			btnF16.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (portState)
			{
				portState = false;
				closeComm();
			}
			else
			{
				portState = true;
				openComm();

			}

		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//button1.Enabled = true;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			try
			{
				ReadOnce();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
		private static UInt16 revButtonStat = 0;
		private static UInt16 localButtonStat = 0;
		private void btnFx_Click(object sender, EventArgs e)
		{
			Button my = (Button)sender;
			string[] text = my.Name.Split('F') ;
			Byte index = Convert.ToByte(text[1]);
			UInt16 data = (UInt16)(0x0001 << (index - 1));
			if(localButtonStat == data)
			{
				localButtonStat = 0;
				data = 0;
			}
			else
			{
				localButtonStat = data;
			}
			Int32 iRet = -1;
			lock (obj)
			{
				iRet = SetLed(0x01, data);
			}
				
			if(iRet < 0)
			{
				MessageBox.Show("写错误！");
				return;
			}
			ledDisplay((UInt16)localButtonStat);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				ReadOnce();
			}
			catch
			{
				timer1.Enabled = false;
				portState = false;
				closeComm();
				MessageBox.Show("设备通信错误！");
			}
			
		}

		
		private void ReadOnce()
		{
			Int32 buttonStat = 0;
			lock (obj)
			{
				buttonStat = GetButton(0x01);
			}

			if (buttonStat < 0)
			{
				throw new Exception("读取错误！");
			}

			if(revButtonStat != buttonStat)
			{
				Int32 iRet = -1;
				revButtonStat = (UInt16)buttonStat;
				ledDisplay((UInt16)revButtonStat);

				lock (obj)
				{
					iRet = SetLed(0x01, revButtonStat);
				}

				if (iRet < 0)
				{
					throw new Exception("写错误！");
				}
			}
			
		}

		private void ledDisplay(UInt16 buttonStat)
		{
			if (((UInt16)buttonStat & 0x0001) == 0x0001)
			{
				btnF1.BackColor = Color.Red;
			}
			else
			{
				btnF1.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0002) == 0x0002)
			{
				btnF2.BackColor = Color.Red;
			}
			else
			{
				btnF2.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0004) == 0x0004)
			{
				btnF3.BackColor = Color.Red;
			}
			else
			{
				btnF3.BackColor = btnRead.BackColor;
			}
			if (((UInt16)buttonStat & 0x0008) == 0x0008)
			{
				btnF4.BackColor = Color.Red;
			}
			else
			{
				btnF4.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0010) == 0x0010)
			{
				btnF5.BackColor = Color.Yellow;
			}
			else
			{
				btnF5.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0020) == 0x0020)
			{
				btnF6.BackColor = Color.Yellow;
			}
			else
			{
				btnF6.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0040) == 0x0040)
			{
				btnF7.BackColor = Color.Yellow;
			}
			else
			{
				btnF7.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0080) == 0x0080)
			{
				btnF8.BackColor = Color.Green;
			}
			else
			{
				btnF8.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0100) == 0x0100)
			{
				btnF9.BackColor = Color.Green;
			}
			else
			{
				btnF9.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0200) == 0x0200)
			{
				btnF10.BackColor = Color.Green;
			}
			else
			{
				btnF10.BackColor = btnRead.BackColor;
			}

			if (((UInt16)buttonStat & 0x0400) == 0x0400)
			{
				btnF11.BackColor = Color.Green;
			}
			else
			{
				btnF11.BackColor = btnRead.BackColor;
			}
		}
	}
}
