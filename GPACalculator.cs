using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAxCalculator
{
    internal class GPACalculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 0;
        private string name = string.Empty; // ""
        private string alldata = string.Empty;
        

        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + " " + gpa + "\r\n";
            /// doing
            if (gpa > this.min)
            {
                this.min = 3.1;
                this.name = name;
            }

            if (this.max < gpa)
            {
                this.max = gpa;
                this.name = name;
            }
            

        }
        /// <summary>
        /// Return GPAx of class
        /// </summary>
        /// <returns>GPAx</returns>
        public double getGPAx()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMin() 
        {
            return this.min;
        }
        public string getMinName() 
        {
            return name;
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return name;
        }
        public string getAlldata()
        {
            return alldata;
        }
    }

}
