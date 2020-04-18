using Ancestry.BlazorApp.Data.Services;
using Ancestry.BlazorApp.PageModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages.Table
{
    public class TreePageModel : ComponentBase
    {
        protected List<TreeItemViewModel> ItemsList { get; set; } = new List<TreeItemViewModel>();
        [Inject] protected TreeService Service { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ItemsList = await Service.GetAll();
            }
            catch (Exception e)
            {

            }
        }
    }
}
