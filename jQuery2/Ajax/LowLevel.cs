using System;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        /// </summary>
        /// <returns></returns>
        public static jqXHR Ajax()
        {
            return null;
        }

        /// <summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        /// </summary>
        /// <param name="url">A string containing the URL to which the request is sent.</param>
        /// <returns></returns>
        public static jqXHR Ajax(string url)
        {
            return null;
        }

        /// <summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        /// </summary>
        /// <param name="settings">A set of key/value pairs that configure the Ajax request. All settings are optional. A default can be set for any option with $.ajaxSetup(). See jQuery.ajax( settings ) below for a complete list of all settings. </param>
        /// <returns></returns>
        public static jqXHR Ajax(AjaxOptions settings)
        {
            return null;
        }

        /// <summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        /// </summary>
        /// <param name="url">A string containing the URL to which the request is sent.</param>
        /// <param name="settings">A set of key/value pairs that configure the Ajax request. All settings are optional. A default can be set for any option with $.ajaxSetup(). See jQuery.ajax( settings ) below for a complete list of all settings. </param>
        /// <returns></returns>
        public static jqXHR Ajax(string url, AjaxOptions settings)
        {
            return null;
        }

        /// <summary>
        /// Handle custom Ajax options or modify existing options before each request is sent and before they are processed by $.ajax().
        /// </summary>
        /// <param name="handler">A handler to set default values for future Ajax requests. The following arguments go to the handler:
        ///     options are the request options
        ///     originalOptions are the options as provided to the ajax method, unmodified and, thus, without defaults from ajaxSettings
        ///     jqXHR is the jqXHR object of the request
        /// </param>
        public static void AjaxPrefilter(Action<AjaxOptions, AjaxOptions, jqXHR> handler)
        {
        }

        /// <summary>
        /// Handle custom Ajax options or modify existing options before each request is sent and before they are processed by $.ajax().
        /// </summary>
        /// <param name="dataTypes">A string containing one or more space-separated dataTypes</param>
        /// <param name="handler">A handler to set default values for future Ajax requests. The following arguments go to the handler:
        ///     options are the request options
        ///     originalOptions are the options as provided to the ajax method, unmodified and, thus, without defaults from ajaxSettings
        ///     jqXHR is the jqXHR object of the request
        /// </param>
        public static void AjaxPrefilter(string dataTypes, Action<AjaxOptions, AjaxOptions, jqXHR> handler)
        {
        }

        /// <summary>
        /// Set default values for future Ajax requests. Its use is not recommended.
        /// </summary>
        /// <param name="options">A set of key/value pairs that configure the default Ajax request. All options are optional. </param>
        public static void AjaxSetup(AjaxOptions options)
        {
        }

        /// <summary>
        /// Creates an object that handles the actual transmission of Ajax data.
        /// A transport is an object that provides two methods, send and abort, that are used internally by $.ajax() to issue requests. A transport is the most advanced way to enhance $.ajax() and should be used only as a last resort when prefilters and converters are insufficient.
        /// Since each request requires its own transport object instance, transports cannot be registered directly. Therefore, you should provide a function that returns a transport instead.
        /// Transports factories are registered using $.ajaxTransport(). A typical registration looks like this:
        ///
        /// $.ajaxTransport(function( options, originalOptions, jqXHR ) {
        ///     if( /* transportCanHandleRequest */ ) {
        ///         return {
        ///             send: function( headers, completeCallback ) {
        ///                 // Send code
        ///             },
        ///             abort: function() {
        ///                 // Abort code
        ///             }
        ///         };
        ///     }
        /// });
        /// 
        /// where:
        ///     options are the request options
        ///     originalOptions are the options as provided to the ajax method, unmodified and, thus, without defaults from ajaxSettings
        ///     jqXHR is the jqXHR object of the request
        ///     headers is an object of (key-value) request headers that the transport can transmit if it supports it
        ///     completeCallback is the callback used to notify ajax of the completion of the request
        ///
        /// completeCallback has the following signature:
        ///     function( status, statusText, responses, headers ) {}
        /// where:
        ///     status is the HTTP status code of the response, like 200 for a typical success, or 404 for when the resource is not found.
        ///     statusText is the statusText of the response.
        ///     responses (Optional) is An object containing dataType/value that contains the response in all the formats the transport could provide (for instance, a native XMLHttpRequest object would set reponses to { xml: XMLData, text: textData } for a response that is an XML document)
        ///     headers (Optional) is a string containing all the response headers if the transport has access to them (akin to what XMLHttpRequest.getAllResponseHeaders() would provide).
        /// </summary>
        /// <param name="handler">A handler to return the new transport object to use with the data type provided in the first argument.</param>
        public static void AjaxTransport(Func<AjaxOptions, AjaxOptions, jqXHR, Action<object, Action<int, string, object, string>>> handler)
        {
        }

        /// <summary>
        /// Creates an object that handles the actual transmission of Ajax data.
        /// A transport is an object that provides two methods, send and abort, that are used internally by $.ajax() to issue requests. A transport is the most advanced way to enhance $.ajax() and should be used only as a last resort when prefilters and converters are insufficient.
        /// Since each request requires its own transport object instance, transports cannot be registered directly. Therefore, you should provide a function that returns a transport instead.
        /// Transports factories are registered using $.ajaxTransport(). A typical registration looks like this:
        ///
        /// $.ajaxTransport(function( options, originalOptions, jqXHR ) {
        ///     if( /* transportCanHandleRequest */ ) {
        ///         return {
        ///             send: function( headers, completeCallback ) {
        ///                 // Send code
        ///             },
        ///             abort: function() {
        ///                 // Abort code
        ///             }
        ///         };
        ///     }
        /// });
        /// 
        /// where:
        ///     options are the request options
        ///     originalOptions are the options as provided to the ajax method, unmodified and, thus, without defaults from ajaxSettings
        ///     jqXHR is the jqXHR object of the request
        ///     headers is an object of (key-value) request headers that the transport can transmit if it supports it
        ///     completeCallback is the callback used to notify ajax of the completion of the request
        ///
        /// completeCallback has the following signature:
        ///     function( status, statusText, responses, headers ) {}
        /// where:
        ///     status is the HTTP status code of the response, like 200 for a typical success, or 404 for when the resource is not found.
        ///     statusText is the statusText of the response.
        ///     responses (Optional) is An object containing dataType/value that contains the response in all the formats the transport could provide (for instance, a native XMLHttpRequest object would set reponses to { xml: XMLData, text: textData } for a response that is an XML document)
        ///     headers (Optional) is a string containing all the response headers if the transport has access to them (akin to what XMLHttpRequest.getAllResponseHeaders() would provide).
        /// </summary>
        /// <param name="dataType">A string identifying the data type to use</param>
        /// <param name="handler">A handler to return the new transport object to use with the data type provided in the first argument.</param>
        public static void AjaxTransport(string dataType, Func<AjaxOptions, AjaxOptions, jqXHR, Action<object, Action<string, string, object, string>>> handler)
        {
        }
    }
}