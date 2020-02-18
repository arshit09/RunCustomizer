using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace WindowsFormsApp1
{
    public partial class RunCustomizer : Form
    {

        public RunCustomizer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WshShellClass wsh = new WshShellClass();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(
                Environment.GetFolderPath(Environment.SpecialFolder.Windows)+"\\"+textBox1.Text+".lnk") as IWshRuntimeLibrary.IWshShortcut;
            shortcut.Arguments = "";
            shortcut.TargetPath = System.IO.Path.GetFullPath(openFileDialog1.FileName); 
            // not sure about what this is for
            shortcut.WindowStyle = 10;
            shortcut.Description = "Create customized Run command";
            //shortcut.WorkingDirectory = "C:\\TURBOC3\\Turbo C++\\";
            //shortcut.IconLocation = "RunCustomizer.ico";
            shortcut.Save();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //button2.Text = "File Path: ";
            //My initial directory location is desktop.
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Title = "Select file";
            //which type file format you want to upload
            //openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html)|*.pdf; *.txt; *.exe; *.docx; *.xlsx; *.html";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            //openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        label1.Text = "File path: "+path;
                        //Console.WriteLine("check");
                    }
                }
                //else
                //{
                //    MessageBox.Show("Upload document.");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
