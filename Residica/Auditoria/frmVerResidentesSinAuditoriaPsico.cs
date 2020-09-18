﻿using BLL;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Dominio;
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

            CargarGrilla();


        }

        private void btn_auditar_Click(object sender, EventArgs e)
        {
            try
            {
                ColumnView view = gridControl1.MainView as ColumnView;

                if (view.GetSelectedRows().Length == 1)
                {
                    Residente residente = (Residente)view.GetRow(view.GetSelectedRows()[0]); 
                    frmAuditoria frmAuditoria = new frmAuditoria(residente, 2);
                    frmAuditoria.Show();
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarGrilla()
        {
            gridControl1.DataSource = GestorAuditoriaBLL.GetInstance().TraerPendienteAuditoria(1);
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
        }
    }
}
