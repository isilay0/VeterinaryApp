using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryApp
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>() { 
                                                                    //"#3F51B5",
                                                                    //"#009688",
                                                                    //"#FF5722",
                                                                    //"#607D8B",
                                                                    //"#FF9800",
                                                                    //"#9C27B0",
                                                                    //"#2196F3",
                                                                    //"#EA676C",
                                                                    //"#E41A4A",
                                                                    //"#5978BB",
                                                                    //"#018790",
                                                                    //"#0E3441",
                                                                    //"#00B0AD",
                                                                    //"#721D47",
                                                                    //"#EA4833",
                                                                    //"#EF937E",
                                                                    //"#F37521",
                                                                    //"#A12059",
                                                                    //"#126881",
                                                                    //"#8BC240",
                                                                    //"#364D5B",
                                                                    //"#C7DC5B",
                                                                    //"#0094BC",
                                                                    //"#E4126B",
                                                                    //"#43B76E",
                                                                    //"#7BCFE9",
                                                                    //"#B71C46"
                                                                    "#777777",
                                                                    "#808080",
                                                                    "#4B251C",  //kahve
                                                                    "#728E96",
                                                                    "#1c6071",  //koyu mavi
                                                                    "#696969",
                                                                    "#828282",
                                                                    "#908f8f",
                                                                    "#AAAAAA",
                                                                    "#2C2966",  //lacivert
                                                                    "#666666",
                                                                    "#9e918f",
                                                                    "#bebebe",
                                                                    "#5f5f5f",  
                                                                    "#9c9c9c",
                                                                    "#2F4F4F",  //koyu yeşil
                                                                    "#cfcfcf"
                                                                    
        };

        public static Color ChangeColorBrightness(Color color, double correctionsFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;


            //correctionsFactor sıfırdan küçükse rengi koyulaştır.
            if (correctionsFactor < 0)
            {
                correctionsFactor = 1 + correctionsFactor;
                red *= correctionsFactor;
                green *= correctionsFactor;
                blue *= correctionsFactor;
            }


            //correctionsFactor sıfırdan büyükse rengi parlaklaştır.
            else
            {
                red = (255 - red) * correctionsFactor + red;
                green = (255 - green) * correctionsFactor + green;
                blue = (255 - blue) * correctionsFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
