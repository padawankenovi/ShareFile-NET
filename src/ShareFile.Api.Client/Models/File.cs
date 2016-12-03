// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2016 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Models 
{
	public class File : Item 
	{

		public string FilePath { get; set; }

		public string Hash { get; set; }

		public bool? HasPreview { get; set; }

		public SafeEnum<FileVirusStatus> VirusStatus { get; set; }

		public ItemDlpInfo DlpInfo { get; set; }

		public ItemInfo Info { get; set; }

		public User LockedBy { get; set; }

		public FileLock FileLockInfo { get; set; }

		public float? Version { get; set; }

		public ESignature ESignatureDocument { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as File;
			if(typedSource != null)
			{
				FilePath = typedSource.FilePath;
				Hash = typedSource.Hash;
				HasPreview = typedSource.HasPreview;
				VirusStatus = typedSource.VirusStatus;
				DlpInfo = typedSource.DlpInfo;
				Info = typedSource.Info;
				LockedBy = typedSource.LockedBy;
				FileLockInfo = typedSource.FileLockInfo;
				Version = typedSource.Version;
				ESignatureDocument = typedSource.ESignatureDocument;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("FilePath", out token) && token.Type != JTokenType.Null)
				{
					FilePath = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Hash", out token) && token.Type != JTokenType.Null)
				{
					Hash = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("HasPreview", out token) && token.Type != JTokenType.Null)
				{
					HasPreview = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("VirusStatus", out token) && token.Type != JTokenType.Null)
				{
					VirusStatus = (SafeEnum<FileVirusStatus>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<FileVirusStatus>));
				}
				if(source.TryGetProperty("DlpInfo", out token) && token.Type != JTokenType.Null)
				{
					DlpInfo = (ItemDlpInfo)serializer.Deserialize(token.CreateReader(), typeof(ItemDlpInfo));
				}
				if(source.TryGetProperty("Info", out token) && token.Type != JTokenType.Null)
				{
					Info = (ItemInfo)serializer.Deserialize(token.CreateReader(), typeof(ItemInfo));
				}
				if(source.TryGetProperty("LockedBy", out token) && token.Type != JTokenType.Null)
				{
					LockedBy = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("FileLockInfo", out token) && token.Type != JTokenType.Null)
				{
					FileLockInfo = (FileLock)serializer.Deserialize(token.CreateReader(), typeof(FileLock));
				}
				if(source.TryGetProperty("Version", out token) && token.Type != JTokenType.Null)
				{
					Version = (float?)serializer.Deserialize(token.CreateReader(), typeof(float?));
				}
				if(source.TryGetProperty("ESignatureDocument", out token) && token.Type != JTokenType.Null)
				{
					ESignatureDocument = (ESignature)serializer.Deserialize(token.CreateReader(), typeof(ESignature));
				}
			}
		}
	}
}