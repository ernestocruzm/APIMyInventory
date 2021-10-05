
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsInventory.Data.Models
{
    public class ConfigList
    {
        public int ConfigListId { get; set; }
        public string ListNombre { get; set; }
        public string ListDescripcion { get; set; }
        public int RegBorrado { get; set; }
        public ICollection<ConfigItem> ConfigItem { get; set; }
                           
    }
}
