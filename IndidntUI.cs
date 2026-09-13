using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndidntUI
{
    public partial class Indidnt : Form
    {
        public Indidnt()
        {
            InitializeComponent();
        }

        private void convertIndentButton_Click(object sender, EventArgs e)
        {
            inputText.Text = ConvertToIndentation(inputText.Text);
        }
        private void convertBracketButton_Click(object sender, EventArgs e)
        {
            inputText.Text = ConvertToBracketed(inputText.Text);
        }

        public static string ConvertToIndentation(string filepath)
        {
            // Read File and put into list
            var fileLines = filepath.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);

            List<string> lines = new List<string>();

            foreach (var line in fileLines)
            {
                lines.Add(line);
            }

            int spacesPerIndent = 1;

            List<int> indents = new List<int>();
            for (int i = 0; i < lines.Count; i++)
            {
                // Set whitespace lines to an indent of -1, so we can ignore them later
                if (lines[i].Length == 0) { indents.Add(-1); continue; }

                // Tab count check
                string text = lines[i];
                char search = ' ';

                // Recalibrate convention
                char firstChar = lines[i][0];
                if (firstChar == ' ') { search = ' '; spacesPerIndent = 4; }
                else if (firstChar == '\t') { search = '\t'; }
                else { indents.Add(0); continue; }

                // Search for number of indents
                int count = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] != search)
                    {
                        break;
                    }
                    count++;
                }

                count /= spacesPerIndent;

                // Add that number to the indents list
                indents.Add(count);
            }

            // Rebuild file, ignoring brackets
            List<string> fixedLines = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                if (indents[i] == -1) { fixedLines.Add(lines[i]); continue; }

                // If we trim the line, and all that is there is { or } then we just skip and go about our day
                if (lines[i].Trim().Equals("}") || lines[i].Trim().Equals("{"))
                {
                    continue;
                }
                fixedLines.Add(lines[i]);
            }

            // Rebuild script
            string returnlines = "";
            for (int pr = 0; pr < fixedLines.Count; pr++)
            {
                returnlines += fixedLines[pr];
                returnlines += "\r\n";
            }
            return returnlines;
        }

        public static string ConvertToBracketed(string filePath)
        {
            // Read File and put into list
            var fileLines = filePath.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);

            List<string> lines = new List<string>();

            foreach (var line in fileLines)
            {
                lines.Add(line);
            }

            int spacesPerIndent = 1;

            List<int> indents = new List<int>();
            for (int i = 0; i < lines.Count; i++)
            {
                // Set whitespace lines to an indent of -1, so we can ignore them later
                if (lines[i].Length == 0) { indents.Add(-1); continue; }

                // Tab count check
                string text = lines[i];
                char search = ' ';

                // Recalibrate convention
                char firstChar = lines[i][0];
                if (firstChar == ' ') { search = ' '; spacesPerIndent = 4; }
                else if (firstChar == '\t') { search = '\t'; }
                else { indents.Add(0); continue; }

                // Search for number of indents
                int count = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] != search)
                    {
                        break;
                    }
                    count++;
                }

                count /= spacesPerIndent;

                // Add that number to the indents list
                indents.Add(count);
            }

            // Insert the brackets based on the change in indents
            List<string> fixedLines = new List<string>();
            int prevIndent = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                // Ignore whitespace lines
                if (indents[i] == -1)
                {
                    fixedLines.Add(lines[i]);
                    continue;
                }

                // If there is a higher level indentaion found
                if (prevIndent < indents[i])
                {
                    string brackIndent = new string(' ', prevIndent * spacesPerIndent);
                    fixedLines.Add(brackIndent + "{");
                }

                // If there is a lower level indentaion found
                if (prevIndent > indents[i])
                {
                    if (indents[i] == 0)
                    {
                        fixedLines.Add("}");
                    }
                    else
                    {
                        int indentLayers = prevIndent - indents[i];

                        for (int l = indentLayers; l > 0; l--)
                        {
                            string brackIndent = new string(' ', l * spacesPerIndent);
                            fixedLines.Add(brackIndent + "}");
                        }
                    }
                }

                string lineIndent = new string(' ', indents[i] * spacesPerIndent);
                fixedLines.Add(lineIndent + lines[i].Trim());
                prevIndent = indents[i];
            }

            // Rebuild script
            string returnlines = "";
            for (int pr = 0; pr < fixedLines.Count; pr++)
            {
                returnlines += fixedLines[pr];
                returnlines += "\r\n";
            }
            return returnlines;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/kevinbbrothers/Indidnt");
        }
    }
}
