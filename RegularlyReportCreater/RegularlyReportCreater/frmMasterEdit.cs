using System;
using System.Windows.Forms;

namespace RegularlyReportCreater {

    public partial class frmMasterEdit : Form {

        /// <summary>
        /// コンストラクタ。
        /// </summary>
        public frmMasterEdit() {
            InitializeComponent();
        }

        #region "イベント"

        /// <summary>
        /// キャンセルボタンクリックイベント。
        /// ダイアログを閉じます。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion "イベント"
    }
}