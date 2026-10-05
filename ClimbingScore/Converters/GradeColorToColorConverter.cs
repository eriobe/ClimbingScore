using ClimbingScore.Models;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ClimbingScore.Converters;

public class GradeColorToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {

        if (value is not GradeColors gradeColor)
            return Brushes.Transparent;

        return gradeColor switch
        {
            GradeColors.Green => Brushes.Green,
            GradeColors.Blue => Brushes.Blue,
            GradeColors.Yellow => Brushes.Yellow,
            GradeColors.Red => Brushes.Red,
            GradeColors.Black => Brushes.Black,
            GradeColors.White => Brushes.White,
            _ => Brushes.Transparent
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}


