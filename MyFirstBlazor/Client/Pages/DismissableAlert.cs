using Microsoft.AspNetCore.Components;
using System;

namespace MyFirstBlazor.Client.Pages
{
    public partial class DismissableAlert
    {
        
        private bool show;
        [Parameter]
        public bool Show
        {
            get { return show; }
            set 
            {
                if(value != this.show)
                {
                    this.show = value;
                    ShowChanged?.Invoke(this.show);
                }
                
            }
        }

        [Parameter]
        public Action<bool> ShowChanged { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
        public void Dismiss()
          => Show = false;
    }
}
