namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The 'Id' from dbo.PrizeModel table. The unique identifier for the given prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 1st place, second place
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// What is called? E.g., Champion, silver medal, bronze medal, etc.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// a Dollar value of how much the winner won
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// 0.4,0.5, etc
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel() {}
        
        /// <summary>
        /// Using 'Overload Constructor'
        /// </summary>
        /// <param name="placeNumber"></param>
        /// <param name="placeName"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            // try parse 'Place Number' field. Not doing validation here.
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            // 'Place Name' field.
            PlaceName = placeName;

            // try parse 'Prize Amount' field. Not doing validation here.
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            // try parse 'Prize Percentage' field. Not doing validation here.
            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }

   
}