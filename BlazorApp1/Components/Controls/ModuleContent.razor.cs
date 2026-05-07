using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Controls;

public partial class ModuleContent : ComponentBase
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
    [Parameter] public string ModuleId { get; set; } = null!;
}