using System;
using System.Windows.Forms;

namespace FazendaUrbana
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cadastro());  // Aqui voc� pode trocar para outro formul�rio
           
        }
    }
}
