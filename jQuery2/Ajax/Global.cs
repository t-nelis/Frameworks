using Bridge.Foundation;
using System;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Register a handler to be called when Ajax requests complete.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxComplete({0})")]
        public static void AjaxComplete(Delegate handler)
        {
        }

        /// <summary>
        /// Register a handler to be called when Ajax requests complete.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxComplete({0})")]
        public static void AjaxComplete(Action<jQueryEvent, jqXHR, AjaxOptions> handler)
        {
        }

        /// <summary>
        /// Register a handler to be called when Ajax requests complete with an error.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxError({0})")]
        public static void AjaxError(Delegate handler)
        {
        }

        /// <summary>
        /// Register a handler to be called when Ajax requests complete with an error.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxError({0})")]
        public static void AjaxError(Action<jQueryEvent, jqXHR, AjaxOptions, string> handler)
        {
        }

        /// <summary>
        /// Attach a function to be executed before an Ajax request is sent.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxSend({0})")]
        public static void AjaxSend(Delegate handler)
        {
        }

        /// <summary>
        /// Attach a function to be executed before an Ajax request is sent.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxSend({0})")]
        public static void AjaxSend(Action<jQueryEvent, jqXHR, AjaxOptions> handler)
        {
        }

        /// <summary>
        /// Register a handler to be called when the first Ajax request begins.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxStart({0})")]
        public static void AjaxStart(Delegate handler)
        {
        }

        /// <summary>
        /// Register a handler to be called when the first Ajax request begins.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxStart({0})")]
        public static void AjaxStart(Action handler)
        {
        }

        /// <summary>
        /// Register a handler to be called when all Ajax requests have completed.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxStop({0})")]
        public static void AjaxStop(Delegate handler)
        {
        }

        /// <summary>
        /// Register a handler to be called when all Ajax requests have completed.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxStop({0})")]
        public static void AjaxStop(Action handler)
        {
        }

        /// <summary>
        /// Attach a function to be executed whenever an Ajax request completes successfully.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxSuccess({0})")]
        public static void AjaxSuccess(Delegate handler)
        {
        }

        /// <summary>
        /// Attach a function to be executed whenever an Ajax request completes successfully.
        /// </summary>
        /// <param name="handler">The function to be invoked.</param>
        [Template("$(document).ajaxSuccess({0})")]
        public static void AjaxSuccess(Action<jQueryEvent, jqXHR, AjaxOptions, object> handler)
        {
        }
    }
}