using System.Collections.Generic;
using System.Drawing;

namespace ControleTeste.Telas
{
    public static class Temas
    {
        //atributos
        public static Color CorPrimaria { get; set; }
        public static Color CorSecundaria { get; set; }
        //array com dados de cores em hexadecimal
        public static List<string> ColorList = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#607D8B",
                                                                    "#FF9800",
                                                                    "#9C27B0",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#5978BB",
                                                                    "#018790",
                                                                    "#0E3441",
                                                                    "#00B0AD",
                                                                    "#721D47",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#A12059",
                                                                    "#126881",
                                                                    "#8BC240",
                                                                    "#364D5B",
                                                                    "#C7DC5B",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};

        //metodo para alterar o brilho da cor
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //se o fator de correcao for menor que 0 , cores mais escuras.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //se o fator de correcao for maior que 0 , cores mais claras.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}

