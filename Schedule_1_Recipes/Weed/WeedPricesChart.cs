namespace Schedule1Recipes
{
    internal sealed class WeedPricesChart(ComboBox ListDropdown, ComboBox PricesDropdown)
    {
        private ComboBox ListDropdown { get; set; } = ListDropdown;
        private ComboBox PricesDropdown { get; set; } = PricesDropdown;
        // List Weed Prices
        public void AddWeedPricesChart()
        {
            string[] items = Array.Empty<string>();
            string SelectedWeed = PricesDropdown.SelectedItem?.ToString() ?? string.Empty;

            switch (SelectedWeed)
            {
                case "92":
                    items = new[] { "Banana Diamond" };
                    break;
                case "59":
                    items = new[] { "California Smegma" };
                    break;
                case "118":
                    items = new[] { "Fruity Balls", "Tokyo Ass", "Wedding Thunderfuck" };
                    break;
                case "74":
                    items = new[] { "Big Express", "California Rhino", "Mega Diesel" };
                    break;
                case "82":
                    items = new[] { "Island Rhino", "Sweet Cheese" };
                    break;
                case "85": 
                    items = new[] { "Afghan Punch", "Afghan Kush" }; 
                    break;
                case "101":
                    items = new[] { "Dark Ghost", "Fruity Cum", "Hairy Shart", "Sweet Cum", "Wedding Express" };
                    break;
                case "115":
                    items = new[] { "Purple Haze" };
                    break;
                case "128":
                    items = new[] { "Grape Ape" };
                    break;
                case "135":
                    items = new[] { "Sour Diesel" };
                    break;
                case "142":
                    items = new[] { "Blue Dream" };
                    break;
                case "150":
                    items = new[] { "Green Crack" };
                    break;
                case "158":
                    items = new[] { "Jack Herer" };
                    break;
                case "165":
                    items = new[] { "Northern Lights" };
                    break;
                case "173":
                    items = new[] { "OG Kush" };
                    break;
                case "180":
                    items = new[] { "Pineapple Express" };
                    break;
                case "188":
                    items = new[] { "Sour OG" };
                    break;
                case "195":
                    items = new[] { "Strawberry Cough" };
                    break;
                case "203":
                    items = new[] { "Super Lemon Haze" };
                    break;
                case "210":
                    items = new[] { "Tahoe OG" };
                    break;
                case "218":
                    items = new[] { "Trainwreck" };
                    break;
                case "225":
                    items = new[] { "White Widow" };
                    break;
            }
            if (items != null && items.Length > 0)
            {
                ListDropdown.Items.Clear(); // Clear the old list
                Array.Sort(items);
                foreach (string item in items)
                {
                    ListDropdown.Items.Add(item);
                }
                ListDropdown.SelectedIndex = 0;
            }
        }
    }
}
