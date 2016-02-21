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
        private double dFee;

        // Properties.
        public double Fee {
            get {
                return this.dFee;
            }
        }
        // Constructor (TODO)
        public Video(double dF) {
            // Initialize fields from values passed in.
            this.dFee = dF;
        }
    }
}
