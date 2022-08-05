using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;

namespace Presentation
{
    public partial class DoiMatKhau : Form
    {
        private IQLNhanVienService _IQLnv;

        public DoiMatKhau()
        {
            InitializeComponent();
            _IQLnv = new QLNhanVienService();
        }
    }
}
