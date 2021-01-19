using System;
using ServiceStack;
using ServiceStackLambda.ServiceModel;

namespace ServiceStackLambda.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
