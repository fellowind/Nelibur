﻿using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using Nelibur.ServiceModel.Services.Headers;

namespace Nelibur.ServiceModel.Services.Maps
{
    internal sealed class RestRequestMetadata : RequestMetadata
    {
        private readonly object _request;

        internal RestRequestMetadata(Message message, Type targetType) : base(targetType)
        {
            OperationType = GetOperationType(message);
            _request = CreateRequest(message, targetType);
        }

        public override string OperationType { get; protected set; }

        public override Message CreateResponse(object response)
        {
            var serializer = new DataContractJsonSerializer(response.GetType());
            return WebOperationContext.Current.CreateJsonResponse(response, serializer);
        }

        public override TRequest GetRequest<TRequest>()
        {
            return (TRequest)_request;
        }

        private static object CraeteRequestFromHeader(Message message, Type targetType)
        {
            string content = RestContentDataHeader.ReadHeader(message);
            byte[] bytes = Encoding.UTF8.GetBytes(content);

            using (var stream = new MemoryStream(bytes))
            {
                var serializer = new DataContractJsonSerializer(targetType);
                stream.Position = 0;
                return serializer.ReadObject(stream);
            }
        }

        private static object CreateRequestFromContent(Message message, Type targetType)
        {
            using (var stream = new MemoryStream())
            {
                XmlDictionaryWriter writer = JsonReaderWriterFactory.CreateJsonWriter(stream);
                message.WriteMessage(writer);
                writer.Flush();
                var serializer = new DataContractJsonSerializer(targetType);
                stream.Position = 0;
                return serializer.ReadObject(stream);
            }
        }

        private static string GetOperationType(Message message)
        {
            var httpReq = (HttpRequestMessageProperty)message.Properties[HttpRequestMessageProperty.Name];
            return httpReq.Method;
        }

        private object CreateRequest(Message message, Type targetType)
        {
            if (OperationType == Operations.OperationType.Get)
            {
                return CraeteRequestFromHeader(message, targetType);
            }

            return CreateRequestFromContent(message, targetType);
        }
    }
}
