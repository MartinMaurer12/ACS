using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace ACS
{
    public partial class AcsSelectForm : Form
    {
        PowerPoint.NamedSlideShows namedSlideShows = Globals.ThisAddIn.Application.ActivePresentation.SlideShowSettings.NamedSlideShows;
        string localStartButton;
        public AcsSelectForm(string startButton)
        {
            InitializeComponent();

            localStartButton = startButton;

            string[] namesOfNamedSlideShows = new string[namedSlideShows.Count];

            for (int i = 0; i < namedSlideShows.Count; i++)
            {
                namesOfNamedSlideShows[i] = namedSlideShows[i + 1].Name;
            }

            acsListBox.Items.AddRange(namesOfNamedSlideShows);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectButtonClick(object sender, EventArgs e)
        {
            int selectedIndex = acsListBox.SelectedIndex;
           
            PowerPoint.NamedSlideShow selectedSlideShow = namedSlideShows[selectedIndex + 1];
            
            switch (localStartButton) /* ckeck button Name and open new Window */
            {
                case "sortButton":  //TODO: add code block inside the case

                    break;
                case "editButton": //TODO: add code block inside the case

                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("Error: Name Startbutton " + localStartButton + " and Name selectedSlideShow " + selectedSlideShow.Name);
                    break;
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
