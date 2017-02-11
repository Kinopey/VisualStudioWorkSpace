using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace RegularlyReportCreater
{

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("DATA Source=test.db"))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "create table hoge(id INTEGER PRIMARY KEY AUTOINCREMENT, field1 TEXT, field2 REAL, field3 BLOB)";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }






}
