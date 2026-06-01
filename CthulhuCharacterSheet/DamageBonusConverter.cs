using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CthulhuCharacterSheet
{
    class DamageBonusConverter : IMultiValueConverter
    {
        public object? Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {



            //Turn input into format that can be calculated with
            var stringform1 = values[0] as string;
            var stringform2 = values[1] as string;
            if (stringform1 == "") return "";
            if (stringform2 == "") return "";
            int stat1 = 0;
            int stat2 = 0;
            if (int.TryParse(stringform1, out stat1)) ;
            if (int.TryParse(stringform2, out stat2)) ;

            int sum = stat1 + stat2;

            if (2 <= sum && sum <= 64) return -2;
            if (65 <= sum && sum <= 84) return -1;
            if (85 <= sum && sum <= 124) return ("None");
            if (125 <= sum && sum <= 164) return ("+1d4");
            if (165 <= sum && sum <= 204) return ("+1d6");


            throw new NotImplementedException();
        }

        public object[]? ConvertBack(object values, Type[] targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}