namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// Element position scroller service.
    /// </summary>
    [External]
    public static class AnchorScroll
    {
        /// <summary>
        /// When called, it scrolls to the element related to the specified
        /// hash or (if omitted) to the current value of $location.hash(),
        /// according to the rules specified in the HTML5 spec.
        /// </summary>
        /// <param name="hash">Hash of the element to scroll to.</param>
        [Template("$anchorScroll({hash})")]
        public static void DoAnchorScroll(string hash = default(string))
        {
        }
    }

    /// <summary>
    /// AnchorScroll Promise handler.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [External]
    public class AnchorScroll<T>
    {
        /// <summary>
        /// Get the promise for the given URL.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Promise<T> Get(string url)
        {
            return null;
        }
    }

}