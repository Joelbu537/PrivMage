using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivMage
{
    public class ArrowlessTabControl : TabControl
    {
        protected override bool IsInputKey(Keys keyData)
        {
            // Unterdrückt die Behandlung der Pfeiltasten als Navigation
            if (keyData == Keys.Left || keyData == Keys.Right)
            {
                return true; // Wird als normale Taste behandelt, nicht als Navigationsbefehl
            }
            return base.IsInputKey(keyData);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Optional: verhindert zusätzliche Verarbeitung durch das Control
            if (keyData == Keys.Left || keyData == Keys.Right)
            {
                return true; // handled: Keine Weiterverarbeitung
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
