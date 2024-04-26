using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Buttons;
using SyncfusionDocumentation_Personal.Test;

namespace BlazorXUnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1Tests()
        {
            using var testContext = new TestContext();

            // Add Syncfusion Blazor service.
            testContext.Services.AddSyncfusionBlazor();
            testContext.Services.AddOptions();

            // Rendering application Home component (~/Pages/Home.razor).
            var indexComponent = testContext.RenderComponent<Tests1>();
            // Set Index component parameter Step value.
            indexComponent.SetParametersAndRender(parameters => parameters.Add(p => p.Step, 5));

            // Find Syncfusion Button component.
            var sfButton = indexComponent.FindComponent<SfButton>();
            // Find span element.
            var span = indexComponent.Find("span.alert.alert-info");

            // Assert
            // Testing span element markup initial state.
            span.MarkupMatches("<span class=\"alert alert-info\">Count: 0</span>");

            // Click Syncfusion Button component.
            sfButton.Find(".e-btn").Click();

            // Testing span element markup again.
            span.MarkupMatches("<span class=\"alert alert-info\">Count: 5</span>");
        }
    }
}




//using var testContext = new TestContext();

////Add Syncfusion Blazor service
//testContext.Services.AddSyncfusionBlazor();
//testContext.Services.AddOptions();

////Rendering application Tests component (~/Tests/Tests.razor)
//var indexComponent = testContext.RenderComponent<Tests>();
//// Find Syncfusion Button component.
//var sfButton = indexComponent.FindComponent<SfButton>();
//// Find span element.
//var span = indexComponent.Find("span.alert.alert-info");

////Assert 
////Testing span element markup
//span.MarkupMatches("<span class=\"alert alert-info\">Count: 0</span>");


//// Click Syncfusion Button component.
//sfButton.Find(".e-btn").Click();

//// Testing span element markup again.
//span.MarkupMatches("<span class=\"alert alert-info\">Count: 1</span>");