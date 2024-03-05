using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Control_panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            if(ports.Length!=0)
                comboBox1.SelectedIndex = 0;
            status.Text = "Status:  Don't connect to port";

            TextBox.CheckForIllegalCrossThreadCalls = false;

        }

        private void Connect_btn(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    status.Text = "Status: Connect port";
                }
                catch
                {
                    status.Text = "Status: Error Com!";
                    return; 
                }
                if (!serialPort1.IsOpen)
                {
                    status.Text = "Status: Error Com!";
                    return;
                }
                Connect.Text = "Disconnect";
                Connect.BackColor = Color.Red;
                return;
            }
            serialPort1.Close();
            status.Text = "Status:  Don't connect to port";
            Connect.Text = "Connect";
            Connect.BackColor = Color.Lime;
        }

        int time_run=0;
        int time_delay=0;
        int isSend = 0;
        int is_sumbit_press = 0;

        int[] int_x = new int[4];
        int[] int_y = new int[4];
        int[] int_z = new int[4];
        int[] int_a = new int[4];
        private void Submit_Btn(object sender, EventArgs e)
       {
            is_sumbit_press = 1;

            if (serialPort1.IsOpen)
            {
                try
                {
                    int_x[0] = int.Parse(x.Text);
                    int_y[0] = int.Parse(y.Text);
                    int_z[0] = int.Parse(z.Text);
                    int_a[0] = int.Parse(a.Text);

                    int_x[1] = int.Parse(x2.Text);
                    int_y[1] = int.Parse(y2.Text);
                    int_z[1] = int.Parse(z2.Text);
                    int_a[1] = int.Parse(a2.Text);

                    int_x[2] = int.Parse(x3.Text);
                    int_y[2] = int.Parse(y3.Text);
                    int_z[2] = int.Parse(z3.Text);
                    int_a[2] = int.Parse(a3.Text);

                    int_x[3] = int.Parse(x4.Text);
                    int_y[3] = int.Parse(y4.Text);
                    int_z[3] = int.Parse(z4.Text);
                    int_a[3] = int.Parse(a4.Text);
                }
                catch
                {
                    return;
                }
            }
        }

        int i_1 = 0;
        private void trafer_data()
        {
                single_tranfer(int_x[i_1], int_y[i_1], int_z[i_1], int_a[i_1]);
                isSend = 1;
                time_delay = time_run;
                isSendCommandRead = 1;
                i_1++;
                if (i_1 == 4)
                {
                    isSend = -1;
                    is_sumbit_press = 0;
                    i_1 = 0;
                }
        }
    private void single_tranfer(int int_x, int int_y, int int_z, int int_a)
        {
            if (hanlde_position(int_x, 'X') == -1 || hanlde_position(int_y, 'Y') == -1 || hanlde_position(int_z, 'Z') == -1)
            {
                return;
            }
            else
            {
                byte[] proto_write_func03 = new byte[17];

                //ma dia chi
                proto_write_func03[0] = 0x01;

                //ma chuc nang
                proto_write_func03[1] = 0x10;

                //dia chi bat dau
                proto_write_func03[2] = 0x00;
                proto_write_func03[3] = 0x08;

                //so luong thanh ghi
                proto_write_func03[4] = 0x00;
                proto_write_func03[5] = 0x05;

                //so byte
                int temp = 2 * proto_write_func03[5];
                proto_write_func03[6] = (byte)temp;

                //X
                proto_write_func03[7] = (byte)(hanlde_position(int_x, 'X') >> 8);
                proto_write_func03[8] = (byte)hanlde_position(int_x, 'X');

                //Y
                proto_write_func03[9] = (byte)(hanlde_position(int_y, 'Y') >> 8);
                proto_write_func03[10] = (byte)hanlde_position(int_y, 'Y');

                //Z
                proto_write_func03[11] = (byte)(hanlde_position(int_z, 'Z') >> 8);
                proto_write_func03[12] = (byte)hanlde_position(int_z, 'Z');

                //speed
                proto_write_func03[13] = 0x00;
                proto_write_func03[14] = (byte)hanlde_position(int_a, 'A');

                //valve
                proto_write_func03[15] = 0x00;
                proto_write_func03[16] = 0x00;
                for (int i = 0; i < proto_write_func03.Length; i++)
                {
                    tranfer_data(proto_write_func03[i], 1);
                }

                tranfer_data((short)checkCRC(proto_write_func03, proto_write_func03.Length), 2);
            }

            status.Text = "Status: Success!";
        }

    private int hanlde_position(int data,char truc)
        {
            int temp;
            temp = data * 10;// cm->mm

            switch (truc)
            {
                case 'X':
                case 'Y':
                    if (data < -125 || data > 125)
                    {
                        status.Text = "Status: ERROR: position x,y from-125mm to 125mm!";
                        return -1;
                    }
                    if (temp < 0)
                    {
                        temp= 65536 + temp;
                    }
                    break;
                case 'Z':
                    if(data < -314 || data > -191)
                    {
                        status.Text = "Status: ERROR: position z from-314mm to -191mm!";
                        return -1;
                    }
                    temp = 65536 + temp;
                    break;
                case 'A':
                    if (data < 0 || data > 6)
                    {
                        status.Text = "Status: ERROR: a from 0 to 6!";
                        return 0;
                    }
                    temp = data;
                    break;


            }
            return temp;
        }

        int checkCRC(byte[] proto_write_func03,int len)
        {
            int crc = 0x0000ffff;
            int temp1;
            int temp2;
            for (int i = 0; i < len; i++)
            {
                crc = CaculateCRC(proto_write_func03[i], crc);
            }
            temp1 = crc & 0x000000ff;
            temp2 = crc & 0x0000ff00;

            crc = temp1 << 8 | temp2 >> 8;
            return crc;
        }

        int CaculateCRC(byte Data, int crc)
        {
            short i;
            crc = crc ^ Data;
            for (i = 0; i < 8; i++)
            {
                if ((crc & 1) == 1)
                {
                    crc = (crc >> 1);
                    crc = (crc ^ 0xA001);
                }
                else
                {
                    crc = (crc >> 1);
                }
            }
            return (crc);
        }
        private void tranfer_data(int data,int len)
        {
            byte[] temp = new byte[1];

            for(int i =len-1; i >-1; i--)
            {
                temp[0]= (byte)(data >> (8 * i));
                serialPort1.Write(temp, 0, 1);
            }
               
        }

        private void change_position(object sender, EventArgs e)
        {
            status.Text = "Status:";
        }

        int isSendCommandRead = 0;
        private void getPosition(object sender, EventArgs e)
        {
            if (isSendCommandRead == 0 && serialPort1.IsOpen) {
                byte[] proto_read = new byte[6];

                proto_read[0] = 0x01;
                proto_read[1] = 0x03;
                proto_read[2] = 0x00;
                proto_read[3] = 0x08;
                proto_read[4] = 0x00;
                proto_read[5] = 0x05;

                for (int i = 0; i < proto_read.Length; i++)
                {
                    tranfer_data(proto_read[i], 1);
                }

                tranfer_data((short)checkCRC(proto_read,proto_read.Length), 2);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int x, y, z;
            byte[] buff =new byte[50];
            serialPort1.Read(buff, 0, 50);
            if(buff[1] == 0x10)
            {
                if (isSend == -1)
                {
                    isSendCommandRead = 0;
                }
                isSend = 0;
            }
            else if (isSendCommandRead == 0 && buff[1] == 0x03)
            {
                int crc = checkCRC(buff, 13);
                int crc_recivce = buff[14] | (int)buff[13] << 8;
                if (crc == crc_recivce)
                {
                    x = handle_current_position((short)(buff[4] | (int)buff[3] << 8), 'X');
                    y = handle_current_position((short)(buff[6] | (int)buff[5] << 8), 'Y');
                    z = handle_current_position((short)(buff[8] | (int)buff[7] << 8), 'Z');
                    current_x.Text = x.ToString();
                    current_y.Text = y.ToString();
                    current_z.Text = z.ToString();
                }
            }

        }

        private int handle_current_position(short data,char truc)
        {
            int result=0;
            switch (truc)
            {
                case 'X':
                case 'Y':
                      result = data / 10;
                    break;
                case 'Z':
                    result = data / 10;
                    break;

            }
            return result;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (is_sumbit_press == 1&& isSend==0)
            {
                trafer_data();
            }
        }
    }
}
