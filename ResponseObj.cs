using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Browser data
    /// </summary>
    public class Browser
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("major")]
        public string Major { get; set; }

    }
    /// <summary>
    /// Engine data
    /// </summary>
    public class Engine
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

    }
    /// <summary>
    /// Os data
    /// </summary>
    public class Os
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

    }
    /// <summary>
    /// Device data
    /// </summary>
    public class Device
    {
    }
    /// <summary>
    /// Cpu data
    /// </summary>
    public class Cpu
    {
    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("ua")]
        public string Ua { get; set; }

        [JsonProperty("browser")]
        public Browser Browser { get; set; }

        [JsonProperty("engine")]
        public Engine Engine { get; set; }

        [JsonProperty("os")]
        public Os Os { get; set; }

        [JsonProperty("device")]
        public Device Device { get; set; }

        [JsonProperty("cpu")]
        public Cpu Cpu { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
