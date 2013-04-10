using Windows.UI.Xaml.Controls;

namespace ControlsApp
{
    public class VariableGridView : GridView
    {
        protected override void PrepareContainerForItemOverride(Windows.UI.Xaml.DependencyObject element, object item)
        {
            var personItem = item as Person;
            if (personItem != null)
            {
                element.SetValue(VariableSizedWrapGrid.ColumnSpanProperty, personItem.HorizontalSize);
                element.SetValue(VariableSizedWrapGrid.RowSpanProperty, personItem.VerticalSize);
            }
            base.PrepareContainerForItemOverride(element, item);
        }
    }
}
