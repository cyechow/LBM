using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LBM
{
    public partial class FormClientCreator : Form
    {
        public FormClientCreator()
        {
            InitializeComponent();
            if (DesignMode) { return; }
        }
    }
}
