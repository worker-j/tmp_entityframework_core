using GetStartedWinform.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetStartedWinform
{
    public partial class Form_codeMaster1 : Form
    {
        private ProductsContext? dbContext;
        public Form_codeMaster1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ProductsContext();
            this.dbContext.DataMaster_cells.Load();
            this.dataMastercellBindingSource.DataSource = this.dbContext.DataMaster_cells.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }


        private void button_close_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.Close();
        }




        private void button_insert_Click(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (this.dbContext != null && this.dataGridView1.CurrentRow != null)
        //    {

        //    }
        //}
    }
}
