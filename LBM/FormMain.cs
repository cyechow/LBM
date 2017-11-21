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
    public partial class FormMain : Form
    {
        private DbInterface m_DbInterface = DbInterface.Instance;

        public FormMain()
        {
            InitializeComponent();
            if (DesignMode) return;
        }

        public void SetAppUser(string username)
        {
            this.portalNav.SetUser(username);
        }
    }
}
