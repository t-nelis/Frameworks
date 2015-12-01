using Bridge.Html5;

namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// The $document service. A jQuery or jqLite wrapper for the browser's
    /// window.document object.
    /// </summary>
    /// <see cref="!:https://docs.angularjs.org/api/ng/service/$document">
    /// Official JavaScript Documentation
    /// </see>
    [External]
    public static class Document
    {
        // TODO: this requires turning Bridge.Html5.Document static class into
        //       an abstract or interface and then both Bridge.Html5.Document
        //       and this class inherit from it.
    }
}