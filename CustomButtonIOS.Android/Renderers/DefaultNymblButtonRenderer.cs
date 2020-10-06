using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using Android.Widget;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButtonIOS.DefaultNymblButton), typeof(CustomButtonIOS.Droid.Renderers.DefaultNymblButtonRenderer))]
namespace CustomButtonIOS.Droid.Renderers
{
    public class DefaultNymblButtonRenderer : ButtonRenderer
    {
        public DefaultNymblButtonRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null || Element == null || e == null)
                return;

            Control.StateListAnimator = null;

            if (Element is CustomButtonIOS.DefaultNymblButton nymblButton)
            {
                Color textColor = nymblButton.NymblTextColor;
                Control.SetTextColor(textColor.ToAndroid());
                Control.SetAllCaps(nymblButton.NymblTextAllCaps);
  
                if (nymblButton.IsEnabled && !nymblButton.IsPressed)
                {
                    Control.Elevation = 10;

                    Control.Background = CreateRippleDrawable(
                         nymblButton.NymblDefaultColor,
                         nymblButton.NymblBorderColor,
                         nymblButton.NymblBorderWidth);
                }
                else if (nymblButton.IsEnabled && nymblButton.IsPressed)
                {
                    Control.Elevation = 0;

                    Control.Background = CreateRippleDrawable(
                         nymblButton.NymblPressedColor,
                         nymblButton.NymblBorderColor,
                         nymblButton.NymblBorderWidth);
                }
                else if (!nymblButton.IsEnabled)
                {
                    textColor = nymblButton.NymblDisabledTextColor;
                    Control.SetTextColor(textColor.ToAndroid());

                    Control.Elevation = 0;

                    Control.Background = CreateRippleDrawable(
                         nymblButton.NymblDisabledColor,
                         nymblButton.NymblBorderColor,
                         nymblButton.NymblBorderWidth);
                }

                bool bUserScaled = false;
                DisplayMetrics metrics = Context.Resources.DisplayMetrics;
                if (DisplayMetrics.DensityDeviceStable != (int)metrics.DensityDpi)
                {
                    // user has scaled their display (zoomed) via Accesibility settings
                    bUserScaled = true;
                }

                if (bUserScaled && Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
                {
                    //Call API supported by Oreo (SDK 26) and above, but not by lower API's
                    TextView view = (TextView)Control;
                    view.SetAutoSizeTextTypeWithDefaults(AutoSizeTextType.Uniform);
                }
            }
        }

        private Drawable CreateRippleDrawable(Color color, Color borderColor, int borderWidth)
        {
            var normalColor = color.ToAndroid();
            var cornerRadius = 20;
            var rippleDrawable = Context.GetDrawable(Resource.Drawable.shaded_ripple_button) as RippleDrawable;
            var insetDrawable = rippleDrawable.FindDrawableByLayerId(Resource.Id.inset_drawable) as InsetDrawable;

            var gradientDrawable = insetDrawable.Drawable as GradientDrawable;
            gradientDrawable.SetCornerRadius(cornerRadius);
            gradientDrawable.SetColor(normalColor);
            gradientDrawable.SetStroke(borderWidth, borderColor.ToAndroid());

            return rippleDrawable;
        }
    }

    //public class OutlineProvider : ViewOutlineProvider
    //{
    //    public override void GetOutline(Android.Views.View view, Outline outline)
    //    {
    //        if (view != null && outline != null)
    //        {
    //            Rect rect = new Rect(0, 0, view.Width - 20, view.Height - 20);
    //            outline.SetRect(rect);
    //            outline.Offset(20, 20);
    //            rect.Dispose();
    //        }
    //    }
    //}
}

