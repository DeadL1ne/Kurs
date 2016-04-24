using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtorEstateAgancy
{
    public partial class FullDescriptionForm : Form
    {
        private estateId id;
        public FullDescriptionForm(estateId sender)
        {
            InitializeComponent();
            id = sender;
        }
        private void FullDescriptionForm_Load(object sender, EventArgs e)
        {

            dealTypeLabel.Text = Convert.ToString(id.Invoke());
        }
    }
}
