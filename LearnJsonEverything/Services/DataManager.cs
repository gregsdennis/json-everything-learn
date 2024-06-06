﻿using Blazored.LocalStorage;

namespace LearnJsonEverything.Services;

public class DataManager
{
	private readonly ILocalStorageService _localStorage;
	private readonly Dictionary<string, string> _cache;

	public DataManager(ILocalStorageService localStorage)
	{
		_localStorage = localStorage;
		_cache = [];
	}

	public async Task Set(string key, string value)
	{
		_cache[key] = value;

		await _localStorage.SetItemAsync(key, value);
	}

	public async Task<string?> Get(string key)
	{
		if (_cache.TryGetValue(key, out var value)) return value;

		value = await _localStorage.GetItemAsync<string>(key);

		if (value is null)
			_cache.Remove(key);
		else
			_cache[key] = value;

		return value;
	}
}