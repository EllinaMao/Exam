using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Dictionary
{
    public static class Prompt
    {
        public static string? ShowDialog(string text , string caption , string defaultValue = "")
        {
            using var form = new Form()
            {
                Width = 420 ,
                Height = 150 ,
                Text = caption ,
                StartPosition = FormStartPosition.CenterParent ,
                FormBorderStyle = FormBorderStyle.FixedDialog ,
                MinimizeBox = false ,
                MaximizeBox = false
            };

            var label = new Label() { Left = 8 , Top = 8 , Text = text , AutoSize = true };
            var textBox = new TextBox() { Left = 8 , Top = 30 , Width = 380 , Text = defaultValue };
            var ok = new Button() { Text = "OK" , Left = 220 , Width = 80 , Top = 60 , DialogResult = DialogResult.OK };
            var cancel = new Button() { Text = "Отменить" , Left = 310 , Width = 80 , Top = 60 , DialogResult = DialogResult.Cancel };

            form.Controls.Add(label);
            form.Controls.Add(textBox);
            form.Controls.Add(ok);
            form.Controls.Add(cancel);
            form.AcceptButton = ok;
            form.CancelButton = cancel;

            return form.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }

}
