using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

namespace PrintWizard.Model
{
    public class NavigatePanelItemBase
    {
        public Symbol Icon { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public string ToolTip { get; set; }
        public Control ViewUserControl {get; set;}
    }
}