using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class UserTransactionControl : UserControl
    {
        private static UserTransactionControl _instance;
        public static UserTransactionControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserTransactionControl();
                }
                return _instance;
            }
        }
        
        public UserTransactionControl()
        {
            InitializeComponent();
        }
    }
}
