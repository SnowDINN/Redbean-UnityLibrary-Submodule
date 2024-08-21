﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Redbean
{
	public class ApiSingleton : ISingletonContainer
	{
		public static readonly HttpClient Http = new(new HttpClientHandler
		{
			UseProxy = false,
		})
		{
			BaseAddress = new Uri("https://localhost:44395"),
			DefaultRequestHeaders =
			{
				{ "Version", AppSettings.Version },
			},
			Timeout = TimeSpan.FromSeconds(60),
		};

		public T GetProtocol<T>() where T : ApiProtocol
		{
			return Activator.CreateInstance<T>();
		}
		
		public object GetProtocol(Type type)
		{
			return Activator.CreateInstance(type);
		}
		
		public void Dispose()
		{
		}
	}
}