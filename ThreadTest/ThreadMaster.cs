using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreadTest
{
    public class ThreadMaster
    {
        private readonly Object thisLock = new Object();
        public ThreadMaster()
        {
        }

        public async Task RodarTarefa(List<int> tarefas, IProgress<string> progress, IProgress<string> progressBar)
        {
            var configuracaoParalela = new ParallelOptions
            {
                MaxDegreeOfParallelism = Environment.ProcessorCount
            };

            var t = Task.Factory.StartNew(() =>
            {
                var totalTarefas = tarefas.Count;
                var tarefasFeitas = 0;
                Parallel.ForEach(tarefas, configuracaoParalela, tarefa =>
                {
                    progress.Report("\nComeçou tarefa: " + tarefa + " tempo: " + DateTime.Now);

                    Task.Delay(tarefa).Wait();

                    progress.Report("\nTerminou tarefa: " + tarefa + " tempo: " + DateTime.Now);
                    lock(thisLock)
                    {
                        tarefasFeitas++;
                        progressBar.Report(tarefasFeitas + "/" + totalTarefas);
                    }
                });
            });
            await t;
        }
    }
}
