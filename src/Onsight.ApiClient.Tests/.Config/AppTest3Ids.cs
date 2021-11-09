// ReSharper disable InconsistentNaming
namespace Onsight.ApiClient.Tests.Config
{
    public static class AppTest3Ids
    {
        public class CustomerIds
        {
            public const long LowPriceCustomer = 712466;
            public const long HighPriceCustomer = 712465;
            public const long HighAndLowPriceCustomer = 712467;
            public const long LimitedAccessCustomer = 712463;
            public const long BelongsToAppUser = 712468;
            public const long FullyDetailedCustomer = 712464;
        }

        public class CategoryIds
        {
            public const long Arrows = 281840 ;
            public const long Arrows_Carets = 281841;
            public const long Arrows_RoundArrows = 281845;

            public const long TaxConfiguration = 281842;

            public const long CustomerGroupProducts = 281843;
            public const long CustomerGroupProducts_LimitedAccessProducts = 281846;
            public const long CustomerGroupProducts_OverridePriceProducts = 281844;
            
            public const long ThingsThatPointLeft = 281847;

            public const long Scanners = 281839;
        }

        public class ProductIds
        {
            public class Arrows
            {
                public class Carets
                {
                    public const long LeftCaret = 2505631;
                    public const long RightCaret = 2505640;
                    public const long UpCaret = 2505642;
                    public const long DownCaret = 2505626;
                }

                public class RoundArrows
                {
                    public const long MasterRoundArrow = 2505622;

                    public class Variants
                    {
                        public const long LeftRound = 2505632;
                        public const long RightRound = 2505641;
                    }
                }
            }

            public class CustomerGroupProducts
            {
                public class LimitedAccessProducts
                {
                    public const long LimitedAccessProduct = 2505633;
                }

                public class OverridePriceProducts
                {
                    public const long HighLowPricesAndDiscount = 2505630;
                }
            }
            
            public class Scanners
            {
                public const long BluetoothScanner = 2505625;
                public const long AssociatedBluetoothScanner = 2505624;
                public const long AlternativeBluetoothScanner = 2505623;
            }

            public class TaxConfiguration
            {
                public const long FixedPercentageTaxProduct = 2505627;
                public const long FixedValueTaxProduct = 2505628;
                public const long GroupTaxesProduct = 2505629;
                public const long MultipleTaxesProduct = 2505634;
                public const long NoTaxesProduct = 2505635;
                public const long PercentageWithMaxTaxProductAboveMax = 2505636;
                public const long PercentageWithMaxTaxProductBelowMax = 2505637;
                public const long PercentageWithThresholdTaxProductAboveThreshold = 2505639;
                public const long PercentageWithThresholdTaxProductBelowThreshold = 2505638;
            }

            public class ThingsThatPointLeft
            {
                public const long LeftCaret = 2505631;
            }

        }
         
    }
}