using TheBooth.Common;
using TheBooth.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MultiLineLabel), typeof(MultiLineLabelRenderer))]
namespace TheBooth.Droid.Renders
{
    public class MultiLineLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var baseLabel = (MultiLineLabel)this.Element;

            Control.SetLines(baseLabel.Lines);
        }
    }
}