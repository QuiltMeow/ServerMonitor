using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServerMonitor
{
    public static class Util
    {
        public static void forceUpdateNumericUpDownValue(NumericUpDown control, decimal value)
        {
            decimal pre = value + 1;
            if (pre > control.Maximum)
            {
                pre = value - 1;
            }
            control.Value = pre;
            control.Value = value;
        }

        public static string removeWhiteSpace(string data)
        {
            return Regex.Replace(data, "\\s+", string.Empty);
        }
    }
}