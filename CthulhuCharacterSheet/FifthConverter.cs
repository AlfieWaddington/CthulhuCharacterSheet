using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CthulhuCharacterSheet
{
    class FifthConverter : IValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {



            //Turn input into format that can be calculated with
            var stringform = value as string;
            if (stringform == "") return "";
            int stat = 0;
            if (int.TryParse(stringform, out stat)) ;



            return (stat / 5);
            throw new NotImplementedException();
        }

        public object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {


            //Turn input into format that can be calculated with
            var stringform = value as string;
            if (stringform == "") return "";
            int stat = 0;
            if (int.TryParse(stringform, out stat)) ;



            return (stat * 5);
            throw new NotImplementedException();
            throw new NotImplementedException();
        }
    }
}