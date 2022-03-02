﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SuchByte.TwitchPlugin.Models
{
    public interface ISerializableConfiguration
    {
        public string Serialize();

        protected static T Deserialize<T>(string configuration) where T : ISerializableConfiguration, new() =>
            !string.IsNullOrWhiteSpace(configuration) ? JsonSerializer.Deserialize<T>(configuration) : new T();
    }
}
