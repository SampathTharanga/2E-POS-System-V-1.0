using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sun_Electrical
{
    public partial class uc_Help : UserControl
    {
        //uc_Help for Create function
        private static uc_Help hlp_Instance;
        public static uc_Help hlp
        {
            get
            {
                hlp_Instance = null; ;
                if (hlp_Instance == null)
                    hlp_Instance = new uc_Help();
                return hlp_Instance;
            }
        }
        public uc_Help()
        {
            InitializeComponent();
        }
    }
}
