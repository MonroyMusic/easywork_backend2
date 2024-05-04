﻿using System.Text.Json.Serialization;

namespace easywork_backend.Dtos
{
    public class ResponseDto<T>
    {

        public bool Status { get; set; } = true ;

        [JsonIgnore]
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

    }
}
