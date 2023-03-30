using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorServer.Services
{
    public class EventLogger : ComponentBase
    {
        protected override void OnInitialized()
        {
            // Runs when the component is initialized.
        }

        protected override void OnParametersSet()
        {
            // Runs when a parameter of the component is set or changed.
        }

        protected override void OnAfterRender(bool firstRender)
        {
            // Runs after the component has been rendered in the browser.
        }

        //protected override void OnAfterRenderAsync(bool firstRender)
        //{
        //    // Runs asynchronously after the component has been rendered in the browser.
        //}

        protected override bool ShouldRender()
        {
            // Determines whether the component should be re-rendered.
            return true;
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            // Builds the component's render tree.
        }

        //protected override void OnParametersSetAsync()
        //{
        //    // Runs asynchronously when a parameter of the component is set or changed.
        //}

        //protected override void OnInitializedAsync()
        //{
        //    // Runs asynchronously when the component is initialized.
        //}

        //protected override void OnAfterRenderComplete()
        //{
        //    // Runs after the component has been completely rendered in the browser.
        //}

        //protected override void OnDisposed()
        //{
        //}
    }
}
