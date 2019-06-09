using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlThucDon
{   //Customer
    public class ChatDinhDuong : Observer
    {
        private Label labelName;
        public Label LabelName { get => labelName; set => labelName = value; }
        private float _Value;
        public float Value { get => _Value; set => _Value = value; }

        public ChatDinhDuong(Label label)
        {
            this.LabelName = label;
        }
        
        public ChatDinhDuong()
        {

        }
        public override void update()
        {
            LabelName.Text = Value.ToString();
        }
    }
}
