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
    public partial class uc_Report : UserControl
    {
        //uc_NewItem for Create function
        private static uc_Report NewReport_Instance;
        public static uc_Report NReport
        {
            get
            {
                NewReport_Instance = null; ;
                if (NewReport_Instance == null)
                    NewReport_Instance = new uc_Report();
                return NewReport_Instance;
            }
        }
        public uc_Report()
        {
            InitializeComponent();
        }
    }
}
