using System;
using System.Windows.Forms;

namespace RegularlyReportCreater {

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public partial class frmMain : Form {

        public frmMain() {
            InitializeComponent();
        }

        #region "イベント"

        /// <summary>
        /// フォームロードイベント。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e) {
            //using (var connection = new SQLiteConnection("DATA Source=test.db"))
            //{
            //    connection.Open();
            //    using (SQLiteCommand command = connection.CreateCommand())
            //    {
            //        command.CommandText = "create table hoge(id INTEGER PRIMARY KEY AUTOINCREMENT, field1 TEXT, field2 REAL, field3 BLOB)";
            //        command.ExecuteNonQuery();
            //    }
            //    connection.Close();
            //}
        }

        /// <summary>
        /// 終了ボタンクリックイベント。
        /// アプリケーションを終了します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// 定期報告作成ボタンクリックイベント。
        /// 定期報告作成ダイアログを表示します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e) {
            frmCreate form = new frmCreate();
            form.ShowDialog();
            form.Dispose();
        }

        /// <summary>
        /// マスタ編集ボタンクリックイベント。
        /// マスタ編集ダイアログを表示します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMasterEdit_Click(object sender, EventArgs e) {
            frmMasterEdit form = new frmMasterEdit();
            form.ShowDialog();
            form.Dispose();
        }

        #endregion "イベント"
    }
}