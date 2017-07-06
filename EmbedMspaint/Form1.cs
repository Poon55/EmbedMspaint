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

namespace EmbedMspaint
{
    public partial class Form1 : Form
    {
        private string strImagePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            photo.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"Images\StylePic.png"));
        }

        private void photo_DoubleClick(object sender, EventArgs e)
        {
            byte[] byteAttah = ImageToByteArray(photo.Image);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            strImagePath = saveFileDialog.FileName = Path.Combine(System.IO.Path.GetTempPath(), string.Format("{0}.png", Guid.NewGuid().ToString()));
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();//输出文件                    
            fs.Write(byteAttah, 0, byteAttah.Length);
            fs.Dispose();
            new Frm_Embed(@"C:\WINDOWS\system32\mspaint.exe", strImagePath).ShowDialog();
            photo.Image = Image.FromFile(strImagePath);
        }

        #region 字节-图片互转
        
        /// <summary>
        /// 图片转为Byte字节数组
        /// </summary>
        /// <param name="FilePath">路径</param>
        /// <returns>字节数组</returns>
        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bmp = new Bitmap(imageIn))
                {
                    bmp.Save(ms, imageIn.RawFormat);
                }
                return ms.ToArray();
            }
        }
        /// <summary>
        /// 字节数组生成图片
        /// </summary>
        /// <param name="Bytes">字节数组</param>
        /// <returns>图片</returns>
        private Image ByteArrayToImage(byte[] Bytes)
        {
            using (MemoryStream ms = new MemoryStream(Bytes))
            {
                Image outputImg = Image.FromStream(ms);
                return outputImg;
            }
        }
        #endregion 字节-图片互转

    }
}
