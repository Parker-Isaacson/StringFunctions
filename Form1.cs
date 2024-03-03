using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        private void cmdToHex_Click(object sender, EventArgs e)
        {
            ToHex();
        }
        private void cmdFind_Click(object sender, EventArgs e)
        {
            Find();
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
        /// Outputs the index of parameters if input includes it. Parameters: "char", "string", "char, int", "string, int" "char, int, int", "string, int, int"
        /// </summary>
        private void IndexOf()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            string[] hobo = parameters.Split(',');
            int hobo_count = hobo.Count();
            for (int i = 0; i < hobo_count; i++)
                hobo[i] = hobo[i].Trim();
            if (input.Contains(hobo[0]))
            {
                switch (hobo_count)
                {
                    case 1:
                        txtOutput.Text = input.IndexOf(hobo[0]).ToString();
                        break;
                    case 2:
                        if (Int32.TryParse(hobo[1], out int startindex) && startindex < input.Length && startindex.IsPositive())
                            txtOutput.Text = input.IndexOf(hobo[0], startindex).ToString();
                        else
                            txtOutput.Text = "Input Could Not Be Converted To Int Or Larger Than Input";
                        break;
                    case 3:
                        if (Int32.TryParse(hobo[1], out int _startindex) && Int32.TryParse(hobo[2], out int count) && _startindex + count < input.Length && _startindex.IsPositive() && count.IsPositive())
                            txtOutput.Text = input.IndexOf(hobo[0], _startindex, count).ToString();
                        else
                            txtOutput.Text = "Inputs Could Not Be Converted To Int Or Larger Than Input";
                        break;
                        default:
                            txtOutput.Text = "Too Many Parameters";
                        break;
                }
            }
            else
                txtOutput.Text = "No Occurence";
        }
        /// <summary>
        /// Outputs the index of any parameters if input includes it. Parameters: "char[]", "char[], int", "char[], int, int"
        /// </summary>
        private void IndexOfAny()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains('{') && parameters.Contains('}'))
            {
                string _anyOf = parameters.Substring(parameters.IndexOf('{') + 1, parameters.IndexOf('}') - parameters.IndexOf('{') - 1);
                string[] __anyOf = _anyOf.Split(',');
                char[] anyOf = new char[__anyOf.Length];
                for (int i = 0; i < __anyOf.Length; i++)
                    if (char.TryParse(__anyOf[i].Trim(), out char foo))
                        anyOf[i] = foo;
                    else
                        txtOutput.Text = "Non Char Inputs In Array";
                string _params = parameters.Substring(parameters.IndexOf('}') + 1);
                if (_params.Contains(','))
                {
                    _params = _params.Substring(_params.IndexOf(',') + 1);
                    string[] hobo = _params.Split(',');
                    for (int i = 0; i < hobo.Length; i++)
                        hobo[i] = hobo[i].Trim();
                    switch (hobo.Length)
                    {
                        case 1:
                            if (Int32.TryParse(hobo[0], out int startindex) && startindex < input.Length && startindex.IsPositive())
                                txtOutput.Text = input.IndexOfAny(anyOf, startindex).ToString();
                            else
                                txtOutput.Text = "Could Not Make Int Or Larger Than Input";
                            break;
                        default:
                            if (Int32.TryParse(hobo[0], out int _startindex) && Int32.TryParse(hobo[1], out int _count) && _startindex + _count < input.Length && _startindex.IsPositive() && _count.IsPositive())
                                txtOutput.Text = input.IndexOfAny(anyOf, _startindex, _count).ToString();
                            else
                                txtOutput.Text = "Could Not Make Int Or Larger Than Input";
                            break;
                    }
                }
                else
                    txtOutput.Text = input.IndexOfAny(anyOf).ToString();
            }
            else if (parameters.Contains('{')  == false)
            {
                IndexOf();
            }
            else
                txtOutput.Text = "Could Not Parse";
        }
        /// <summary>
        /// Outputs parameters inserted into input when provided with start index of the input. Parameters: "string, int"
        /// </summary>
        private void Insert()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            string[] hobo = parameters.Split(',');
            if (Int32.TryParse(hobo[0].Trim(), out int startindex) && startindex.IsPositive())
                txtOutput.Text = input.Insert(startindex, hobo[1].Trim());
            else
                txtOutput.Text = "Input Not Integer";
        }
        /// <summary>
        /// Outputs the last index of parameters if input includes it. Parameters: "char", "string", "char, int", "string, int" "char, int, int", "string, int, int"
        /// </summary>
        private void LastIndexOf()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            string[] hobo = parameters.Split(',');
            int hobo_count = hobo.Count();
            for (int i = 0; i < hobo_count; i++)
                hobo[i] = hobo[i].Trim();
            if (input.Contains(hobo[0]))
            {
                switch (hobo_count)
                {
                    case 1:
                        txtOutput.Text = input.LastIndexOf(hobo[0]).ToString();
                        break;
                    case 2:
                        if (Int32.TryParse(hobo[1], out int startindex) && startindex < input.Length && startindex.IsPositive())
                            txtOutput.Text = input.LastIndexOf(hobo[0], startindex).ToString();
                        else
                            txtOutput.Text = "Input Could Not Be Converted To Int Or Larger Than Input";
                        break;
                    case 3:
                        if (Int32.TryParse(hobo[1], out int _startindex) && Int32.TryParse(hobo[2], out int count) && _startindex + count < input.Length && _startindex.IsPositive() && count.IsPositive())
                            txtOutput.Text = input.LastIndexOf(hobo[0], _startindex, count).ToString();
                        else
                            txtOutput.Text = "Inputs Could Not Be Converted To Int Or Larger Than Input";
                        break;
                    default:
                        txtOutput.Text = "Too Many Parameters";
                        break;
                }
            }
            else
                txtOutput.Text = "No Occurence";
        }
        /// <summary>
        /// Outputs the last index of any parameters if input includes it. Parameters: "char[]", "char[], int", "char[], int, int"
        /// </summary>
        private void LastIndexOfAny()
        {
            string input = txtInput.Text.ToString();
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains('{') && parameters.Contains('}'))
            {
                string _anyOf = parameters.Substring(parameters.IndexOf('{') + 1, parameters.IndexOf('}') - parameters.IndexOf('{') - 1);
                string[] __anyOf = _anyOf.Split(',');
                char[] anyOf = new char[__anyOf.Length];
                for (int i = 0; i < __anyOf.Length; i++)
                    if (char.TryParse(__anyOf[i].Trim(), out char foo))
                        anyOf[i] = foo;
                    else
                        txtOutput.Text = "Non Char Inputs In Array";
                string _params = parameters.Substring(parameters.IndexOf('}') + 1);
                if (_params.Contains(','))
                {
                    _params = _params.Substring(_params.IndexOf(',') + 1);
                    string[] hobo = _params.Split(',');
                    for (int i = 0; i < hobo.Length; i++)
                        hobo[i] = hobo[i].Trim();
                    switch (hobo.Length)
                    {
                        case 1:
                            if (Int32.TryParse(hobo[0], out int startindex) && startindex < input.Length && startindex.IsPositive())
                                txtOutput.Text = input.LastIndexOfAny(anyOf, startindex).ToString();
                            else
                                txtOutput.Text = "Could Not Make Int Or Larger Than Input";
                            break;
                        default:
                            if (Int32.TryParse(hobo[0], out int _startindex) && Int32.TryParse(hobo[1], out int _count) && _startindex + _count < input.Length && _startindex.IsPositive() && _count.IsPositive())
                                txtOutput.Text = input.LastIndexOfAny(anyOf, _startindex, _count).ToString();
                            else
                                txtOutput.Text = "Could Not Make Int Or Larger Than Input";
                            break;
                    }
                }
                else
                    txtOutput.Text = input.LastIndexOfAny(anyOf).ToString();
            }
            else if (parameters.Contains('{') == false)
            {
                LastIndexOf();
            }
            else
                txtOutput.Text = "Could Not Parse";
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
                if (Int32.TryParse(hobo[0].Trim(), out int value) && char.TryParse(hobo[1].Trim(), out char padder) && value.IsPositive())
                    txtOutput.Text = input.PadLeft(value, padder);
                else
                    txtOutput.Text = "Inputs Could Not Be Converted To Either Int or Char";
            }
            else
            {
                if (Int32.TryParse(parameters.Trim(), out int value) && value.IsPositive())
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
                if (Int32.TryParse(hobo[0].Trim(), out int value) && char.TryParse(hobo[1].Trim(), out char padder) && value.IsPositive())
                    txtOutput.Text = input.PadRight(value, padder);
                else
                    txtOutput.Text = "Inputs Could Not Be Converted To Either Int or Char";
            }
            else
            {
                if (Int32.TryParse(parameters.Trim(), out int value) && value.IsPositive())
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
                if (Int32.TryParse(hobo[0].Trim(), out int value) && Int32.TryParse(hobo[1].Trim(), out int count) && value + count < input.Length && value.IsPositive() && count.IsPositive())
                    txtOutput.Text = input.Remove(value, count);
                else
                    txtOutput.Text = "Input Could Not Be Converted To Int Or Longer Than Input";
            }
            else
            {
                if (Int32.TryParse(parameters.Trim(), out int value) && value < input.Length && value.IsPositive())
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
        /// Outputs input split with parameters. Parameters: "char[]", "char[], int", "string[]", "string[], int"
        /// </summary>
        private void Split()
        {
            string input = txtInput.Text.ToString(); //separator, count
            string parameters = txtParams.Text.ToString();
            if (parameters.Contains('{') && parameters.Contains('}'))
            {
                string _separator = parameters.Substring(parameters.IndexOf('{') + 1, parameters.IndexOf('}') - parameters.IndexOf('{') - 1);
                string[] __separator = _separator.Split(',');
                char[] separator = new char[__separator.Length];
                for (int i = 0; i < __separator.Length; i++)
                    if (char.TryParse(__separator[i].Trim(), out char foo))
                        separator[i] = foo;
                    else
                        txtOutput.Text = "Non Char Inputs In Array";
                string _params = parameters.Substring(parameters.IndexOf('}') + 1); //", int" or ""
                if (_params.Trim() == "")
                {
                    string[] output = input.Split(separator);
                    txtOutput.Clear();
                    foreach (string line in output)
                        txtOutput.Text += line + Environment.NewLine;
                }
                else if (_params.Contains(','))
                {
                    if (Int32.TryParse(_params.Substring(_params.IndexOf(',')).Trim(), out int count) && count.IsPositive())
                    {
                        string[] output = input.Split(separator, count);
                        txtOutput.Clear();
                        foreach (string line in output)
                            txtOutput.Text += line + Environment.NewLine;
                    }

                }
                else
                    txtOutput.Text = "Count Not Parse";
            }
            else
            {
                if (parameters.Contains(','))
                {
                    string[] hobo = parameters.Split(',');
                    if (Char.TryParse(hobo[0].Trim(), out char separator) && Int32.TryParse(hobo[1].Trim(), out int count) && count.IsPositive())
                    {
                        string[] output = input.Split(new[] { separator }, count);
                        txtOutput.Clear();
                        foreach (string line in output)
                            txtOutput.Text += line + Environment.NewLine;
                    }
                    else
                        txtOutput.Text = "Input Could Not Be Converted To Either Char or Int";
                }
                else
                {
                    parameters = parameters.Trim();
                    if (input.Contains(parameters))
                    {
                        if (Char.TryParse(parameters, out char separator))
                        {
                            string[] output = input.Split(separator);
                            txtOutput.Clear();
                            foreach (string line in output)
                                txtOutput.Text += line + Environment.NewLine;
                        }
                        else
                            txtOutput.Text = "Parameter Not A char";
                    }
                    else
                        txtOutput.Text = "txtInput.Text Does Not Contain Splitter";
                }
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
                if (Int32.TryParse(hobo[0].Trim(), out int startindex) && Int32.TryParse(hobo[1].Trim(), out int count) && startindex < input.Length && startindex + count < input.Length && startindex.IsPositive() && count.IsPositive())
                    txtOutput.Text = input.Substring(startindex, count);
                else
                    txtOutput.Text = "Could Not Make Integer Or Longer Than Input";
            }
            else
            {
                if (Int32.TryParse(parameters, out int startindex) && startindex < input.Length && startindex.IsPositive())
                    txtOutput.Text = input.Substring(startindex);
                else
                    txtOutput.Text = "Could Not Make Integer Or Longer Than Input";
            }
        }
        /// <summary>
        /// Outputs Input As Hex. Parameter: none
        /// </summary>
        private void ToHex()
        {
            string Spacer = (chkAddSpace.Checked) ? " " : "";
            char[] input = txtInput.Text.ToCharArray();
            txtOutput.Clear();
            foreach (char hobo in input)
                if (char.IsLetterOrDigit(hobo))
                {
                    if (chkUpperCase.Checked)
                        txtOutput.Text += Spacer + Convert.ToByte(hobo).ToString("x").ToUpper();
                    else
                        txtOutput.Text += Spacer + Convert.ToByte(hobo).ToString("x");
                }                    
        }
        /// <summary>
        /// Outputs The Count And Location Of Given Text. Parameter: "string"
        /// </summary>
        private void Find()
        {
            string input = txtInput.Text.ToString();
            string parameter = txtParams.Text.ToString().Trim();
            if (input.Contains(parameter) && parameter.Length < input.Length)
            {
                int count = 0;
                int window = 0;
                while (window + parameter.Length < input.Length)
                    if (input.Substring(window, parameter.Length) == parameter)
                    {
                        count++;
                        window += parameter.Length;
                    }
                    else
                        window++;
                if (count > 1)
                    txtOutput.Text = $"\'{input}\' Contains \'{parameter}\' {count} times";
                else
                    txtOutput.Text = $"\'{input}\' Contains \'{parameter}\' {count} time";
            }
            else
                txtOutput.Text = "Not Contained By Input";
        }
        #endregion
    }
    /// <summary>
    /// Class For Checking Properties Of Different Vars
    /// </summary>
    public static class DataExtensions
    {
        /// <summary>
        /// Returns True If Attached Integer Is Positive, False If Negative
        /// </summary>
        /// <param name="hobo"></param>
        /// <returns></returns>
        public static bool IsPositive(this int hobo)
        {
            if (hobo < 0)
                return false;
            else
                return true;
        }
    }
}
