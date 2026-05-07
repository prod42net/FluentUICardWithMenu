using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.FluentUI.AspNetCore.Components;

namespace BlazorApp1.Components.Controls;

/// <summary>
/// A dictionary of badges the key is the badge text and the value is the badge color
/// </summary>
public class P42CardBadges:Dictionary<string, string>
{
}


public partial class P42Card<TData> : ComponentBase
{
    [Inject] IMenuService? MenuService { get; set; }
    [Parameter] public EventCallback<TData> OnCardClick { get; set; }
    [Parameter] public Dictionary<string, Action>? SubMenuActionList { get; set; }
    [Parameter] public string CustomColor { get; set; } = "";
    [Parameter] public string CustomIconColor { get; set; } = "";
    [Parameter] public string Title { get; set; } = "";
    [Parameter] public string Description { get; set; } = "";
    [Parameter] public P42CardBadges Badges { get; set; } = new P42CardBadges();
    [Parameter] public Icon Icon { get; set; } = null!;
    [Parameter] public TData? Data { get; set; } = default(TData);
    [Parameter] public required string UniqueId { get; set; } = "";
    
    /// <summary>
    /// describes the card e.g. txt, draw, ppt, md
    /// </summary>
    [Parameter] public string  CardType
    {
        get => _cardType;
        set => _cardType = string.IsNullOrWhiteSpace(value) 
            ? "" 
            : value[..Math.Min(value.Length, 6)];
    }


    bool _isHovered = false;
    string _cardType = "undefined";

    
    
    async Task CardClick(MouseEventArgs arg)
    {
        if (OnCardClick.HasDelegate)
        {
            await OnCardClick.InvokeAsync(Data)!;
        }
    }
}