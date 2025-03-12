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
    public partial class UserBorrowersControl : UserControl
    {
        private static UserBorrowersControl _instance;
        public static UserBorrowersControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UserBorrowersControl();
                }
                return _instance;
            }
        }
        public UserBorrowersControl()
        {
            InitializeComponent();
        }

        
    }
}
