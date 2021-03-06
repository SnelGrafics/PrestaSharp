﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Bukimedia.PrestaSharp.Entities.AuxEntities
{
    [XmlType(Namespace = "Bukimedia/PrestaSharp/Entities/AuxEntities")]
    public class AssociationsManufacturer : PrestaShopEntity
    {
        public List<AuxEntities.address> addresses { get; set; }

        public AssociationsManufacturer()
        {
            this.addresses = new List<address>();
        }
    }
}
