using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class browser
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("version")]
    public string version { get; set; }

    [JsonProperty("major")]
    public string major { get; set; }

}

public class engine
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("version")]
    public string version { get; set; }

}

public class os
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("version")]
    public string version { get; set; }

}

public class device
{
}

public class cpu
{
}

public class data
{
    [JsonProperty("ua")]
    public string ua { get; set; }

    [JsonProperty("browser")]
    public browser browser { get; set; }

    [JsonProperty("engine")]
    public engine engine { get; set; }

    [JsonProperty("os")]
    public os os { get; set; }

    [JsonProperty("device")]
    public device device { get; set; }

    [JsonProperty("cpu")]
    public cpu cpu { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
