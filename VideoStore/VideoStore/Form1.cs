using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStore
{
    public partial class Form1 : Form
    {
        // Fields fro the customers and videos.
        private Customer[] acustAllCustomers;
        private Video[] avdoAllVideos;

        // Fields for the current customer and curent video.
        private int iCurrCust;
        private int iCurrVideo;

        public Form1()
        {
            InitializeComponent();

            // Initiallize the arrays of customers and videos.
            this.acustAllCustomers = new Customer[3];
            this.avdoAllVideos = new Video[4];
            // Add all the customers.
            this.acustAllCustomers[0] = new Customer("John Doe", "1234 South Street", "123-456-7890");
            this.acustAllCustomers[1] = new Customer("Frank Field", "310 Main Street", "102-938-4756");
            this.acustAllCustomers[2] = new Customer("Susan May", "25 Rich Boulevard", "564-839-2017");
            // Initially the 0th customer is the current customer.
            this.iCurrCust = 0;

            
            
            // Add all the videos

            this.avdoAllVideos[0] = new Video("Escape Plan", "Blu-ray", 4, 4, 2.00);
            this.avdoAllVideos[1] = new Video("Captain Phillips", "Blu-ray", 5, 5, 1.75);
            this.avdoAllVideos[2] = new Video("Cloudy with a Chance of Meatballs 2", "DVD", 3, 3, 1.00);
            this.avdoAllVideos[3] = new Video("Lee Daniel's The Butler", "DVD", 4, 4, 1.25);

            // Initially the oth video is set.
            this.iCurrVideo = 0;

        }

        // A method to display the current customers on the form.
        private void DisplayCurrCust() {
            // Get the current customer.
            Customer custCurrent = this.acustAllCustomers[this.iCurrCust];
            // Dispaly his/her data on the form.
            txtName.Text = custCurrent.Name;
            txtAddress.Text = custCurrent.Address;
            txtPhone.Text = custCurrent.Phone;
            txtNumRented.Text = custCurrent.NumVidsRented.ToString();
            txtTotalFee.Text = custCurrent.TotalFee.ToString("C2");
        }

        // A method to display the current video on the form.
        private void DisplayCurrVideo() {
            // Get the current customer.
            Video vdoCurrent = this.avdoAllVideos[this.iCurrVideo];
            // Dispaly his/her data on the form.
            txtTitle.Text = vdoCurrent.Title;
            txtType.Text = vdoCurrent.Type;
            txtCopies.Text = vdoCurrent.CopiesLeft.ToString() + "/" + vdoCurrent.TotalCopies.ToString();
            txtFee.Text = vdoCurrent.Fee.ToString("C2");
        }

        // Method to enable/disable the buttons as appropriate.
        private void EnableButtons() {
            // Move left/right buttons for the customers.
            btnPrevCust.Enabled = (this.iCurrCust > 0);
            btnNextCust.Enabled = (this.iCurrCust < (this.acustAllCustomers.Length - 1));
            btnPrevVideo.Enabled = (this.iCurrVideo > 0);
            btnNextVideo.Enabled = (this.iCurrVideo < (this.avdoAllVideos.Length - 1));
            //btnAdd.Enabled = (custCurrent.NumVidsRented < 11);
            // Check the add-to-order button.  Enabled only if the current customer has
            // empty video rental slots.
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Displayt he initial current customer.
            DisplayCurrCust();
            DisplayCurrVideo();

            // Enable and disable the buttons
            EnableButtons();
        }

        private void btnPrevCust_Click(object sender, EventArgs e) {
            // Decrement the current customer by 1.
            this.iCurrCust--;
            // Display the new customer and update buttons.
            DisplayCurrCust();
            EnableButtons();
        }

        private void btnNextCust_Click(object sender, EventArgs e) {
            // Increment the current customer by 1.
            this.iCurrCust++;
            // Display the new customer and update buttons.
            DisplayCurrCust();
            EnableButtons();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            // Clear out the list rented videos for the current customer.
            Customer custCurrent = this.acustAllCustomers[this.iCurrCust];
            custCurrent.vClearRented();
            DisplayCurrCust();
            EnableButtons();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            // Get the current video and add it to the current customers
            // list of videos rented.
            Video vdoCurrent = this.avdoAllVideos[this.iCurrVideo];
            Customer custCurrent = this.acustAllCustomers[this.iCurrCust];
            custCurrent.vRentVideo(vdoCurrent);
            vdoCurrent.vCheckout();
            // Update the display.
            DisplayCurrCust();
            DisplayCurrVideo();
            EnableButtons();
        }

        private void btnPrevVideo_Click(object sender, EventArgs e)
        {
            // Decrement the current customer by 1.
            this.iCurrVideo--;
            // Display the new customer and update buttons.
            DisplayCurrCust();
            DisplayCurrVideo();
            EnableButtons();
        }

        private void btnNextVideo_Click(object sender, EventArgs e)
        {
            // Increment the current customer by 1.
            this.iCurrVideo++;
            // Display the new customer and update buttons.
            DisplayCurrCust();
            DisplayCurrVideo();
            EnableButtons();
        }
    }
}
