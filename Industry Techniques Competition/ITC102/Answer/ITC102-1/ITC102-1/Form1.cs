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
        private Object[] textBoxArray;
        private TextBox[,] textBoxArrayOfEnterData, textBoxArrayOfWeight, textBoxArrayOfTopLeft, textBoxArrayOfAnswer;
        private GroupBox[] groupBoxArray;

        public Form1()
        {
            InitializeComponent();
            AddTextBoxToEachGroupBox();
        }

        public void AddTextBoxToEachGroupBox()
        {
            this.textBoxArrayOfEnterData = new TextBox[6, 6];
            this.textBoxArrayOfWeight = new TextBox[3, 3];
            this.textBoxArrayOfTopLeft = new TextBox[2, 1];
            this.textBoxArrayOfAnswer = new TextBox[1, 1];
            this.textBoxArray = new Object[4] { this.textBoxArrayOfEnterData, this.textBoxArrayOfWeight, this.textBoxArrayOfTopLeft, this.textBoxArrayOfAnswer };
            this.groupBoxArray = new GroupBox[4] { this.groupBox1, this.groupBox2, this.groupBox3, this.groupBox4 };
            byte oneDimension, twoDimension;
            for (byte h = 0; h < 4; h++)
            {
                oneDimension = (byte)((TextBox[,])textBoxArray[h]).GetLength(0);
                twoDimension = (byte)((TextBox[,])textBoxArray[h]).GetLength(1);
                for (byte i = 0; i < oneDimension; i++)
                {
                    for (byte j = 0; j < twoDimension; j++)
                    {
                        ((TextBox[,])(textBoxArray[h]))[i, j] = new TextBox();
                        ((TextBox[,])(textBoxArray[h]))[i, j].Size = new Size(32, 24);
                        ((TextBox[,])(textBoxArray[h]))[i, j].Location = new Point((h < 2 ? 40 : 15) + i * 35, (h < 2 ? 35 : 35) + j * 30);
                        this.groupBoxArray[h].Controls.Add(((TextBox[,])(textBoxArray[h]))[i, j]);
                    }
                }
            }
        }

    }
}
