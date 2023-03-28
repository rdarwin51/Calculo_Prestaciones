using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Calcule_Prest
{
    class presdtacalc
    {
        public string Recup_Dep(ComboBox cb)
        {
            
            string line;
            int counter = 0;
            //string[] datos;

            // Read the file and display it line by line.  
            StreamReader file = new StreamReader(Application.StartupPath +  "\\dep.txt");
            while ((line = file.ReadLine()) != null)
            {
                cb.Items.Add(line);
                counter++;
            }
            file.Close();
            return cb.Items.ToString();
        }

    }
}
