namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// The $filter service.
    /// </summary>
    [External]
    public class Filter
    {
        /// <summary>
        /// Filters are used for formatting data displayed to the user.
        /// The general syntax in templates is as follows:
        /// {{ expression [| filter_name[:parameter_value] ... ] }}
        /// </summary>
        /// <param name="name">Name of the filter function to retrieve.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/service/$filter"/>
        /// Official JavaScript Documentation
        /// </see>
        [Template("$filter({name})")]
        public static void DoFilter(string name)
        {
            return;
        }
    }
}