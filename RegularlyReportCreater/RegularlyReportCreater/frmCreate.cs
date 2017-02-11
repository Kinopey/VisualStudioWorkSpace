using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularlyReportCreater {

    public partial class frmCreate : Form {

        public frmCreate() {
            InitializeComponent();
        }

        /// <summary>
        /// キャンセルボタンクリックイベント。
        /// ダイアログを閉じます。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCacel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}