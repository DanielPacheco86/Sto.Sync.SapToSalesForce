﻿
namespace Sto.Synchronization.SAP_to_SalesForce.Console.Common
{
    public class OpenOrderFile : GenericFile
    {
        public OpenOrderFile() {

            OrderType = string.Empty;
            SaleOrderNumber = string.Empty;
            SalesOrderDate = string.Empty;
            RequestedDeliveryDate = string.Empty;
            SoldTo = string.Empty;
            CustomerName = string.Empty;
            NetValueOfOrder = string.Empty;
            NetWeightOfOrder = string.Empty;
            UnitOfMeasurement = string.Empty;
            DeliveryNumber = string.Empty;
            DeliveryCreateDate = string.Empty;
            ShipmentNumber = string.Empty;
            ShipmentCreateDate = string.Empty;
            Incoterms = string.Empty;
            CustomerPOType = string.Empty;
            Plant = string.Empty;
        }
        public string OrderType { get; set; }
        public string SaleOrderNumber { get; set; }
        public string SalesOrderDate { get; set; }
        public string RequestedDeliveryDate { get; set; }
        public string SoldTo { get; set; }
        public string CustomerName { get; set; }
        public string NetValueOfOrder { get; set; }
        public string NetWeightOfOrder { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string DeliveryNumber { get; set; }
        public string DeliveryCreateDate { get; set; }
        public string ShipmentNumber { get; set; }
        public string ShipmentCreateDate { get; set; }
        public string Incoterms { get; set; }
        public string CustomerPOType { get; set; }
        public string Plant { get; set; }
    }
}
