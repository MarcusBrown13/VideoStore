using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore {
    // An enumeration to give names to the possible disk types.
    public enum DiskType {
        VCD,
        DVD,
        BluRay
    }

    // A class for videos.
    class Video {
        // Fields.
        
        private string strTitle;
        private string strType;
        private int iTotalCopies;
        private int iCopiesLeft;
        private string strCopiesPerTotal;
        private double dFee;

        // Properties.
        public string Title {
            get {
                return this.strTitle;
            }
        }

        public string Type {
            get {
                return this.strType;
            }
        }

        public int TotalCopies {
            get {
                return this.iTotalCopies;
            }
        } 

        public int CopiesLeft
        {
            get
            {
                return this.iCopiesLeft;
            }

        }

        public string CopiesPerTotal
        {
            get
            {
                this.strCopiesPerTotal = iCopiesLeft + "/" + iTotalCopies;
                return this.strCopiesPerTotal;
            }
        }

        // Properties.
        public double Fee {
            get {
                return this.dFee;
            }
        }

        public Video(double dF) {
            // Initialize fields from values passed in.
            this.dFee = dF;
        }

        // Constructor.
        
        public Video(string strT, string strTy, int iCL, int iTC, double dF) {
            // Initialize field values from parameters.
            this.strTitle = strT.ToString();
            this.strType = strTy;
            this.iCopiesLeft = iCL;
            this.iTotalCopies = iTC;
            this.dFee = dF;
        }

        public void vCheckout()
        {
            if (iCopiesLeft > 0)
            iCopiesLeft--;
        }

    }
}
