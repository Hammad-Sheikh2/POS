using System.Drawing;

namespace POS.Classes
{
	public class Theme
	{
		public enum Themes
		{
			DarkGreen,
			DarkBlue,
			DarkCyan,
			DarkGray,
			DarkPurple,
			DarkRed,
			LightBlue,
			LightCyan,
			LightGray,
			LightPurple,
			LightRed
		}

		public static void ApplyTheme(Themes theme)
		{
			switch (theme)
			{
				case Themes.DarkGreen:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(76, 175, 80);
					Properties.Settings.Default.MenuBarColor = Color.FromArgb(67, 82, 89);
					Properties.Settings.Default.ForeColor = Color.White;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(69, 105, 87);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(48, 62, 69);
					Properties.Settings.Default.Save();
					break;
				case Themes.DarkBlue:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(30, 136, 229);
					Properties.Settings.Default.MenuBarColor = Color.FromArgb(67, 82, 89);
					Properties.Settings.Default.ForeColor = Color.White;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(57, 96, 124);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(48, 62, 69);
					Properties.Settings.Default.Save();

					break;
				case Themes.DarkCyan:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(0, 188, 212);
					Properties.Settings.Default.MenuBarColor = Color.FromArgb(67, 82, 89);
					Properties.Settings.Default.ForeColor = Color.White;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(50, 108, 119);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(48, 62, 69);
					Properties.Settings.Default.Save();

					break;
				case Themes.DarkGray:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(120, 144, 156);
					Properties.Settings.Default.MenuBarColor = Color.FromArgb(67, 82, 89);
					Properties.Settings.Default.ForeColor = Color.White;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(80, 98, 106);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(48, 62, 69);
					Properties.Settings.Default.Save();

					break;
				case Themes.DarkPurple:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(126, 87, 194);
					Properties.Settings.Default.MenuBarColor = Color.FromArgb(67, 82, 89);
					Properties.Settings.Default.ForeColor = Color.White;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(81, 83, 115);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(48, 62, 69);
					Properties.Settings.Default.Save();

					break;
				case Themes.DarkRed:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(220, 69, 55);
					Properties.Settings.Default.MenuBarColor = Color.FromArgb(67, 82, 89);
					Properties.Settings.Default.ForeColor = Color.White;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(104, 79, 81);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(48, 62, 69);
					Properties.Settings.Default.Save();

					break;
				case Themes.LightBlue:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(3, 169, 244);
					Properties.Settings.Default.MenuBarColor = Color.Gainsboro;
					Properties.Settings.Default.ForeColor = Color.Black;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(193, 234, 252);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(238, 238, 238);
					Properties.Settings.Default.Save();

					break;
				case Themes.LightCyan:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(0, 188, 212);
					Properties.Settings.Default.MenuBarColor = Color.Gainsboro;
					Properties.Settings.Default.ForeColor = Color.Black;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(192, 238, 244);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(238, 238, 238);
					Properties.Settings.Default.Save();

					break;
				case Themes.LightGray:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(120, 144, 156);
					Properties.Settings.Default.MenuBarColor = Color.Gainsboro;
					Properties.Settings.Default.ForeColor = Color.Black;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(222, 228, 231);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(238, 238, 238);
					Properties.Settings.Default.Save();

					break;
				case Themes.LightPurple:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(126, 87, 194);
					Properties.Settings.Default.MenuBarColor = Color.Gainsboro;
					Properties.Settings.Default.ForeColor = Color.Black;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(223, 213, 240);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(238, 238, 238);
					Properties.Settings.Default.Save();

					break;
				case Themes.LightRed:
					Properties.Settings.Default.HeaderColor = Color.FromArgb(220, 69, 55);
					Properties.Settings.Default.MenuBarColor = Color.Gainsboro;
					Properties.Settings.Default.ForeColor = Color.Black;
					Properties.Settings.Default.OnHoverColor = Color.FromArgb(246, 209, 206);
					Properties.Settings.Default.BackgroundColor = Color.FromArgb(238, 238, 238);
					Properties.Settings.Default.Save();

					break;
				default:
					break;
			}
		}
	}
}
