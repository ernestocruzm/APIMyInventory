using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsInventory.Data.Models
{
    public class ConfigItem
    {
        public int ConfigItemId { get; set; }
        public string ItemNombre { get; set; }
        public string ItemDescripcion { get; set; }
        public int RegBorrado { get; set; }


        public int ConfigListId { get; set; }
        public ConfigList ConfigList { get; set; }
    }
}
