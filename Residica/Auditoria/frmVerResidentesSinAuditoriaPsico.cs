﻿using BLL;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residica.Auditoria
{
    public partial class frmVerResidentesSinAuditoriaPsico : Form
    {
        public frmVerResidentesSinAuditoriaPsico()
        {
            InitializeComponent();
        }

        private void frmVerResidentesSinAuditoriaPsico_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GestorAuditoriaBLL.GetInstance().TraerPendienteAuditoria(1);
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
   
        }

    }
}
