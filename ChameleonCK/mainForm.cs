using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M64MM.Utils;

namespace ChameleonCK
{
    public partial class mainForm : Form
    {
        private uint AddressSwimming = 0x253B62;
        private uint AddressHideStage = 0x0E000210;
        private uint AddressRoomColorCommand = 0x0E0001F8;
        private uint AddressRoomColor = 0x0E0001FC;
        private uint AddressBGColor = 0x0802B604;
        static frmAbout about = new frmAbout();
        public mainForm()
        {
            InitializeComponent();
            ReadFromGame();
        }

        private byte[] GetOneByteAsArray(long address)
        {
            return new byte[] { Core.ReadBytes(address, 1)[0] };
        }

        private void ReadFromGame()
        {
            ReadColor();
            ReadSwimming();
            ReadHideStage();
        }

        private void ReadColor()
        {
            uint data = BitConverter.ToUInt32(Core.ReadBytes(Core.SegmentedToVirtual(AddressRoomColorCommand), 4), 0);
            switch (data)
            {
                case 0xFB000000:
                    int readR = GetOneByteAsArray(Core.SegmentedToVirtual(AddressRoomColor + 3))[0];
                    int readG = GetOneByteAsArray(Core.SegmentedToVirtual(AddressRoomColor + 2))[0];
                    int readB = GetOneByteAsArray(Core.SegmentedToVirtual(AddressRoomColor + 1))[0];
                    Color color = Color.FromArgb(readR, readG, readB);
                    btnPickColor.BackColor = color;
                    break;
                default:
                    break;
            }
        }

        private void ReadSwimming()
        {
            byte[] data = GetOneByteAsArray(Core.BaseAddress + AddressSwimming);
            switch (data[0])
            {
                case 0x80:
                    //checkSwimming.Checked = true;
                    checkSwimming.CheckState = CheckState.Checked;
                    break;
                default:
                    checkSwimming.CheckState = CheckState.Unchecked;
                    break;
            }
        }

        private void ReadHideStage()
        {
            uint data = BitConverter.ToUInt32(Core.ReadBytes(Core.SegmentedToVirtual(AddressHideStage), 4), 0);
            switch (data)
            {
                case 0xB8000000:
                    //checkHideStage.Checked = true;
                    checkHideStage.CheckState = CheckState.Checked;
                    break;
                default:
                    checkHideStage.CheckState = CheckState.Unchecked;
                    break;
            }
        }

        private static ushort ColorToRGB16(Color color)
        {
            int r = (color.R * 31 + 127) / 255;
            int g = (color.G * 31 + 127) / 255;
            int b = (color.B * 31 + 127) / 255;
            //int a = (color.A >= 128) ? 1 : 0;
            int a = 1;

            return (ushort)((r << 11) | (g << 6) | (b <<1) | a);
        }

        private static uint ColorToRGB32(Color color)
        {
            string hexR = color.R.ToString("X2");
            string hexG = color.G.ToString("X2");
            string hexB = color.B.ToString("X2");
            //string hexA = color.A.ToString("X2");
            string hexA = "FF";
            string hexcolor = hexR + hexG + hexB + hexA;

            return Convert.ToUInt32(hexcolor, 16);
        }

        private void ChangeRoomColor(Color color)
        {
            Core.WriteBytes(Core.SegmentedToVirtual(AddressRoomColor), BitConverter.GetBytes(ColorToRGB32(color)));
        }

        private void ChangeBGColor(Color color)
        {
            Core.WriteBytes(Core.SegmentedToVirtual(AddressBGColor), BitConverter.GetBytes(ColorToRGB16(color)));
        }

        private void ChangeColors(Color color)
        {
            ChangeRoomColor(color);
            ChangeBGColor(color);
        }

        private void ToggleSwimming(bool Swimming)
        {
            byte[] data;
            switch (Swimming)
            {
                case true:
                    data = new byte[] { 0x80 };
                    break;
                default:
                    data = new byte[] { 0x08 };
                    break;
            }
            Core.WriteBytes(Core.BaseAddress + AddressSwimming, data);
        }

        private void ToggleHideStage(bool Transparency)
        {
            byte[] data;
            switch (Transparency)
            {
                case true:
                    data = new byte[] { 0x00, 0x00, 0x00, 0xB8 };
                    break;
                default:
                    data = new byte[] { 0x00, 0x00, 0x00, 0xBF };
                    break;
            }
            Core.WriteBytes(Core.SegmentedToVirtual(AddressHideStage), data);
        }

        // All of the following is just methods for the UI

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            ChromaDialog.Color = btnPickColor.BackColor;
            if (ChromaDialog.ShowDialog() == DialogResult.OK)
            {
                Color PickedColor = ChromaDialog.Color;
                btnPickColor.BackColor = PickedColor;
                ChangeColors(PickedColor);
            }
        }

        private void checkSwimming_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwimming(checkSwimming.Checked);
        }

        private void checkHideStage_CheckedChanged(object sender, EventArgs e)
        {
            ToggleHideStage(checkHideStage.Checked);
        }

        private void toolReadFromGame_Click(object sender, EventArgs e)
        {
            ReadFromGame();
        }
    }
}