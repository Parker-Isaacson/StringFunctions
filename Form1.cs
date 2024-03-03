using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StringFunctions
{
    public partial class Form1 : Form
    {
        #region Button Clicks
        public Form1()
        {
            InitializeComponent();
        }
        // Aggregate needs to be done
        // All needs to be done
        // Any needs to be done
        private void cmdTest_Click(object sender, EventArgs e)
        {
            char[] input = txtInput.Text.ToCharArray();
            string output = new string(input);
        }
        private void cmdContains_Click(object sender, EventArgs e)
        {
            Contains();
        }
        private void cmdEndsWith_Click(object sender, EventArgs e)
        {
            EndsWith();
        }
        private void cmdIndexOf_Click(object sender, EventArgs e)
        {
            IndexOf();
        }
        private void cmdIndexOfAny_Click(object sender, EventArgs e)
        {
            IndexOfAny();
        }
        private void cmdInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }
        private void cmdLastIndexOf_Click(object sender, EventArgs e)
        {
            LastIndexOf();
        }
        private void cmdLastIndexOfAny_Click(object sender, EventArgs e)
        {
            LastIndexOfAny();
        }
        private void cmdPadLeft_Click(object sender, EventArgs e)
        {
            PadLeft();
        }
        private void cmdPadRight_Click(object sender, EventArgs e)
        {
            PadRight();
        }
        private void cmdRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }
        private void cmdReplace_Click(object sender, EventArgs e)
        {
            Replace();
        }
        private void cmdSplit_Click(object sender, EventArgs e)
        {
            Split();
        }
        private void cmdStartsWith_Click(object sender, EventArgs e)
        {
            StartsWith();
        }
        private void cmdSubstring_Click(object sender, EventArgs e)
        {
            SubString();
        }
        #endregion
        // tookie

        #region methods
        /// <summary>
        /// Outputs True or False depending on if input contains parameters. Parameters: "string"
        /// </summary>
        private void Contains()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            txtOutput.Text = input.Contains(parameters).ToString();
        }
        /// <summary>
        /// Outputs True or False depending on if input ends with parameters. Parameters: "string"
        /// </summary>
        private void EndsWith()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            txtOutput.Text = input.EndsWith(parameters).ToString();
        }
        /// <summary>
        /// Outputs the index of parameters if input includes it. Parameters: "string"
        /// </summary>
        private void IndexOf()
        {
            string input = txtInput.Text.ToString();
            char[] parameters = txtParams.Text.ToCharArray();
            if (input.Contains(parameters[0]))
                txtOutput.Text = input.IndexOf(parameters[0]).ToString();
            else
                txtOutput.Text = "No Occurence";
        }
        /// <summary>
        /// Outputs the index of any parameters if input includes it. Parameters: "string"
        /// </summary>
        private void IndexOfAny()
        {
            string input = txtInput.Text.ToString();
            char[] parameters = txtParams.Text.ToCharArray();
            for (int i = 0; i < parameters.Length; i++)
            {
                if (input.Contains(parameters[i]))
                {
                    txtOutput.Text = input.IndexOfAny(parameters).ToString();
                    return;
                }
            }   
            txtOutput.Text = "No Occurence";
        }
        /// <summary>
        /// Outputs parameters inserted into input when provided with start index of the input. Parameters: "string, int"
        /// </summary>
        private void Insert()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            string[] hobo = parameters.Split(',');
            hobo[0] = hobo[0].Trim();
            hobo[1] = hobo[1].Trim();
            if (Int32.TryParse(hobo[0], out int startindex))
                txtOutput.Text = input.Insert(startindex, hobo[1]);
            else
                txtOutput.Text = "Input Not Integer";
        }
        /// <summary>
        /// Outputs the last index of parameters if input includes it. Parameters: "string"
        /// </summary>
        private void LastIndexOf()
        {
            string input = txtInput.Text.ToString();
            char[] parameters = txtParams.Text.ToCharArray();
            if (input.Contains(parameters[0]))
                txtOutput.Text = input.LastIndexOf(parameters[0]).ToString();
            else
                txtOutput.Text = "No Occurence";
        }
        /// <summary>
        /// Outputs the last index of any parameters if input includes it. Parameters: "string"
        /// </summary>
        private void LastIndexOfAny()
        {
            string input = txtInput.Text.ToString();
            char[] parameters = txtParams.Text.ToCharArray();
            for (int i = 0; i < parameters.Length; i++)
            {
                if (input.Contains(parameters[i]))
                {
                    txtOutput.Text = input.LastIndexOfAny(parameters).ToString();
                    return;
                }
            }
            txtOutput.Text = "No Occurence";
        }
        /// <summary>
        /// Outputs input but left padded. Parameters: "int", "int, char"
        /// </summary>
        private void PadLeft()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains(','))
            {
                string[] hobo = parameters.Split(',');
                hobo[0] = hobo[0].Trim();
                hobo[1] = hobo[1].Trim();
                if (Int32.TryParse(hobo[0], out int value) && char.TryParse(hobo[1], out char padder))
                    txtOutput.Text = input.PadLeft(value, padder);
                else
                    txtOutput.Text = "Inputs Could Not Be Converted To Either Int or Char";
            }
            else
            {
                parameters.Trim();
                if (Int32.TryParse(parameters, out int value))
                    txtOutput.Text = input.PadLeft(value);
                else
                    txtOutput.Text = "Input Could Not Be Converted To Int";
            }
        }
        /// <summary>
        /// Outputs input but right padded. Parameters: "int", "int, char"
        /// </summary>
        private void PadRight()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains(','))
            {
                string[] hobo = parameters.Split(',');
                hobo[0] = hobo[0].Trim();
                hobo[1] = hobo[1].Trim();
                if (Int32.TryParse(hobo[0], out int value) && char.TryParse(hobo[1], out char padder))
                    txtOutput.Text = input.PadRight(value, padder);
                else
                    txtOutput.Text = "Inputs Could Not Be Converted To Either Int or Char";
            }
            else
            {
                parameters.Trim();
                if (Int32.TryParse(parameters, out int value))
                    txtOutput.Text = input.PadRight(value);
                else
                    txtOutput.Text = "Input Could Not Be Converted To Int";
            }
        }
        /// <summary>
        /// Outputs input after removing parameters. Parameters: "int", "int, int"
        /// </summary>
        private void Remove()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains(','))
            {
                string[] hobo = parameters.Split(',');
                hobo[0] = hobo[0].Trim();
                hobo[1] = hobo[1].Trim();
                if (Int32.TryParse(hobo[0], out int value) && Int32.TryParse(hobo[1], out int count) && value + count < input.Length)
                    txtOutput.Text = input.Remove(value, count);
                else
                    txtOutput.Text = "Input Could Not Be Converted To Int Or Longer Than Input";
            }
            else
            {
                parameters.Trim();
                if (Int32.TryParse(parameters, out int value) && value < input.Length)
                    txtOutput.Text = input.Remove(value);
                else
                    txtOutput.Text = "Input Could Not Be Converted To Int Or Longer Than Input";

            }
        }
        /// <summary>
        /// Outputs input while replacing respective values of parameters. Parameters: "char, char", "string, string"
        /// </summary>
        private void Replace()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains(','))
            {
                string[] hobo = parameters.Split(',');
                hobo[0] = hobo[0].Trim();
                hobo[1] = hobo[1].Trim();
                if (parameters.Contains(hobo[0]))
                {
                    if (Char.TryParse(hobo[0], out char oldChar) && Char.TryParse(hobo[1], out char newChar))
                        txtOutput.Text = input.Replace(oldChar, newChar);
                    else
                        txtOutput.Text = input.Replace(hobo[0], hobo[1]);
                }
                else
                    txtOutput.Text = "Does Not Contain oldChar";
            }
            else
                txtOutput.Text = "Not Enough Parameters";
        }
        /// <summary>
        /// Outputs input split with parameters. Parameters: "char", "char[]", "char, int", "char[], int", "string", "string[]", "string, int", "string[], int"
        /// </summary>
        private void Split()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains(','))
            {
                string[] hobo = parameters.Split(',');
                hobo[0] = hobo[0].Trim();
                hobo[1] = hobo[1].Trim();
                if (Char.TryParse(hobo[0], out char spliiter) && Int32.TryParse(hobo[1], out int count))
                {
                    string[] output = input.Split(spliiter);
                    txtOutput.Clear();
                    foreach (string line in output)
                    {
                        txtOutput.Text += line + Environment.NewLine;
                    }
                }
                else
                    txtOutput.Text = "Input Could Not Be Converted To Either Char or Int";
            }
            else
            {
                parameters = parameters.Trim();
                if (input.Contains(parameters))
                {
                    if (Char.TryParse(parameters, out char splitter))
                    {
                        string[] output = input.Split(splitter);
                        txtOutput.Clear();
                        foreach (string line in output)
                        {
                            txtOutput.Text += line + Environment.NewLine;
                        }
                    }
                    else
                        txtOutput.Text = "Parameter Not A char";
                }
                else
                    txtOutput.Text = "txtInput.Text Does Not Contain Splitter";
            }
        }
        /// <summary>
        /// Outputs True or False depending on if input ends with parameters. Parameters: "string"
        /// </summary>
        private void StartsWith()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            txtOutput.Text = input.StartsWith(parameters).ToString();
        }
        /// <summary>
        /// Outputs the substring of input depending on parameters. Parameters: "int", "int, int"
        /// </summary>
        private void SubString()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains(','))
            {
                string[] hobo = parameters.Split(',');
                hobo[0] = hobo[0].Trim();
                hobo[1] = hobo[1].Trim();
                if (Int32.TryParse(hobo[0], out int startindex) && Int32.TryParse(hobo[1], out int count) && startindex < input.Length && startindex + count < input.Length)
                    txtOutput.Text = input.Substring(startindex, count);
                else
                    txtOutput.Text = "Could Not Make Integer Or Longer Than Input";
            }
            else
            {
                if (Int32.TryParse(parameters, out int startindex) && startindex < input.Length)
                    txtOutput.Text = input.Substring(startindex);
                else
                    txtOutput.Text = "Could Not Make Integer Or Longer Than Input";
            }
        }
        #endregion
    }
}
