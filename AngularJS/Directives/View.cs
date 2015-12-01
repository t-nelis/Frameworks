using Bridge;

/// <summary>
/// ngRoute-specific directives extension methods for Bridge.HTML5
/// Element class.
/// </summary>
[External]
public partial class AngularElement
{
    /// <summary>
    /// Sets the ng-view attribute to the element.
    /// </summary>
    [Template("{this}.setAttribute('ng-view')")]
    public extern void SetView();

    /// <summary>
    /// Gets the ng-view attribute of the element.
    /// </summary>
    [Template("{this}.getAttribute('ng-view')")]
    public extern void GetView();

    /// <summary>
    /// Removes the ng-view attribute fromthe element.
    /// </summary>
    [Template("{this}.removeAttribute('ng-view')")]
    public extern void RemoveView();
}