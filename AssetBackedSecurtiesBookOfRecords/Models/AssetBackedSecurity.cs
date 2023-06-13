using System;
using System.Collections.Generic;

namespace AssetBackedSecurity.Models
{
    // Asset-Backed Security (ABS) model
    public class AssetBackedSecurity
    {
        // ABS properties
        public int ABSId { get; set; } // Unique ID of the ABS
        public string ABSName { get; set; } // Name of the ABS
        public List<UnderlyingAsset> UnderlyingAssets { get; set; } // List of underlying assets
        public List<CashFlow> CashFlows { get; set; } // List of cash flows
        public List<PaymentSchedule> PaymentSchedules { get; set; } // List of payment schedules
        public List<Tranche> Tranches { get; set; } // List of tranches
        public IssuanceDetails IssuanceDetails { get; set; } // Issuance details
        public ServicingDetails ServicingDetails { get; set; } // Servicing details
        public PerformanceMetrics PerformanceMetrics { get; set; } // Performance metrics

        // Other relevant properties

        // Default constructor to initialize collections
        public AssetBackedSecurity()
        {
            UnderlyingAssets = new List<UnderlyingAsset>();
            CashFlows = new List<CashFlow>();
            PaymentSchedules = new List<PaymentSchedule>();
            Tranches = new List<Tranche>();
            IssuanceDetails = new IssuanceDetails();
            ServicingDetails = new ServicingDetails();
            PerformanceMetrics = new PerformanceMetrics();
        }
    }

    // Underlying Asset model
    public class UnderlyingAsset
    {
        // Underlying asset properties
        public int AssetId { get; set; } // Unique ID of the asset
        public string AssetName { get; set; } // Name of the asset
        public decimal AssetValue { get; set; } // Value of the asset
        public DateTime PurchaseDate { get; set; } // Purchase date of the asset
        public string PurchaseLocation { get; set; } // Purchase location of the asset

        // Other properties related to the underlying asset
    }

    // Cash Flow model
    public class CashFlow
    {
        // Cash flow properties
        public int CashFlowId { get; set; } // Unique ID of the cash flow
        public DateTime FlowDate { get; set; } // Date of the cash flow
        public decimal FlowAmount { get; set; } // Amount of the cash flow
        public string FlowType { get; set; } // Type of the cash flow

        // Other properties related to the cash flow
    }

    // Payment Schedule model
    public class PaymentSchedule
    {
        // Payment schedule properties
        public int ScheduleId { get; set; } // Unique ID of the payment schedule
        public DateTime PaymentDate { get; set; } // Date of the payment
        public decimal PaymentAmount { get; set; } // Amount of the payment
        public bool IsPaid { get; set; } // Flag indicating if the payment is paid

        // Other properties related to the payment schedule
    }

    // Tranche model
    public class Tranche
    {
        // Tranche properties
        public int TrancheId { get; set; } // Unique ID of the tranche
        public string TrancheName { get; set; } // Name of the tranche
        public decimal PrincipalBalance { get; set; } // Principal balance of the tranche
        public decimal InterestRate { get; set; } // Interest rate of the tranche
        public DateTime MaturityDate { get; set; } // Maturity date of the tranche

        // Other properties related to the tranche
    }

    // Issuance Details model
    public class IssuanceDetails
    {
        // Issuance details properties
        public string Issuer { get; set; } // Issuer of the ABS
        public DateTime IssuanceDate { get; set; } // Date of issuance
        public decimal TotalValue { get; set; } // Total value of the ABS
        public string OfferingType { get; set; } // Type of offering

        // Other properties related to the issuance details
    }

    // Servicing Details model
    public class ServicingDetails
    {
        // Servicing details properties
        public string Servicer { get; set; } // Servicer of the ABS
        public DateTime StartDate { get; set; } // Start date of servicing
        public DateTime EndDate { get; set; } // End date of servicing
        public decimal FeePercentage { get; set; } // Fee percentage for servicing

        // Other properties related to the servicing details
    }

    // Performance Metrics model
    public class PerformanceMetrics
    {
        // Performance metrics properties
        public decimal TotalPayments { get; set; } // Total payments received
        public decimal PrincipalOutstanding { get; set; } // Principal outstanding
        public decimal InterestReceived { get; set; } // Interest received

        // Other properties related to the performance metrics
    }
}
