using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelDesigner
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }
        public void Colorize()
        {
            //string tokens = @"(\^XA|\^XA|\^FD|\^FS|\^XZ|\^A|\^CF|\^GB|\^FO|\^BY|  
            //                  \^BC|\^BQ|\^GF)";  
            //Regex rex = new Regex(tokens);
            //    MatchCollection mc = rex.Matches(richTextBox1.Text);
            //    int StartCursorPosition = richTextBox1.SelectionStart;  
            //foreach (Match m in mc)  
            //{  
            //    int startIndex = m.Index;
            //    int StopIndex = m.Length;
            //    richTextBox1.Select(startIndex, StopIndex);  
            //    richTextBox1.SelectionColor = Color.Blue;
            //    richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            //    StartCursorPosition = richTextBox1.SelectionStart;
            //    richTextBox1.SelectionStart = StartCursorPosition + StopIndex;
            //    richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            //    richTextBox1.SelectionColor = Color.Black;  
            //}

            string[] tokens = new string[] { "^XA", "^FD", "^FS", "^XZ", "^A", "^CF", "^GB", "^FO", "^BY", "^BC", "^BQ", "^GF" };

            richTextBox1.Select(0, richTextBox1.Text.Length);
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;

            foreach (string token in tokens)
            {
                List<int> indexes = AllIndexesOf(richTextBox1.Text, token);
                foreach (int index in indexes)
                {
                    richTextBox1.Select(index, token.Length);
                    richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                    richTextBox1.SelectionColor = Color.Blue;
                }
            }

            tokens = new string[] { "^FD"};
            foreach (string token in tokens)
            {
                List<int> indexes = AllIndexesOf(richTextBox1.Text, token);
                foreach (int index in indexes)
                {
                    richTextBox1.Select(index, token.Length);
                    richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                    richTextBox1.SelectionColor = Color.DarkGreen;
                    int newIndex = richTextBox1.Text.IndexOf("^FS", index);
                    int nextEnter = richTextBox1.Text.IndexOf("\n", index);
                    if (newIndex< nextEnter)
                    {
                        richTextBox1.Select(newIndex, 3);
                        richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                        richTextBox1.SelectionColor = Color.DarkGreen;

                        richTextBox1.Select(index + 3, newIndex - (index + 3));
                        richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
                        richTextBox1.SelectionColor = Color.DarkOrange;
                    }
                }
            }

            richTextBox1.Select(0, 0);
        }

        private List<int> AllIndexesOf(string str, string value)
        {
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}
