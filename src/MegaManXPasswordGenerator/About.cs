using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaManXPasswordGenerator
{
    public partial class About : Form
    {
        private static About m_SingleAboutForm = null;
        public static About SingleAboutForm
        {
            get
            {
                if (m_SingleAboutForm == null)
                    m_SingleAboutForm = new About();

                return m_SingleAboutForm;
            }
            private set
            {
                m_SingleAboutForm = value;
            }
        }

        private About()
        {
            InitializeComponent();
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            About.SingleAboutForm = null;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}