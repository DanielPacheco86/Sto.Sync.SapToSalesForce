using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.Common
{
    public class InvoiceFile
    {
        public InvoiceFile() 
        {
            Cancelled = string.Empty;
            InvType = string.Empty;
            Invoice = string.Empty;
            SoldTo = string.Empty;
            SoldToName = string.Empty;
            BillingDate = string.Empty;
            InvAmt = string.Empty;
            Currency = string.Empty;
            ShipTo = string.Empty;
            SalesOrder = string.Empty;
            Material = string.Empty;
            MaterialDesc = string.Empty;
            Quantity = string.Empty;
            InvItemAmount = string.Empty;
            InvUnitPrice = string.Empty;
            SOrdItemAmount = string.Empty;
            SOrdUnitPrice = string.Empty;
            Item = string.Empty;
            UOM = string.Empty;
            NetWeight = string.Empty;
            Plant = string.Empty;
            SPJNo = string.Empty;
            PONo = string.Empty;


        }
        public string Cancelled { get; set; }
        public string InvType { get; set; }
        public string Invoice { get; set; }
        public string SoldTo { get; set; }
        public string SoldToName { get; set; }
        public string BillingDate { get; set; }
        public string InvAmt { get; set; }
        public string Currency { get; set; }
        public string ShipTo { get; set; }
        public string SalesOrder { get; set; }
        public string Material { get; set; }
        public string MaterialDesc { get; set; }
        public string Quantity { get; set; }
        public string InvItemAmount { get; set; }
        public string InvUnitPrice { get; set; }
        public string SOrdItemAmount { get; set; }
        public string SOrdUnitPrice { get; set; }
        public string Item { get; set; }
        public string UOM { get; set; }
        public string NetWeight { get; set; }
        public string Plant { get; set; }
        public string SPJNo { get; set; }
        public string PONo { get; set; }
    }
}
