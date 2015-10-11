using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRC_Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_CalculateCRC_Click(object sender, EventArgs e)
        {
            byte[] data = CRCMaster.stringToBytes(textBox_InputData.Text);
            if (data == null) return;

            label_Bytes.Text = "Bytes:" + data.Length;
            if (checkBox_Reverse.Checked) Array.Reverse(data);
          
            #region FCS (XOR)
            byte FCS = CRCMaster.FCS(data);
            textBox_XOR.Text = "0x" + FCS.ToString("X2");
            #endregion

            #region CRC 8
            Byte CRC8 = CRCMaster.CRC8(data);
            textBox_CRC8.Text = "0x" + CRC8.ToString("X2");
            #endregion

            #region CRC 16
            ushort CRC16 = CRCMaster.CRC16(data);
            if (checkBox_LSB_First.Checked) {
                byte[] b = BitConverter.GetBytes(CRC16);
                textBox_CRC16.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2");
            }
            else {
                textBox_CRC16.Text = "0x" + CRC16.ToString("X4");
            }
            #endregion

            #region CRC 16 Modbus
            ushort CRC16Modbus = CRCMaster.CRC16Modbus(data);
            if (checkBox_LSB_First.Checked)
            {
                byte[] b = BitConverter.GetBytes(CRC16Modbus);
                textBox_CRC16Modbus.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2");
            }
            else
            {
                textBox_CRC16Modbus.Text = "0x" + CRC16Modbus.ToString("X4");
            }
            #endregion

            #region CRC 16 Sick
            ushort CRC16Sick = CRCMaster.CRC16Sick(data);
            if (checkBox_LSB_First.Checked)
            {
                byte[] b = BitConverter.GetBytes(CRC16Sick);
                textBox_CRC16Sick.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2");
            }
            else {
                textBox_CRC16Sick.Text = "0x" + CRC16Sick.ToString("X4");
            }
            #endregion

            #region CRC CCITT XModem
            ushort CRC_CCITTXModem = CRCMaster.CRCXModem(data);
            if (checkBox_LSB_First.Checked)
            {
                byte[] b = BitConverter.GetBytes(CRC_CCITTXModem);
                textBox_CRC_CCITXModem.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2");
            }
            else {
                textBox_CRC_CCITXModem.Text = "0x" + CRC_CCITTXModem.ToString("X4");
            }
            #endregion

            #region CRC CCITT 0xFFF
            ushort CRC_CCITT_0XFFFF = CRCMaster.CRCFFFF(data);
            if (!checkBox_LSB_First.Checked)
            {
                byte[] b = BitConverter.GetBytes(CRC_CCITT_0XFFFF);
                textBox_CRC_CCITT0xFFFF.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2");
            }
            else {
                textBox_CRC_CCITT0xFFFF.Text = "0x" + CRC_CCITT_0XFFFF.ToString("X4");
            }
            #endregion

            #region CRC CCITT 0x1D0F
            ushort CRC_CCITT_0X1D0F = CRCMaster.CRC1D0F(data);

            if (!checkBox_LSB_First.Checked)
            {
                byte[] b = BitConverter.GetBytes(CRC_CCITT_0X1D0F);
                textBox1_CRC_CCIT0x1D0F.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2");
            }
            else {
                textBox1_CRC_CCIT0x1D0F.Text = "0x" + CRC_CCITT_0X1D0F.ToString("X4");
            }
            #endregion

            #region CRC KERMIT
            ushort CRC_Kermit = CRCMaster.CRCKermit(data);
            if (!checkBox_LSB_First.Checked)
            {
                byte[] b = BitConverter.GetBytes(CRC_Kermit);
                textBox_CCITTKermit.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2");
            }
            else {
                textBox_CCITTKermit.Text = "0x" + CRC_Kermit.ToString("X4");
            }
            #endregion

            #region CRC DNP
            ushort CRC_DNP = CRCMaster.CRCDNP(data);
            if (!checkBox_LSB_First.Checked)
            {
                byte[] b = BitConverter.GetBytes(CRC_DNP);
                textBox_CRCDNP.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2");
            }
            else {
                textBox_CRCDNP.Text = "0x" + CRC_DNP.ToString("X4");
            }
            #endregion

            #region CRC 32
            UInt32 CRC_32 = CRCMaster.CRC32(data);
            if (!checkBox_LSB_First.Checked)
            {
                byte[] b = BitConverter.GetBytes(CRC_32);
                textBox_CRC32.Text = "0x" + b[0].ToString("X2") + b[1].ToString("X2")+ b[2].ToString("X2")+ b[3].ToString("X2");
            }
            else {
                textBox_CRC32.Text = "0x" + CRC_32.ToString("X8");
            }
            #endregion

        }

        private void Clear_MenuItem_Click(object sender, EventArgs e)
        {
            textBox_XOR.Clear();
            textBox_InputData.Clear();
            textBox_CRC_CCITXModem.Clear();
            textBox_CRC_CCITT0xFFFF.Clear();
            textBox_CRCDNP.Clear();
            textBox_CRC8.Clear();
            textBox_CRC32.Clear();
            textBox_CRC16Sick.Clear();
            textBox_CRC16Modbus.Clear();
            textBox_CRC16.Clear();
            textBox_CCITTKermit.Clear();
        }
    }
}
