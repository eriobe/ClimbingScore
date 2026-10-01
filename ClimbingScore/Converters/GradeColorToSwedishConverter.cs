using ClimbingScore.Models;
using System.Globalization;
using System.Windows.Data;

namespace ClimbingScore.Converters;

public class GradeColorToSwedishConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is GradeColors gradeColor)
        {
            return gradeColor switch
            {
                GradeColors.Green => "Grön",
                GradeColors.Blue => "Blå",
                GradeColors.Yellow => "Gul",
                GradeColors.Red => "Röd",
                GradeColors.Black => "Svart",
                GradeColors.White => "Vit",
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

