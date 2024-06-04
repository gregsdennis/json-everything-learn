﻿using System.Reflection;
using System.Text.RegularExpressions;

#pragma warning disable 8618

namespace LearnJsonEverything.Services;

public class LibraryVersion
{
	public string Name { get; private init; }
	public string Version { get; private init; }
	public string NugetLink { get; private init; }

	public static LibraryVersion GetFor<T>()
	{
		var attribute = typeof(T).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
		var version = Regex.Match(attribute!.InformationalVersion, @"\d+\.\d+\.\d+(-[^+]+)?").Value;
		var name = typeof(T).Assembly.GetName().Name!;
		return new LibraryVersion
		{
			Name = name,
			Version = version,
			NugetLink = $"https://nuget.org/packages/{name}"
		};
	}

	public static LibraryVersion GetFor(Type type)
	{
		var attribute = type.Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
		var version = Regex.Match(attribute!.InformationalVersion, @"\d+\.\d+\.\d+(-[^+]+)?").Value;
		var name = type.Assembly.GetName().Name!;
		return new LibraryVersion
		{
			Name = name,
			Version = version,
			NugetLink = $"https://nuget.org/packages/{name}"
		};
	}
}