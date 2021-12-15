using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyScintificCalculator.RPN;

namespace MyScintificCalculator
{
    public partial class Form1 : Form
    {
 
        Calculator calculator;
        int cursorIndex;
        string newText;
        List<String> InputHistory = new List<string>();
        int historyPointer = 0;
        bool isNewinput = false;

        public Form1()
        {
            InitializeComponent();
            ActiveControl = tbInput;
            calculator = new Calculator();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isButtonAns(Button btn_)
        {
            return ((btn_ == btnAns));
        }

        private bool isButtonBackSpace(Button btn_)
        {
            return ((btn_ == btnBackspace));
        }

        private bool isButtonNumberPad(Button btn_)
        {
            return ((btn_ == btnNum0) || (btn_ == btnNum1) || (btn_ == btnNum2) || (btn_ == btnNum3)
                || (btn_ == btnNum4) || (btn_ == btnNum5) || (btn_ == btnNum6) || (btn_ == btnNum7)
                || (btn_ == btnNum8) || (btn_ == btnNum9));
        }

        private bool isButtonOperand(Button btn_)
        {
            return ((btn_ == btnPlus) || (btn_ == btnMinus) || (btn_ == btnMultiply) || (btn_ == btnDivide) || (btn_ == btnExponent)
                || (btn_ == btnDot) || (btn_ == btnOpenParenthesis) || (btn_ == btnCloseParenthesis) || (btn_ == btnPi) || (btn_ == btnEulersConstant));
        }

        private bool isButtonTrigonometricFunction(Button btn_)
        {
            return ((btn_ == btnSin) || (btn_ == btnCos) || (btn_ == btnTan));
        }

        private bool isButtonInverseTrigonometricFunction(Button btn_)
        {
            return ((btn_ == btnArcSin) || (btn_ == btnArcCos) || (btn_ == btnArcTan));
        }

        private bool isButtonSquareRoot(Button btn_)
        {
            return ((btn_ == btnSqrt));
        }

        private bool isButtonLog10(Button btn_)
        {
            return ((btn_ == btnLog10));
        }

        private bool isButtonNthRoot(Button btn_)
        {
            return ((btn_ == btnNthRoot));
        }

        private bool isButtonLogToTheBaseOf(Button btn_)
        {
            return ((btn_ == btnLogToThenBaseOf));
        }

        private bool isButtonFactorial(Button btn_)
        {
            return ((btn_ == btnFactorial));
        }

        private bool isButtonLn(Button btn_)
        {
            return ((btn_ == btnLn));
        }

        private bool isButtonEulersConstant(Button btn_)
        {
            return ((btn_ == btnEulersConstant));
        }

        private bool isButtonXSquared(Button btn_)
        {
            return ((btn_ == btnXSquared));
        }
        private bool isButtonXCubed(Button btn_)
        {
            return ((btn_ == btnXCubed));
        }
        private bool isButtonReciprocal(Button btn_)
        {
            return ((btn_ == btnReciprocal));
        }
        private bool isButtonScientificNotaion(Button btn_)
        {
            return ((btn_ == btnScientificNotation));
        }
        private String returnButtonStringDisplay(Button btn_, ref int cursorOffset)
        {
            if(isButtonNumberPad(btn_) || isButtonOperand(btn_))
            {
                cursorOffset = 1;
                return btn_.Text;
            }
            else if(isButtonTrigonometricFunction(btn_))
            {
                cursorOffset = 4;
                return btn_.Text + "()";
            }

            else if(isButtonInverseTrigonometricFunction(btn_))
            {
                cursorOffset = 7;
                string func = btn_.Text.Substring(0, 3);
                return "arc" + func + "()";
            }
            else if(isButtonLog10(btn_))
            {
                cursorOffset = 4;
                return "log()";
            }
            else if(isButtonSquareRoot(btn_))
            {
                cursorOffset = 2;
                return "√()";
            }
            else if (isButtonLogToTheBaseOf(btn_))
            {
                cursorOffset = 4;
                return "log[]()";
            }
            else if (isButtonNthRoot(btn_))
            {
                cursorOffset = 2;
                return "√[]()";
            }
            else if(isButtonFactorial(btn_))
            {
                cursorOffset = 1;
                return "!";
            }
            else if(isButtonLn(btn_))
            {
                cursorOffset = 3;
                return "ln()";
            }
            else if (isButtonXSquared(btn_))
            {
                cursorOffset = 1;
                return "()^2";
            }
            else if (isButtonXCubed(btn_))
            {
                cursorOffset = 1;
                return "()^3";
            }
            else if (isButtonReciprocal(btn_))
            {
                cursorOffset = 3;
                return "1/()";
            }
            else if (isButtonScientificNotaion(btn_))
            {
                cursorOffset = 5;
                return "*10^()";
            }
            else if (isButtonAns(btn_))
            {
                cursorOffset = tbResult.Text.Length + 2;
                return (tbResult.Text != "") ? "(" + tbResult.Text + ")" : "";
            }
            else
            {
                cursorOffset = 0;
                return "";
            }
        }

        private void getResult()
        {
            string result = calculator.calculate(tbInput.Text, out Color color);
            tbResult.ForeColor = color;
            tbResult.Text = result;
            if(result != "invalid syntax")
            {
                InputHistory.Add(tbInput.Text);
                historyPointer = InputHistory.Count;
            }

            isNewinput = true;
            
        }



        private String insertUserInput(int cursorIndex, Button btn_, ref int cursorOffset)
        {
            if (isButtonBackSpace(btn_))
            {
                if ((tbInput.Text.Length > 0) && (cursorIndex != 0))
                {
                    cursorOffset = -1;
                    return tbInput.Text.Remove(cursorIndex - 1, 1);
                }
                else
                {
                    cursorOffset = 0;
                    return "";
                    //return tbInput.Text.Substring(0, cursorIndex) + "" + tbInput.Text.Substring(cursorIndex, tbInput.Text.Length - cursorIndex);
                }

            }
            else
            {
                return tbInput.Text.Substring(0, cursorIndex) + returnButtonStringDisplay(btn_, ref cursorOffset) + tbInput.Text.Substring(cursorIndex, tbInput.Text.Length - cursorIndex);
            }
        }
        private void btnArrow_clicked(object sender, EventArgs e)
        {
            Button btn_ = (Button)sender;
            ActiveControl = tbInput;

            if ((btn_ == btnArrowLeft) && (tbInput.SelectionStart != 0))
            {
                tbInput.SelectionStart -= 1;
            }
            else if (btn_ == btnArrowRight)
            {
                tbInput.SelectionStart += 1;
            }
            else if ((btn_ == btnArrowUp))
            {
                if ((historyPointer > 0))
                {
                    historyPointer--;
                    tbInput.Text = InputHistory[historyPointer];
                }
                else if ((historyPointer == 0) && (InputHistory.Count != 0))
                {
                    historyPointer = InputHistory.Count -1;
                    tbInput.Text = InputHistory[historyPointer];
                }
                
                tbInput.SelectionStart = tbInput.Text.Length;
                //MessageBox.Show(historyPointer.ToString());
            }
            else if(btn_ == btnArrowDown)
            {
                if(historyPointer < InputHistory.Count -1)
                {
                    //historyPointer = 0;
                    historyPointer++;
                    tbInput.Text = InputHistory[historyPointer];

                    //MessageBox.Show("if");
                    
                }
                else if(((historyPointer == InputHistory.Count - 1) || (historyPointer == InputHistory.Count)) && (InputHistory.Count != 0))
                {
                    historyPointer = 0;
                    tbInput.Text = InputHistory[historyPointer];

                }
                else
                {
                    //historyPointer++;
                    //MessageBox.Show("else");
                }
                //MessageBox.Show(historyPointer.ToString());
                tbInput.SelectionStart = tbInput.Text.Length;
            }


        }

        private void on_click_clear(object sender, EventArgs e)
        {
            clearTBInput();
        }

        private void clearTBInput()
        {
            tbInput.Clear();
            ActiveControl = tbInput;
        }

        private void ifNewInput()
        {
            if (isNewinput)
            {
                clearTBInput();
                isNewinput = false;
                
            }
            historyPointer = InputHistory.Count;
        }
        private void on_click_equal(object sender, EventArgs e)
        {
            getResult();
        }

        private void calculatorButtonsClicked(object sender, EventArgs e)
        {
            Button btn_ = (Button)sender;
            int cursorOffset = 0;

            ifNewInput();

            cursorIndex = tbInput.SelectionStart;
            tbInput.Text = insertUserInput(cursorIndex, btn_, ref cursorOffset);
            tbInput.SelectionStart = cursorIndex + cursorOffset;
            tbInput.SelectionLength = 0;
            ActiveControl = tbInput;

            
        }


        private void tbResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            ifNewInput();

            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != '^') && (e.KeyChar != '*') && (e.KeyChar != '/') && (e.KeyChar != '+') && (e.KeyChar != '-')
                && (e.KeyChar.ToString() != ".") && (e.KeyChar != '(') && (e.KeyChar != ')') && (e.KeyChar != (char)Keys.Back))
            {
                
                e.Handled = true;
            }

            if(e.KeyChar == (char)Keys.Enter)
            {
                getResult();
            }
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
        }

        private void tbInput_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveControl = tbInput;

            tbInput.SelectionStart += 1;

        }
        
        

        
    }
}
