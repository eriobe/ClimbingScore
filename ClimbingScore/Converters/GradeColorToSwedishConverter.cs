using ClimbingScore.Models;
using System.Globalization;
using System.Windows.Data;

namespace ClimbingScore.Converters;

public class GradeColorToSwedishConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is GradeColor gradeColor)
        {
            return gradeColor switch
            {
                GradeColor.Green => "Grön",
                GradeColor.Blue => "Blå",
                GradeColor.Yellow => "Gul",
                GradeColor.Red => "Röd",
                GradeColor.Black => "Svart",
                GradeColor.White => "Vit",
                _ => ""
            };
        }
        return "";

    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

