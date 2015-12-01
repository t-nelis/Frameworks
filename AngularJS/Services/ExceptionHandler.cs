namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// The $exceptionHandler service. Any uncaught exception in angular
    /// expressions is delegated to this service. The default implementation
    /// simply delegates to $log.error which logs it into the browser console.
    /// </summary>
    [External]
    public class ExceptionHandler
    {
        /// <summary>
        /// Any uncaught exception in angular expressions is delegated to this
        /// service. The default implementation simply delegates to $log.error
        /// which logs it into the browser console.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/service/$exceptionHandler">
        /// Official JavaScript Documentation
        /// </see>
        [Template("$exceptionHandler({exception}, {cause})")]
        public static void DoExceptionHandler(object exception, string cause = default(string))
        {
            return;
        }
    }
}