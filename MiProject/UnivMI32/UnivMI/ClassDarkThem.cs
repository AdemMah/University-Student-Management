using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UnivMI 
{
    public static class ClassDarkThem
    {
        public static Color BackColor;
        public static Color FontColor;
        public static Color FontColor2;
        public static Color PanelColor;
        public static Color PanelColor1;
        public static Color PanelColor2;
        public static bool isCheke;
       /* public static bool cheak(bool isCheakOut)
        {
            isCheke = isCheakOut;
            return isCheke;
        }*/
        
        public static void DarkTheme (bool cheake)
        {
            if(cheake)
            {
                Light();
            }    
            else
            {
                Dark();
            }    


        }
        
        public static void Dark()
        {
            BackColor = Color.FromArgb(45, 45, 48);
            FontColor = Color.White;
            FontColor2 = Color.White;
            PanelColor = Color.FromArgb(28, 28, 28);
            PanelColor1 = Color.FromArgb(45, 45, 48);
            isCheke=true;
            

        }
        public static void Light()
        {
            BackColor = Color.White;
            FontColor = Color.Black;
            FontColor = Color.Black;
            PanelColor = Color.Silver;
            PanelColor1 = Color.White;
            isCheke = false;
           

        }

       
    }

}
