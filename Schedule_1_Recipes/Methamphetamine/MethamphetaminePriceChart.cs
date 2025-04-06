using System.Globalization;

namespace Schedule1Recipes
{
    internal class MethamphetaminePriceChart(ComboBox ListDropdown, ComboBox PricesDropdown)
    {
        private ComboBox ListDropdown { get; set; } = ListDropdown;
        private ComboBox PricesDropdown { get; set; } = PricesDropdown;

        public void AddMethamphetaminePricesChart()
        {
            string[] items = [];
            string SelectedWeed = PricesDropdown.SelectedItem?.ToString() ?? string.Empty;

            switch (SelectedWeed)
            {
                case "94": items = ["Shiny Mint", "Big Balls"]; break;
                case "147": items = ["Strawberry Fuel", "Aspen Stink"]; break;
                case "175": items = ["LA Balls"]; break;
                case "231": items = ["Bannana McLovin"]; break;
                case "267": items = ["Stinky Punch"]; break;
                case "343": items = ["Strawbery Bud"]; break;
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
        public void BuildPricelist()
        {
            string[] prices = [
                "94", "147", "175", "231", "267", "343"
            ];

            // Sort the prices in ascending order as numbers
            Array.Sort(prices, (a, b) => int.Parse(a, CultureInfo.InvariantCulture).CompareTo(int.Parse(b, CultureInfo.InvariantCulture)));

            // Add the prices to the combobox
            PricesDropdown.Items.AddRange(prices);

            // Show the first item (lowest number) as selected
            if (PricesDropdown.Items.Count > 0)
            {
                PricesDropdown.SelectedIndex = 0;
                PricesDropdown.Text = PricesDropdown.Items[0]?.ToString();
            }
        }
    }
}
