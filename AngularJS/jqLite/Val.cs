namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Get the current value of the first element in the set of matched
        /// elements.
        /// </summary>
        /// <returns></returns>
        public virtual string Val()
        {
            return null;
        }

        /// <summary>
        /// Get the current value of the first element in the set of matched
        /// elements.
        /// </summary>
        /// <returns></returns>
        public virtual T Val<T>()
        {
            return default(T);
        }

        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A string of text or an array of strings
        /// corresponding to the value of each matched element to set as
        /// selected/checked.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Val(string value)
        {
            return null;
        }

        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">
        /// A string of text or an array of strings corresponding to the value
        /// of each matched element to set as selected/checked.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Val(string[] value)
        {
            return null;
        }
    }
}