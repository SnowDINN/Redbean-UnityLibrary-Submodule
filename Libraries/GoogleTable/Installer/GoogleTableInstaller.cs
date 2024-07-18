﻿using Redbean.Base;
using UnityEngine;

namespace Redbean.Table
{
	[CreateAssetMenu(fileName = "GoogleTable", menuName = "Redbean/GoogleTable")]
	public class GoogleTableInstaller : ScriptableObject
	{
		[Header("Get generation path")]
		public string Path;
		public string ItemPath;
	}
	
	public class GoogleTableSettings : SettingsBase<GoogleTableInstaller>
	{
		public static string Path
		{
			get => Installer.Path;
			set
			{
				Installer.Path = value;
				Save();
			}
		}

		public static string ItemPath
		{
			get => Installer.ItemPath;
			set
			{
				Installer.ItemPath = value;
				Save();
			}
		}

		public static string SheetId;
		public static string ClientId;
		public static string ClientSecretId;
	}
}