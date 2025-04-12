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
                case "84": items = ["Strawy Crack"]; break;
                case "85": items = ["Aspen Cake", "Banana Urkle", "Big Shart"]; break;
                case "91": items = ["Fat Ass"]; break;
                case "94": items = ["Shiny Mint", "Big Balls"]; break;
                case "95": items = ["Slimy Urkle"]; break;
                case "97": items = ["Mega Smegma", "Strawberry Urkle"]; break;
                case "101": items = ["Gorilla Bud"]; break;
                case "102": items = ["Sweet Smegma"]; break;
                case "105": items = ["Dark Urkle"]; break;
                case "106": items = ["Gorilla Assblaster", "Death Thunderfuck"]; break;
                case "111": items = ["Purple Shart"]; break;
                case "113": items = ["Tokyo McLovin", "Ice Cream Death"]; break;
                case "120": items = ["Bio Fuel"]; break;
                case "122": items = ["Sweet Sliime", "Stinky Queef", "Weddding Ghost"]; break;
                case "123": items = ["Tokyo Express", "Sliny Fuel", "Gorilla McLovin"]; break;
                case "125": items = ["ASpen Stink"]; break;
                case "133": items = ["Sexy Death"]; break;
                case "136": items = ["Tokyo Fruit"]; break;
                case "139": items = ["Fat Durkle"]; break;
                case "147": items = ["Strawberry Fuel", "Aspen Stink", "Slimy Bud"]; break;
                case "148": items = ["Island Death"]; break;
                case "151": items = ["Gorilla Cake"]; break;
                case "154": items = ["Dark Cum", "Extreme Rhino"]; break;
                case "160": items = ["Nightmare Puke"]; break;
                case "161": items = ["Stawberry Cum"]; break;
                case "162": items = ["Afghtan Fruit", "Banana Cookies"]; break;
                case "167": items = ["Sexy Puke", "Slimy Bud"]; break;
                case "175": items = ["LA Balls"]; break;
                case "188": items = ["Afghan Cum"]; break;
                case "189": items = ["California Monkey"]; break;
                case "196": items = ["Aspen Fuel"]; break;
                case "216": items = ["White Durkle"]; break;
                case "231": items = ["Bannana McLovin", "Banana McLovin"]; break;
                case "244": items = ["Tokyo Monkey"]; break;
                case "258": items = ["California Urkle"]; break;
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
                "84",
                "85",
                "91",
                "94",
                "95",
                "97",
                "101",
                "102",
                "105",
                "106",
                "111",
                "113",
                "120",
                "122",
                "123",
                "125",
                "133",
                "136",
                "139",
                "147",
                "148",
                "151",
                "154",
                "160",
                "161",
                "162",
                "167",
                "175",
                "188",
                "189",
                "196",
                "216",
                "231",
                "244",
                "258",
                "267",
                "343"
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
