using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Helper_SortProjects.SortProjects.Controller;
using Helper_SortProjects.SortProjects.GUI;
using Helper_SortProjects.SortProjects.Models;

namespace Helper_SortProjects {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GUIView view = new GUIView();
            GUIController controller = new GUIController(view); //Controller is saved in view as reference
            view.AddListener(controller);

            Application.Run(view);
        }
    }
}
