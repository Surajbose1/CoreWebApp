using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreWebApp.Models.ViewModel
{
    public class ServiceVM
    {
        public Service Service { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> FrequencyList { get; set; }
    }
}
