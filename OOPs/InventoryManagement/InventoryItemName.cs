using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.InventoryManagement
{
    class InventoryItemName
    {
        /// <summary>
        /// list of rice 
        /// </summary>
        private List<Rice> rice = new List<Rice>();
        /// <summary>
        /// list of wheat
        /// </summary>
        private List<Wheat>wheat = new List<Wheat>();
        /// <summary>
        /// list of pulse
        /// </summary>
        private List<Pulse> pulse = new List<Pulse>();
        /// <summary>
        /// get or set of rice
        /// </summary>
        public List<Rice> Rice { get => this.rice; set => this.rice = value; }
        /// <summary>
        /// get or set of wheat
        /// </summary>
        public List<Wheat> Wheat { get => this.wheat; set => this.wheat = value; }
        /// <summary>
        /// get or set of pulse
        /// </summary>
        public List<Pulse> Pulse { get => this.pulse; set => this.pulse = value; }
    }
}
