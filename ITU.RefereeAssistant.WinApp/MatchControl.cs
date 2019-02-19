using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITU.RefereeAssistant.WinApp
{
    public partial class MatchControl : UserControl
    {
        public MatchControl()
        {
            InitializeComponent();
        }

        public string FirstPlayer
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public string SecondPlayer
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
            }
        }

        public decimal FirstScore
        {
            get
            {
                return numericUpDown1.Value;
            }
            set
            {
                numericUpDown1.Value = value;
            }
        }

        public decimal SecondScore
        {
            get
            {
                return numericUpDown2.Value;
            }
            set
            {
                numericUpDown2.Value = value;
            }
        }
    }
}
