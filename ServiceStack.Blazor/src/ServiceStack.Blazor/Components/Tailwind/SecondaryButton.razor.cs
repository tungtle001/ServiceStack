﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ServiceStack.Blazor.Components.Tailwind;

/// <summary>
/// Render a normal Tailwlind Link or Button
/// </summary>
/// <remarks>
/// ![](https://raw.githubusercontent.com/ServiceStack/docs/master/docs/images/blazor/components/SecondaryButton.png)
/// </remarks>
public partial class SecondaryButton : UiComponentBase
{
    [Parameter] public string type { get; set; } = "button";
    [Parameter] public string? href { get; set; }
    [Parameter] public string? title { get; set; }
    [Parameter] public string? target { get; set; }
    [Parameter, EditorRequired] public RenderFragment? ChildContent { get; set; }
    [Parameter] public EventCallback<MouseEventArgs> onclick { get; set; }
}
