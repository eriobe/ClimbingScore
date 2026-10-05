using ClimbingScore.Models;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ClimbingScore.Converters;

public class GradeColorToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {

        if (value is not GradeColor gradeColor)
            return Brushes.Transparent;

        return gradeColor switch
        {
            GradeColor.Green => Brushes.Green,
            GradeColor.Blue => Brushes.Blue,
            GradeColor.Yellow => Brushes.Yellow,
            GradeColor.Red => Brushes.Red,
            GradeColor.Black => Brushes.Black,
            GradeColor.White => Brushes.White,
            _ => Brushes.Transparent
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}


