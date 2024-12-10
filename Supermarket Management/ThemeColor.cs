using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management
{
	internal class ThemeColor
	{
		public static List<string> ColorList = new List<string>() {"#3F5185",
																	"#009688",
																	"#FF5722",
																	"#607D8B",
																	"#FF9800",
																	"#9C27B0",
																	"#2196F3",
																	"#EA676C",
																	"#5978BB",
																	"#818790",
																	"#8E3441",
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
																	"#E41268",
																	"#43876E",
																	"#7BCFE9",
																	"#871C46" };
		public static Color ChangeColorBrightness(Color color, double correctionFactor)
		{
			double red = (double)color.R;
			double green = (double)color.G;
			double blue = (double)color.B;

			if (correctionFactor < 0)
			{
				correctionFactor = 1 + correctionFactor;
				red *= correctionFactor;
				green *= correctionFactor;
				blue *= correctionFactor;
			}
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
