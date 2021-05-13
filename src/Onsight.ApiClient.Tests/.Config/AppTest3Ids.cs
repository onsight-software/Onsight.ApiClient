// ReSharper disable InconsistentNaming
namespace Onsight.ApiClient.Tests.Config
{
    public static class AppTest3Ids
    {
        public class CustomerIds
        {
            public static long LowPriceCustomer = 712466;
            public static long HighPriceCustomer = 712465;
            public static long HighAndLowPriceCustomer = 712467;
            public static long LimitedAccessCustomer = 712463;
            public static long BelongsToAppUser = 712468;
            public static long FullyDetailedCustomer = 712464;
        }

        public class CategoryIds
        {
            public static long Arrows = 281840 ;
            public static long Arrows_Carets = 281841;
            public static long Arrows_RoundArrows = 281845;

            public static long TaxConfiguration = 281842;

            public static long CustomerGroupProducts = 281843;
            public static long CustomerGroupProducts_LimitedAccessProducts = 281846;
            public static long CustomerGroupProducts_OverridePriceProducts = 281844;
            
            public static long ThingsThatPointLeft = 281847;

            public static long Scanners = 281839;
        }

        public class ProductIds
        {
            public class Arrows
            {
                public class Carets
                {
                    public static long LeftCaret = 2505631;
                    public static long RightCaret = 2505640;
                    public static long UpCaret = 2505642;
                    public static long DownCaret = 2505626;
                }

                public class RoundArrows
                {
                    public static long MasterRoundArrow = 2505622;

                    public class Variants
                    {
                        public static long LeftRound = 2505632;
                        public static long RightRound = 2505641;
                    }
                }
            }

            public class CustomerGroupProducts
            {
                public class LimitedAccessProducts
                {
                    public static long LimitedAccessProduct = 2505633;
                }

                public class OverridePriceProducts
                {
                    public static long HighLowPricesAndDiscount = 2505630;
                }
            }
            
            public class Scanners
            {
                public static long BluetoothScanner = 2505625;
                public static long AssociatedBluetoothScanner = 2505624;
                public static long AlternativeBluetoothScanner = 2505623;
            }

            public class TaxConfiguration
            {
                public static long FixedPercentageTaxProduct = 2505627;
                public static long FixedValueTaxProduct = 2505628;
                public static long GroupTaxesProduct = 2505629;
                public static long MultipleTaxesProduct = 2505634;
                public static long NoTaxesProduct = 2505635;
                public static long PercentageWithMaxTaxProductAboveMax = 2505636;
                public static long PercentageWithMaxTaxProductBelowMax = 2505637;
                public static long PercentageWithThresholdTaxProductAboveThreshold = 2505639;
                public static long PercentageWithThresholdTaxProductBelowThreshold = 2505638;
            }

            public class ThingsThatPointLeft
            {
                public static long LeftCaret = 2505631;
            }

        }
         
    }
}