using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rent_OOP
{
  
    public class Car
    {
        private string color;
        private string marke;
        private int laufleistung;
        private double mietpreisTag;
        private bool available;

        public Car(string color, string marke, int laufleistung, double mietpreisTag, bool available)
        {
            this.color = color;
            this.marke = marke;
            this.laufleistung = laufleistung;
            this.mietpreisTag = mietpreisTag;
            this.available = available;
        }
       
        public void ToggleAvailable()
        {
            available = !available;
        }
        public bool IsAvailable()
        {
            return available;
        }
        public override string ToString()
        {
            return color + " " + marke + " mit " + laufleistung + "km " + mietpreisTag + " pro Tag - zurzeit Verfügbar: " + available;
        }

    }

}
