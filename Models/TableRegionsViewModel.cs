using System.Collections.Generic;

namespace Semana6Project.Models
{
    public class TableRegionsViewModel
    {
        public List<Region> Regions { get; set; }

        public TableRegionsViewModel(List<Region> regions)
        {
            Regions = regions;
        }
    }
}
