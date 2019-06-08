using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlThucDon
{
    public partial class UCLoadThucDon : UserControl
    {
        public UCLoadThucDon()
        {
            InitializeComponent();
        }
        private static UCLoadThucDon _instance;
        public static UCLoadThucDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCLoadThucDon();
                return _instance;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
