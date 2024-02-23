using System.ComponentModel;

namespace PhoneCheck
{
    public static class Extensions
    {
        public static string GetDescription(this frmPhoneCheck.Device val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
                .GetType()
                .GetField(val.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
