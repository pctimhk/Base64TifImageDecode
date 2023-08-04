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

namespace Base64ImageTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.DecodeBase64StringAsImageFile(txtBase64Text.Text, saveFileDialog1.FileName, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot convert to image. Please see the following error detail."
                        + Environment.NewLine
                        + Environment.NewLine
                        + ex.Message);
                }
            }
        }

        private void DecodeBase64StringAsImageFile(String base64String, String destFile, bool replace)
        { 

            if (replace && File.Exists(destFile))
                File.Delete(destFile);

            byte[] ImageData = Convert.FromBase64String(base64String);

            using (FileStream fs = new FileStream(destFile, FileMode.CreateNew, FileAccess.Write))
            {
                try
                {
                    fs.Write(ImageData, 0, ImageData.Length);
                    fs.Flush();
                }
                catch (Exception ex)
                { throw; }
                finally
                {
                    if (fs != null)
                        fs.Close();
                }
            }
        }

    }

}
