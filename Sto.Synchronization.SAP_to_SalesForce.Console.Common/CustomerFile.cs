using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.Common
{
    public class CustomerFile
    {
        public CustomerFile() {
            AccountNumber = string.Empty;
            AccountName = string.Empty;
            AccountGroup = string.Empty;
            AccountGroupDescription = string.Empty;
            CustomerServiceRepNumber = string.Empty;
            CustomerServiceRep = string.Empty;
            SalesManager1Number = string.Empty;
            SalesManager1 = string.Empty;
            BillingStreet = string.Empty;
            BillingCity = string.Empty;
            BillingPostalCode = string.Empty;
            BillingState = string.Empty;
            BillingCountry = string.Empty;
            Telephone = string.Empty;
            Fax = string.Empty;
            ShippingStreet = string.Empty;
            ShippingCity = string.Empty;
            ShippingPostalCode = string.Empty;
            ShippingState = string.Empty;
            ShippingCountry = string.Empty;
            Website = string.Empty;
            SalesForceID = string.Empty;
            Email1 = string.Empty;
            Notes1 = string.Empty;
            Email2 = string.Empty;
            Notes2 = string.Empty;
            Email3 = string.Empty;
            Notes3 = string.Empty;
            Email4 = string.Empty;
            Notes4 = string.Empty;
            DeletionIndicator = string.Empty;
            Status = string.Empty;
        }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountGroup { get; set; }
        public string AccountGroupDescription { get; set; }
        public string CustomerServiceRepNumber { get; set; }
        public string CustomerServiceRep { get; set; }
        public string SalesManager1Number { get; set; }
        public string SalesManager1 { get; set; }
        public string BillingStreet { get; set; }
        public string BillingCity { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingCountry { get; set; }
        public string Website { get; set; }
        public string SalesForceID { get; set; }
        public string Email1 { get; set; }
        public string Notes1 { get; set; }
        public string Email2 { get; set; }
        public string Notes2 { get; set; }
        public string Email3 { get; set; }
        public string Notes3 { get; set; }
        public string Email4 { get; set; }
        public string Notes4 { get; set; }
        public string DeletionIndicator { get; set; }
        public string Status { get; set; }
    }
}
