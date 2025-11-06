using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291
{
    public partial class Form2 : Form
    {
        private int employeeId;
        public Form2(int id)
        {
            InitializeComponent();
            employeeId = id;
        }
    }
}
