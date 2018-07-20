using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCore
{
    public class ProtobufFormatter : Microsoft.AspNetCore.Mvc.Formatters.OutputFormatter
    {
        /// <summary>
        /// 
        /// </summary>
        public string ContentType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ProtobufFormatter()
        {
            ContentType = "application/proto";
            SupportedMediaTypes.Add(Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/proto"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task WriteResponseBodyAsync(Microsoft.AspNetCore.Mvc.Formatters.OutputFormatterWriteContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            var response = context.HttpContext.Response;
            Serializer.Serialize(response.Body, context.Object);
            return Task.FromResult(0);
        }
}
}
