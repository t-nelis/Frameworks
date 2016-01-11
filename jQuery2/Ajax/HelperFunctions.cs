namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request.
        /// </summary>
        /// <param name="obj">An array or object to serialize.</param>
        /// <returns>A serialized representation of the passed object</returns>
        [Template("$.param({0})")]
        public static string Param(object obj)
        {
            return null;
        }

        /// <summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request.
        /// </summary>
        /// <param name="obj">An array or object to serialize.</param>
        /// <param name="traditional">A Boolean indicating whether to perform a traditional "shallow" serialization.</param>
        /// <returns>A serialized representation of the passed object</returns>
        [Template("$.param({0},{1})")]
        public static string Param(object obj, bool traditional)
        {
            return null;
        }

        /// <summary>
        /// Encode a set of form elements as a string for submission.
        /// The .serialize() method creates a text string in standard URL-encoded notation.
        /// </summary>
        /// <returns>The result string of serialization</returns>
        public virtual string Serialize()
        {
            return null;
        }

        /// <summary>
        /// Encode a set of form elements as an array of names and values.
        /// The .serializeArray() method creates a JavaScript array of objects, ready to be encoded as a JSON string.
        /// </summary>
        /// <returns>The result string of serialization</returns>
        public virtual object[] SerializeArray()
        {
            return null;
        }
    }
}
