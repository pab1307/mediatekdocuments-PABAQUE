using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
    public static class InputDialog
    {
        /// <summary>
        /// Affiche une boîte de dialogue de saisie simple (équivalent InputBox) sans dépendance Microsoft.VisualBasic.
        /// Retourne null si l'utilisateur annule.
        /// </summary>
        public static string Show(string prompt, string title, string defaultValue = "")
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterParent;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ClientSize = new Size(520, 140);

            label.Text = prompt;
            label.SetBounds(12, 12, 496, 30);

            textBox.Text = defaultValue ?? "";
            textBox.SetBounds(12, 45, 496, 23);

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.SetBounds(332, 85, 80, 28);

            buttonCancel.Text = "Annuler";
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.SetBounds(428, 85, 80, 28);

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult result = form.ShowDialog();
            return result == DialogResult.OK ? textBox.Text : null;
        }
    }
}
