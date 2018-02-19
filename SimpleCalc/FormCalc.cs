using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class FormCalc : Form
    {
        public enum Mode
        {
            Add = 0,
            Minus,
            Multi,
            Div
        }

        private Mode CurrentMode;

        public string GetModeString(Mode mode)
        {
            switch (mode)
            {
                case Mode.Add:
                    return "+";
                case Mode.Minus:
                    return "-";
                case Mode.Multi:
                    return "×";
                case Mode.Div:
                    return "÷";
                default:
                    return "undefind";
            }
        }

        public FormCalc()
        {
            InitializeComponent();
        }

        public static void Open(Mode mode)
        {
            var f = new FormCalc();
            f.CurrentMode = mode;
            f.ModeLabel.Text = f.GetModeString(mode);
            f.ShowDialog();
        }

        private double CalcAnswer(Mode m, double v1, double v2)
        {
            switch (m)
            {
                case Mode.Add:
                    return v1 + v2;
                case Mode.Minus:
                    return v1 - v2;
                case Mode.Multi:
                    return v1 * v2;
                case Mode.Div:
                    return v1 / v2;
                default:
                    return 0;
            }
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            var v1 = Double.Parse(this.Input_1.Text);
            var v2 = Double.Parse(this.Input_2.Text);
            this.AnswerTextbox.Text = this.CalcAnswer(this.CurrentMode, v1, v2).ToString();
        }
    }
}