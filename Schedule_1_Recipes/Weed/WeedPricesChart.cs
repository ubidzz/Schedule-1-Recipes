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
                case "59":
                    items = new[] {
                    "California Smegma",
                    };
                    break;
                case "118":
                    items = new[] {
                    "Tokyo Ass",
                    "Fruity Balls",
                    "Wedding Thunderfuck"
                    };
                    break;
                case "74":
                    items = new[] {
                    "Big Express",
                    "Mega Diesel",
                    "California Rhino"
                    };
                    break;
                case "82":
                    items = new[] {
                    "Island Rhino",
                    "Sweet Cheese",
                    "Island Rhino"
                    };
                    break;
                case "92":
                    items = new[] {
                    "Banana Diamond"
                    };
                    break;
                case "101":
                    items = new[] {
                    "Fruity Cum",
                    "Dark Ghost",
                    "Hairy Shart",
                    "Sweet Cum",
                    "Wedding Express"
                    };
                    break;
                case "111":
                    items = new[] {
                    "Death Urkle"
                    };
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
