using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_BancoDados_TurmaB_1Sem.View
{
    public class Consistencia1
    {
        #region Metodo de limpar formularios

        public static void LimparForm (Form formlimpar)
        {
            foreach (Control item in formlimpar.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        #endregion
    }
}
