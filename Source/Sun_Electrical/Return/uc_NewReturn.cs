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
    public partial class uc_NewReturn : UserControl
    {
        //uc_NewReturn for Create function
        private static uc_NewReturn NewReturn_Instance;
        public static uc_NewReturn NReturn
        {
            get
            {
                NewReturn_Instance = null; ;
                if (NewReturn_Instance == null)
                    NewReturn_Instance = new uc_NewReturn();
                return NewReturn_Instance;
            }
        }
        public uc_NewReturn()
        {
            InitializeComponent();
        }
    }
}
