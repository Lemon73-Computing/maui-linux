using System;
using Gtk;

namespace Microsoft.Maui.Handlers
{
	public partial class RadioButtonHandler : ViewHandler<IRadioButton, RadioButton>
	{
		protected override RadioButton CreatePlatformView()
  		{
 			// Note: We set a random GUID as the GroupName as part of the work-around in https://github.com/dotnet/maui/issues/11418
			return new RadioButton(Guid.NewGuid().ToString());
	 	}

		[MissingMapper]
		public static void MapBackground(IRadioButtonHandler handler, IRadioButton radioButton) { }
		[MissingMapper]
		public static void MapIsChecked(IRadioButtonHandler handler, IRadioButton radioButton) { }
		[MissingMapper]
		public static void MapContent(IRadioButtonHandler handler, IRadioButton radioButton) { }

		public static void MapTextColor(IRadioButtonHandler handler, ITextStyle textStyle)
  		{
			handler.PlatformView?.UpdateTextColor(textStyle.TextColor);
   		}

		[MissingMapper]
		public static void MapCharacterSpacing(IRadioButtonHandler handler, ITextStyle textStyle) { }

		public static void MapFont(IRadioButtonHandler handler, ITextStyle textStyle)
  		{
			var fontManager = handler.GetRequiredService<IFontManager>();
			handler.PlatformView?.UpdateFont(textStyle, fontManager);
		}

		[MissingMapper]
		public static void MapStrokeColor(IRadioButtonHandler handler, IRadioButton radioButton) { }
		[MissingMapper]
		public static void MapStrokeThickness(IRadioButtonHandler handler, IRadioButton radioButton) { }
		[MissingMapper]
		public static void MapCornerRadius(IRadioButtonHandler handler, IRadioButton radioButton) { }
	}
}
