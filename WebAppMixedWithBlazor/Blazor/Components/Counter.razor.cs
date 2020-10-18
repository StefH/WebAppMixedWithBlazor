using Microsoft.AspNetCore.Components;

namespace WebAppMixedWithBlazor.Blazor.Components
{
    public partial class Counter : ComponentBase
    {
        private int currentCount = 0;

        [Parameter]
        public int InitialValue { get; set; }

        private void IncrementCount() => currentCount++;

        protected override void OnParametersSet()
        {
            currentCount = InitialValue;
        }
    }
}