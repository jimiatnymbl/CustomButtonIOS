using Xamarin.Forms;

namespace CustomButtonIOS
{
    public class DefaultNymblButton : Button
    {
        public readonly static BindableProperty NymblDefaultColorProperty = BindableProperty.Create(
            nameof(NymblDefaultColor),
            typeof(Color),
            typeof(DefaultNymblButton),
            Color.Blue);

        public Color NymblDefaultColor
        {
            get => (Color)GetValue(NymblDefaultColorProperty);
            set => SetValue(NymblDefaultColorProperty, value);
        }

        public readonly static BindableProperty NymblPressedColorProperty = BindableProperty.Create(
            nameof(NymblPressedColor),
            typeof(Color),
            typeof(DefaultNymblButton),
            Color.Blue);

        public Color NymblPressedColor
        {
            get => (Color)GetValue(NymblPressedColorProperty);
            set => SetValue(NymblPressedColorProperty, value);
        }

        public readonly static BindableProperty NymblDisabledColorProperty = BindableProperty.Create(
            nameof(NymblDisabledColor),
            typeof(Color),
            typeof(DefaultNymblButton),
            Color.Blue);

        public Color NymblDisabledColor
        {
            get => (Color)GetValue(NymblDisabledColorProperty);
            set => SetValue(NymblDisabledColorProperty, value);
        }

        public readonly static BindableProperty NymblDisabledTextColorProperty = BindableProperty.Create(
             nameof(NymblDisabledTextColor),
             typeof(Color),
             typeof(DefaultNymblButton),
             Color.LightSlateGray);

        public Color NymblDisabledTextColor
        {
            get => (Color)GetValue(NymblDisabledTextColorProperty);
            set => SetValue(NymblDisabledTextColorProperty, value);
        }

        public readonly static BindableProperty NymblBorderColorProperty = BindableProperty.Create(
            nameof(NymblBorderColor),
            typeof(Color),
            typeof(DefaultNymblButton),
            Color.White);

        public Color NymblBorderColor
        {
            get => (Color)GetValue(NymblBorderColorProperty);
            set => SetValue(NymblBorderColorProperty, value);
        }

        public readonly static BindableProperty NymblBorderWidthProperty = BindableProperty.Create(
            nameof(NymblBorderWidth),
            typeof(int),
            typeof(DefaultNymblButton));

        public int NymblBorderWidth
        {
            get => (int)GetValue(NymblBorderWidthProperty);
            set => SetValue(NymblBorderWidthProperty, value);
        }

        public readonly static BindableProperty NymblTextColorProperty = BindableProperty.Create(
            nameof(NymblTextColor),
            typeof(Color),
            typeof(DefaultNymblButton),
            Color.White);

        public Color NymblTextColor
        {
            get => (Color)GetValue(NymblTextColorProperty);
            set => SetValue(NymblTextColorProperty, value);
        }

        public readonly static BindableProperty NymblTextAllCapsProperty = BindableProperty.Create(
            nameof(NymblTextAllCaps),
            typeof(bool),
            typeof(DefaultNymblButton));

        public bool NymblTextAllCaps
        {
            get => (bool)GetValue(NymblTextAllCapsProperty);
            set => SetValue(NymblTextAllCapsProperty, value);
        }
    }
}

