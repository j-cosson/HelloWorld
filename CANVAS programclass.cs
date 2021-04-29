using System;

namespace PersonalProjectApp
{
    public class TaxCalculator
    {
        public double CalculateTax(string countyNumber, double prePriceObject)
        {
            double taxAmount = 0.0;
            
            
                if (countyNumber == "1")
                {
                    taxAmount = prePriceObject * 0.055;
                }

                if (countyNumber == "2")
                {
                    taxAmount = prePriceObject * 0.0725;
                }

                if (countyNumber == "3")
                {
                    taxAmount = prePriceObject * 0.06;
                }
            
            return Math.Round(taxAmount,2);
        }
    }
}