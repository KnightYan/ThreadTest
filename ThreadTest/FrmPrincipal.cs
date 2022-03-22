using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThreadTest
{
    public partial class FrmPrincipal : Form
    {
        private readonly List<int> tarefas;
        public FrmPrincipal()
        {
            Random random = new();
            InitializeComponent();
            tarefas = new List<int>();
            for (int i = 0; i < 10; i++)
                tarefas.Add(i * random.Next(100,1000));
        }

        /*private async void btnComecar_Click(object sender, EventArgs e)
        {
            var progress = new Progress<string>(s => txtLog.AppendText(s));
            var threadMaster = new ThreadMaster();
            await Task.Factory.StartNew(() => ThreadMaster.RodarTarefa(tarefas, progress), TaskCreationOptions.LongRunning);

        }*/

        private async void btnComecar_Click(object sender, EventArgs e)
        {
            var progress = new Progress<string>(s => txtLog.AppendText(s));
            var progressBar = new Progress<string>(s => txtProgressBar.Text = s);
            var threadMaster = new ThreadMaster();
            await threadMaster.RodarTarefa(tarefas, progress, progressBar);

        }
    }
}
