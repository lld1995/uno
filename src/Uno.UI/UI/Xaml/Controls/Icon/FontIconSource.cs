using Windows.UI.Text;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
	public partial class FontIconSource : global::Windows.UI.Xaml.Controls.IconSource
	{
		public string Glyph
		{
			get => (string)GetValue(GlyphProperty);
			set => SetValue(GlyphProperty, value);
		}

		public static DependencyProperty GlyphProperty { get; } =
			DependencyProperty.Register(nameof(Glyph), typeof(string), typeof(FontIconSource), new PropertyMetadata(default(string)));

		public FontWeight FontWeight
		{
			get => (FontWeight)GetValue(FontWeightProperty);
			set => SetValue(FontWeightProperty, value);
		}

		public static DependencyProperty FontWeightProperty { get; } =
			DependencyProperty.Register(nameof(FontWeight), typeof(FontWeight), typeof(FontIconSource), new PropertyMetadata(new FontWeight(400)));

		public FontStyle FontStyle
		{
			get => (FontStyle)GetValue(FontStyleProperty);
			set => SetValue(FontStyleProperty, value);
		}

		public static DependencyProperty FontStyleProperty { get; } =
			DependencyProperty.Register(nameof(FontStyle), typeof(FontStyle), typeof(FontIconSource), new PropertyMetadata(FontStyle.Normal));

		public double FontSize
		{
			get => (double)GetValue(FontSizeProperty);
			set => SetValue(FontSizeProperty, value);
		}

		public static DependencyProperty FontSizeProperty { get; } =
			DependencyProperty.Register(nameof(FontSize), typeof(double), typeof(FontIconSource), new PropertyMetadata(20.0));

		public FontFamily FontFamily
		{
			get => (FontFamily)GetValue(FontFamilyProperty);
			set => SetValue(FontFamilyProperty, value);
		}

		public static DependencyProperty FontFamilyProperty { get; } =
			DependencyProperty.Register(nameof(FontFamily), typeof(FontFamily), typeof(FontIconSource), new PropertyMetadata(new FontFamily(Uno.UI.FeatureConfiguration.Font.SymbolsFont)));

		/// <inheritdoc />
		internal override IconElement CreateIconElement()
			=> new FontIcon
			{
				Glyph = Glyph,
				FontWeight = FontWeight,
				FontStyle = FontStyle,
				FontSize = FontSize,
				FontFamily = FontFamily
			};
	}
}
