using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITC102_1
{
    public partial class Form1 : Form
    {
        private TextBox[,] arrayOfEnterData, arrayOfWeight, arrayOfTopLeft;

        public Form1()
        {
            InitializeComponent();
            this.arrayOfEnterData = new TextBox[6, 6];
            this.arrayOfWeight = new TextBox[3, 3];
            this.arrayOfTopLeft = new TextBox[2, 1];
            FillTextBoxToArray(this.arrayOfEnterData);
            FillTextBoxToArray(this.arrayOfWeight);
            FillTextBoxToArray(this.arrayOfTopLeft);
            SetTextBoxArrayLocation(this.arrayOfEnterData);
            SetTextBoxArrayLocation(this.arrayOfWeight);
            SetTextBoxArrayLocation(this.arrayOfTopLeft);
        }

        public void FillTextBoxToArray(TextBox[,] textBoxes)
        {
            int oneDimension, twoDimension;
            oneDimension = textBoxes.GetLength(0);
            twoDimension = textBoxes.GetLength(1);
            for(int i = 0; i < oneDimension; i++)
            {
                for(int j = 0; j < twoDimension; j++)
                {
                    textBoxes[i, j] = new TextBox();
                }
            }
        }

        public void SetTextBoxArrayLocation(TextBox[,] textBoxes)
        {
            int oneDimension, twoDimension;
            oneDimension = textBoxes.GetLength(0);
            twoDimension = textBoxes.GetLength(1);
            for(int i = 0; i < oneDimension; i++)
            {
                for(int j = 0; j < twoDimension; j++)
                {
                    textBoxes[i, j].Location = new Point(10 + i * 32, 20 + j * 32);
                }
            }
        }

        
    }
}
