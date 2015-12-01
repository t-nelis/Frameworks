namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngRepeat directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-repeat (ngRepeat)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngRepeat">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-repeat')")]
        public extern string GetRepeat();
        
        /// <summary>
        /// Removes the ng-repeat (ngRepeat) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngRepeat">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-repeat')")]
        public extern void RemoveRepeat();

        /// <summary>
        /// Sets the NG repeat to the element with the specified free text
        /// expression.
        /// </summary>
        /// <param name="expression">Valid ngRepeat AngularJS expression</param>
        /// <remarks>Must be used inside a ngController scope</remarks>
        [Template("{this}.setAttribute('ng-repeat', {expression})")]
        public extern void SetRepeat(string expression);

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable and iterated array names.
        /// </summary>
        /// <param name="variable">Iteration variable</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <remarks>Must be used inside a ngController scope</remarks>
        [Template("{this}.setAttribute('ng-repeat', " +
            "'' + {variable} + ' in ' + {array})")]
        public extern void SetRepeat(string variable, string array);

        // FIXME: There are much more over Filter and OrderBy. Another approach
        //        will have to be taken.
        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array and filter input field.
        /// </summary>
        /// <param name="variable">Iteration variable</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <param name="filterInputField">Filter input field.</param>
        /// <remarks>
        /// Must be used inside a ngController scope and input field for filter
        /// must be defined somewhere else in the page
        /// </remarks>
        [Template("{this}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "filter:' + {filterInputField})")]
        public extern void SetRepeatWithFilter(string variable,
            string array, string filterInputField);

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array, filter input and order input fields.
        /// </summary>
        /// <param name="variable">Iteration variable.</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <param name="filterInputField">Filter input field.</param>
        /// <param name="orderByInputField">Order by input field.</param>
        /// <remarks>
        /// Must be used inside a ngController scope and input field for filter
        /// must be defined somewhere else in the page
        /// </remarks>
        [Template("{this}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "filter: ' + {filterInputField} + ' | " +
                  "orderBy: ' + {orderByInputField})")]
        public extern void SetNGRepeat(string variable, string array,
            string filterInputField, string orderByInputField);

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array and OrderBy input field.
        /// </summary>
        /// <param name="variable">Variable.</param>
        /// <param name="array">Array.</param>
        /// <param name="orderByInputField">Order by input field.</param>
        [Template("{this}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "orderBy: ' + {orderByInputField})")]
        public extern void SetNGRepeatWithOrderBy(string variable,
            string array, string orderByInputField);
    }
}