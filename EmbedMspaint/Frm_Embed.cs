using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbedMspaint
{
    public partial class Frm_Embed : Form
    {
        private string appFile;
        private string arguments;
        public Frm_Embed()
        {
            InitializeComponent();
        }
        public Frm_Embed(string _appFile, string _arguments)
        {
            InitializeComponent();
            appFile = _appFile;
            arguments = _arguments;
        }

        private void Frm_Embed_Load(object sender, EventArgs e)
        {
            embedPanel1.Start(appFile, arguments);
        }
    }
}
