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
    public partial class UserSettingsControl : UserControl
    {

        private static UserSettingsControl _instance;
        public static UserSettingsControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSettingsControl();
                }
                return _instance;
            }
        }
        public UserSettingsControl()
        {
            InitializeComponent();
        }
    }
}
