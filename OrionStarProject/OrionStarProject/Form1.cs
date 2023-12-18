// Auth:Brian Schmidt
// Date:09/12/23
/*
 * Desc:This program is called Orion Star Project 
 *      This program will display the stars in the constillation Orion.
 *      There are 2 buttons StarShow and StarsClear one to show the star 
 *      names and one to clear the sky and show the blank stars again
 *      there is a 3rd button to close the program called closeButton
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrionStarProject
{
    public partial class OrionStarProject : Form
    {
        public OrionStarProject()
        {
            InitializeComponent();
        }

        private void StarShow_Click(object sender, EventArgs e)
        {
            OrionClean.Visible = false;//This will make the clear sky view disappear on Show star info click
            OrionOverlay.Visible = true;//This will make the star info appear
        }

        private void StarsClear_Click(object sender, EventArgs e)
        {
            OrionClean.Visible = true;//This will make the clear sky appear on Clear the sky click
            OrionOverlay.Visible = false;//This will make the star info disappear
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();//This will close the program on click
        }
    }
}
