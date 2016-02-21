using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore {
    class Customer {
        // Fields.
        private string strName;
        private string strAddress;
        private string strPhone;
        private Video[] avdoRented;

        // Properties.
        public string Name {
            get {
                return this.strName;
            }
        }

        public string Address {
            get {
                return this.strAddress;
            }
        }

        public string Phone {
            get {
                return this.strPhone;
            }
        }

        public int NumVidsRented {
            get {
                // Count the number of elements in the array that are not null references.
                int iCount = 0;
                for (int iIndex = 0; iIndex < this.avdoRented.Length; iIndex++) {
                    if (this.avdoRented[iIndex] != null) {
                        iCount++;
                    }
                }
                // Done counting, return the count.
                return iCount;
            }
        }

        public double TotalFee {
            get {
                // Add up the fees for the videos rented.
                double dTotalFee = 0;
                for (int iIndex = 0; iIndex < this.avdoRented.Length; iIndex++) {
                    if (this.avdoRented[iIndex] != null) {
                        dTotalFee += this.avdoRented[iIndex].Fee;
                    }
                }
                // Return the TotalFee
                return dTotalFee;
            }
        }

        // Constructor.
        public Customer(string strN, string strAddr, string strPh) {
            // Initialize field values from parameters.
            this.strName = strN;
            this.strAddress = strAddr;
            this.strPhone = strPh;
            // Create an initial array of videos.
            this.avdoRented = new Video[10];
        }

        // Methods.
        // Clear out the list of rented videos.
        public void vClearRented() {
            // Loop through the array of rented videos and put null
            // references into each slot.
            for (int iIndex = 0; iIndex < this.avdoRented.Length; iIndex++) {
                // If this element points to a real video, "return" that video
                // to the store. (TODO)

                // Put in a null reference.
                this.avdoRented[iIndex] = null;
            }
        }

        // Add a video to the list of rented videos.
        public void vRentVideo(Video vdoToRent) {
            // Find the first open slot in the array.
            int iOpenSlot = 0;
            while (this.avdoRented[iOpenSlot] != null) {
                iOpenSlot++;
            }
            // Open slot found. Put in video.
            this.avdoRented[iOpenSlot] = vdoToRent;
        }
    }
}
