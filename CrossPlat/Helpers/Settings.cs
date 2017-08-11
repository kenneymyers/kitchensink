using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace CrossPlat.Helpers
{
	public static class Settings
	{
		private static ISettings AppSettings => CrossSettings.Current;

		public static string GeneralSettings
		{
			get => AppSettings.GetValueOrDefault(nameof(GeneralSettings), string.Empty);

			set => AppSettings.AddOrUpdateValue(nameof(GeneralSettings), value);

		}

	}
}
