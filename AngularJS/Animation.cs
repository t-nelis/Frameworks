using Bridge.jQuery2;
using System;

// Here we present the Animation class in three namespaces:
// Bridge.AngularJS: generic, allowing user to choose between the valid jQuery
//   or jqLite, depending on the referencing of jQuery in the HTML page.
// Bridge.AngularJS.jqLite: literal typing to jqLite. Using this namespace will
//   allow to fully use intellisense with the supported jqLite API. Intended to
//   use when not adding jQuery JavaScript to the frontend page.
// Bridge.Angular.jQuery: literal typing to jQuery. Using this namespace will

namespace Bridge.AngularJS
{
    /// <summary>
    /// Generic-typed Animation event class. This is similar to the $animate
    /// Service (Bridge.AngularJS.Animate) but triggered when the equivalent
    /// method is called, thus the different signature.
    /// </summary>
    /// <remarks>
    /// Couldn't find a full documentation about the properties and parameters
    /// supported in this class. Although it seems it supports the same methods
    /// $animate defines, the parameters are clearly different as being event
    /// triggers.
    /// For instance, AddClass's third parameter in $animate is a list of
    /// options. Here, it is an Action, representing the done() callback.
    /// </remarks>
    /// <seealso cref="Bridge.AngularJS.Animation"/>
    /// <seealso cref="Bridge.AngularJS.jQuery.Animation"/>
    /// <typeparam name="T"></typeparam>
    [Ignore]
    [ObjectLiteral]
    public class Animation<T>
    {
        /// <summary>
        /// Function which returns another function, which purpose is to cancel animation
        /// </summary>
        public Func<T, Action, Action<T>> EventName;

        /// <summary>
        /// The event triggered when the animation is added to a CSS class
        /// where the Func&lt;&gt; parameters are:
        /// "T": The element being added.
        /// "string": The target CSS class name.
        /// "Action": The done() callback.
        /// "Action&lt;bool&gt;": The abort action, where the 'bool' parameter is whether it is an
        /// animation cancel request (true) or not (false).
        /// </summary>
        public Func<T, string, Action, Action<bool>> AddClass;

        /// <summary>
        /// The event triggered when the animation is removed from a CSS class
        /// where the Func&lt;&gt; parameters are:
        /// "T": The element being added.
        /// "string": The target CSS class name.
        /// "Action": The done() callback.
        /// "Action&lt;bool&gt;": The abort action, where the 'bool' parameter is whether it is an
        /// animation cancel request (true) or not (false).
        /// </summary>
        public Func<T, string, Action, Action<bool>> RemoveClass;
    }

    /// <summary>
    /// jqLite-specific Animation event class overload. This is similar to the
    /// $animate Service (Bridge.AngularJS.Animate) but triggered when the
    /// equivalent method is called, thus the different signature.
    /// </summary>
    /// <remarks>
    /// Couldn't find a full documentation about the properties and parameters
    /// supported in this class. Although it seems it supports the same methods
    /// $animate defines, the parameters are clearly different as being event
    /// triggers.
    /// For instance, AddClass's third parameter in $animate is a list of
    /// options. Here, it is an Action, representing the done() callback.
    /// </remarks>
    /// <seealso cref="Bridge.AngularJS.Animation&lt;T&gt;"/>
    /// <seealso cref="Bridge.AngularJS.jQuery.Animation"/>
    [Ignore]
    [ObjectLiteral]
    public class Animation : Animation<jqLite>
    {
    }
}

namespace Bridge.AngularJS.jQuery
{
    using jQuery = Bridge.jQuery2.jQuery;

    /// <summary>
    /// jQuery-specific Animation event class overload. This is similar to the
    /// $animate Service (Bridge.AngularJS.Animate) but triggered when the
    /// equivalent method is called, thus the different signature.
    /// </summary>
    /// <remarks>
    /// Couldn't find a full documentation about the properties and parameters
    /// supported in this class. Although it seems it supports the same methods
    /// $animate defines, the parameters are clearly different as being event
    /// triggers.
    /// For instance, AddClass's third parameter in $animate is a list of
    /// options. Here, it is an Action, representing the done() callback.
    /// </remarks>
    /// <seealso cref="Bridge.AngularJS.Animation"/>
    /// <seealso cref="Bridge.AngularJS.Animation&lt;T&gt;"/>
    [Ignore]
    [ObjectLiteral]
    public class Animation : Bridge.AngularJS.Animation<jQuery>
    {
    }
}
