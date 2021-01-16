﻿using dotenv.net;
using Pistoladas.Models.Exceptions;
using System;
using System.IO;
using System.Linq;

namespace Pistoladas.Configuration
{
	public static class EnvironmentVariables
	{
		public static void Load()
		{
			try
			{
				var directory = TryGetEnvDirectoryInfo();
				if (directory == null)
				{
					throw new EnvFileNotFoundException();
				}
				DotEnv.Config(filePath: $"{directory.FullName}/.env");
			}
			catch (EnvFileNotFoundException)
			{
				//TODO: add a better handling, maybe send an email
				throw new Exception($"Não foi possível localizar o arquivo .env no escopo do projeto.");
			}
			catch (Exception)
			{
				throw;
			}
		}
		public static DirectoryInfo TryGetEnvDirectoryInfo(string currentPath = null)
		{
			var directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
			while (directory != null && !directory.GetFiles("*.env").Any())
			{
				directory = directory.Parent;
			}
			return directory;
		}
	}
}
