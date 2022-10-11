using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalculator
{
    public partial class Form1 : Form
    {
        //Token tk = new Token();
        ExpressionHandler expressionHandler;
        public Form1()
        {
            InitializeComponent();
            expressionHandler = new ExpressionHandler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {

        }

        
        // Number button for "0" zero
        private void button1_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.zero));
            DisplayExpression();
        }
        // Number button for "1" one
        private void button2_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.one));
            DisplayExpression();
        }
        // Number button for "2" two
        private void button3_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.two));
            DisplayExpression();
        }
        // Number button for "3" three
        private void button4_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.three));
            DisplayExpression();
        }
        // Number button for "6" six
        private void button5_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.six));
            DisplayExpression();
        }
        // Number button for "5" five
        private void button6_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.five));
            DisplayExpression();
        }
        // Number button for "4" four
        private void button7_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.four));
            DisplayExpression();
        }
        // Number button for "9" nine
        private void button8_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.nine));
            DisplayExpression();
        }
        // Number button for "8" eight
        private void button9_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.eight));
            DisplayExpression();
        }
        // Number button for "7" seven
        private void button10_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.seven));
            DisplayExpression();
        }
        // Number button for "." decimalpoint
        private void button11_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Number(Number.Digits.decimalpoint));
            DisplayExpression();
        }
        // Token button for unary operator "log10" 
        private void button12_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.log10));
            expressionHandler.AddToken(new Token(Token.TokenTypes.openparen));
            DisplayExpression();
        }
        // Token button for binary operator "*" multiply
        private void button13_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.multiply));
            DisplayExpression();
        }
        // Token button for unary/binary operator "-" minus
        private void button14_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.minus));
            DisplayExpression();
        }
        // Token button for binary operator "+" plus
        private void button15_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.plus));
            DisplayExpression();
        }
        // Token button for unary operator "sin"
        private void button16_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.sin));
            expressionHandler.AddToken(new Token(Token.TokenTypes.openparen));
            DisplayExpression();
        }
        // Token button for binary operator "^" power
        private void button17_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.power));
            DisplayExpression();
        }
        // Token button for binary operator "/" divide
        private void button18_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.divide));
            DisplayExpression();
        }
        // Token button for unary operator "cot"
        private void button19_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.cot));
            expressionHandler.AddToken(new Token(Token.TokenTypes.openparen));
            DisplayExpression();
        }
        // Token button for unary operator "tan"
        private void button20_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.tan));
            expressionHandler.AddToken(new Token(Token.TokenTypes.openparen));
            DisplayExpression();
        }
        // Token button for unary operator "cos"
        private void button21_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.cos));
            expressionHandler.AddToken(new Token(Token.TokenTypes.openparen));
            DisplayExpression();
        }
        // Token button for unary operator "ln"
        private void button22_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.ln));
            expressionHandler.AddToken(new Token(Token.TokenTypes.openparen));
            DisplayExpression();
        }
        // Token button for ")" closedparen
        private void button23_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.closedparen));
            DisplayExpression();
        }
        // Token button for "(" openparen
        private void button24_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.openparen));
            DisplayExpression();
        }
        // Token button for "}" closedbracket
        private void button25_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.closedbracket));
            DisplayExpression();
        }
        // Token button for "{" openbracket
        private void button26_Click(object sender, EventArgs e)
        {
            expressionHandler.AddToken(new Token(Token.TokenTypes.openbracket));
            DisplayExpression();
        }
        // The "=" button for running our expression
        private void button27_Click(object sender, EventArgs e)
        {
            expressionHandler.EvaluateExpression();
            textBox1.Text = expressionHandler.PrintExpression(); // for demonstration purposes
            DisplayExpression();
        }

        private void DisplayExpression()
        {
            textBox1.Text = expressionHandler.PrintExpression();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            expressionHandler = new ExpressionHandler();
            DisplayExpression();
        }
    }
}
