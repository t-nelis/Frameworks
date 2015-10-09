using Bridge.AngularJS.Services;
using Bridge.Html5;
using System;

namespace Bridge.AngularJS.Resource
{
    [Ignore]
    [ObjectLiteral]
    public class Resource
    {
        public ResourceQuery Get;
        public ResourceQuery Save;
        public ResourceQuery Query;
        public ResourceQuery Remove;
        public ResourceQuery Delete;
    }

    [Ignore]
    [ObjectLiteral]
    public class ResourceQuery
    {
        public string Method;
        public bool isArray;
    }

    [Ignore]
    public static class Service
    {
        /// <summary>
        /// A factory which creates a resource object that lets you interact
        /// with RESTful server-side data sources.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="paramDefaults">Parameter defaults.</param>
        /// <param name="actions">Actions.</param>
        /// <param name="options">Options.</param>
        public static Resource Resource(string url,
            object paramDefaults,
            ResourceActions actions,
            ResourceOptions options)
        {
            return default(Resource);
        }

        /// <summary>
        /// A factory which creates a resource object that lets you interact
        /// with RESTful server-side data sources.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="paramDefaults">Parameter defaults.</param>
        /// <param name="actions">Actions.</param>
        /// <param name="options">Options.</param>
        /// <typeparam name="T">The type for the paramDefaults.</typeparam>
        public static Resource Resource<T>(string url,
            T paramDefaults,
            ResourceActions actions,
            ResourceOptions options)
        {
            return default(Resource);
        }

        /// <summary>
        /// A factory which creates a resource object that lets you interact
        /// with RESTful server-side data sources.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="paramDefaults">Parameter defaults.</param>
        /// <param name="actions">Actions.</param>
        /// <param name="options">Options.</param>
        public static Resource Resource(string url,
            object paramDefaults = default(object),
            object actions = default(object),
            object options = default(object))
        {
            return default(Resource);
        }

    }

    [Ignore]
    [ObjectLiteral]
    public class ResourceActions
    {
        public ActionInfo Get;
        public ActionInfo Save;
        public ActionInfo Query;
        public ActionInfo Remove;
        public ActionInfo Delete;
    }

    [Ignore]
    [ObjectLiteral]
    public class ActionInfo
    {
        /// <summary>
        /// The name of action. This name becomes the name of the method on your
        /// resource object.
        /// </summary>
        public string Action;

        /// <summary>
        /// Case insensitive HTTP method (e.g. GET, POST, PUT, DELETE, JSONP,
        /// etc).
        /// </summary>
        public string Method;

        /// <summary>
        /// Optional set of pre-bound parameters for this action. If any of the
        /// parameter value is a function, it will be executed every time when a
        /// param value needs to be obtained for a request (unless the param was
        /// overridden).
        /// </summary>
        public object Params;

        /// <summary>
        /// Action specific url override. The url templating is supported just
        /// like for the resource-level urls.
        /// </summary>
        public string Url;

        /// <summary>
        /// If true then the returned object for this action is an array, see
        /// returns section.
        /// </summary>
        public bool IsArray;

        /// <summary>
        /// Transform function or an array of such functions. The transform
        /// function takes the http request body and headers and returns its
        /// transformed (typically serialized) version. By default,
        /// transformRequest will contain one function that checks if the
        /// request data is an object and serializes to using angular.toJson.
        /// To prevent this behavior, set transformRequest to an empty array.
        /// </summary>
        public Any<Func<string, string>, Func<string, string>[]>
            TransformRequest;

        /// <summary>
        /// Transform function or an array of such functions. The transform
        /// function takes the http response body and headers and returns its
        /// transformed (typically deserialized) version. By default,
        /// transformResponse will contain one function that checks if the
        /// response looks like a JSON string and deserializes it using
        /// angular.fromJson. To prevent this behavior, set transformResponse to
        /// an empty array.
        /// </summary>
        public Any<Func<object, string>, Func<object, string>[]>
            TransformResponse;

        /// <summary>
        /// If true, a default $http cache will be used to cache the GET
        /// request, otherwise if a cache instance built with $cacheFactory,
        /// this cache will be used for caching.
        /// </summary>
        public Any<bool, Cache> Cache;

        /// <summary>
        /// Timeout in milliseconds before the request should be aborted.
        /// </summary>
        public long Timeout;

        /// <summary>
        /// Whether to set the withCredentials flag on the XHR object. See
        /// requests with credentials for more information.
        /// </summary>
        public bool WithCredentials;

        /// <summary>
        /// The associated XMLHttpHequest object.
        /// </summary>
        public XMLHttpRequest ResponseType;

        /// <summary>
        /// The interceptor object has two optional methods - response and
        /// responseError. Both response and responseError interceptors get
        /// called with http response object.
        /// </summary>
        /// <seealso cref="Bridge.AngularJS.Services.Interceptor"/>
        public Interceptors Interceptor;
    }

    [Ignore]
    [ObjectLiteral]
    public class ActionInfo<T> : ActionInfo
    {
        /// <summary>
        /// Promise that should abort the request when resolved.
        /// </summary>
        public new Promise<T> Timeout;
    }

    [Ignore]
    [ObjectLiteral]
    public class ResourceOptions
    {
        /// <summary>
        /// If true then the trailing slashes from any calculated URL will be
        /// stripped. Defaults to true.
        /// </summary>
        public bool StripTrailingSlashes = true;
    }
}

