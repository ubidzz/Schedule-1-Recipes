using System.Globalization;

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
                case "41": items = new[] { "Extreme Durkle" }; break;
                case "43": items = new[] { "Dark Bud" }; break;
                case "47": items = new[] { "Pink Ass" }; break;
                case "49": items = new[] { "California Cookies", "Green Crack" }; break;
                case "50": items = new[] { "Strawberry Shart" }; break;
                case "51": items = new[] { "Ultra Cake" }; break;
                case "52": items = new[] { "California Puke", "Ultra Cookies" }; break;
                case "53": items = new[] { "Fat Cum" }; break;
                case "54": items = new[] { "Aspen Smegma", "California Grool", "Stinky Cake", "Thick Stink", "Ultra Grool", "Wedding Ass", "Wedding Crack" }; break;
                case "55": items = new[] { "Aspen Death" }; break;
                case "57": items = new[] { "Big Express", "Slimy Haze", "Stinky Cake" }; break;
                case "58": items = new[] { "Fruity Ass", "Strawberry Cheese" }; break;
                case "59": items = new[] { "California Smegma" }; break;
                case "60": items = new[] { "Bio Bud", "Island Rhino", "Mega Bean", "Mega Monkey" }; break;
                case "61": items = new[] { "Big Fruit", "Bio Bud", "Island Cock" }; break;
                case "62": items = new[] { "California Smegma", "Gorilla Stink", "Hairy Balls", "Super Dick", "Sweet Shart", "Wedding Ass" }; break;
                case "64": items = new[] { "Gorilla Stink", "Pink Rhino" }; break;
                case "66": items = new[] { "Big Express" }; break;
                case "67": items = new[] { "Big Cum", "Dream Cum", "Shiny Splooge" }; break;
                case "69": items = new[] { "Bio Mint", "California Punch", "Hairy Mint" }; break;
                case "70": items = new[] { "Mega Fuel" }; break;
                case "71": items = new[] { "Strawberry Piss" }; break;
                case "72": items = new[] { "Afghan Rhino", "Afgham Rhino" }; break;
                case "73": items = new[] { "Fat Fuel", "Miracle Shart" }; break;
                case "74": items = new[] { "Big Express", "California Rhino", "Mega Diesel" }; break;
                case "76": items = new[] { "Big Crack", "Nightmare Crystal", "Wedding Puke", "White Slime" }; break;
                case "77": items = new[] { "Pink Fuel", "Super Slime" }; break;
                case "78": items = new[] { "Aspen Rhino" }; break;
                case "81": items = new[] { "Fruity Haze" }; break;
                case "82": items = new[] { "Island Rhino", "Sweet Cheese" }; break;
                case "83": items = new[] { "Big Fruit", "Hairy Balls", "Island Cock", "Nightmare Monkey", "OG Rhino" }; break;
                case "84": items = new[] { "Bio Puke" }; break;
                case "85": items = new[] { "Afghan Punch", "Afgham Punch", "Pink Balls" }; break;
                case "86": items = new[] { "Fat Shart", "Wedding Bud" }; break;
                case "87": items = new[] { "LA Crack", "Strawberry Durkle", "Stinky Puke", "Sweet Fruit" }; break;
                case "90": items = new[] { "Extreme Balls", "Nightmare Balls", "Thick Cock" }; break;
                case "91": items = new[] { "Aspen Mint", "Fat Shart", "Hairy Gold", "Hairy Shart", "Ice Cream Durkle", "Thick Dick", "Thick Piss" }; break;
                case "92": items = new[] { "Banana Diamond" }; break;
                case "94": items = new[] { "Afghan Queef", "Afgham Queef", "Girl Scout Crystal", "Pink Ass", "Stawberry Cheese", "Stinky Puke", "Strawberry Shart", "Sweet ThunderFuck" }; break;
                case "95": items = new[] { "Mega Punch", "Miracle McLovin", "Sweet ThunderFuck", "Thick McLonin", "Ultra Grool" }; break;
                case "96": items = new[] { "Pink Fruit", "Tokyo Mint" }; break;
                case "97": items = new[] { "Granddaddy Cookies", "Nightmare Grool" }; break;
                case "98": items = new[] { "Extreme Mokey" }; break;
                case "99": items = new[] { "Aspen Fruit", "Ultra Puke" }; break;
                case "100": items = new[] { "Tokyo Piss" }; break;
                case "101": items = new[] { "Dark Ghost", "Fruity Cum", "Hairy Shart", "Sweet Cum", "Wedding Express" }; break;
                case "102": items = new[] { "California Death", "Fruity Haze", "Hairy Shart", "Shiny Shart", "Slimy Balls", "Sweet Haze", "Tokyo Balls" }; break;
                case "104": items = new[] { "Mega Cheese", "Pink Haze" }; break;
                case "107": items = new[] { "Banana Cheese", "Mega Bud" }; break;
                case "108": items = new[] { "Mega Punch", "Mega Rhino", "Nightmare Grool", "Sweet Assblaster" }; break;
                case "109": items = new[] { "Miracle Crack", "Strawberry Thunderfuck" }; break;
                case "110": items = new[] { "Girl Scout Dick", "Thick Balls" }; break;
                case "111": items = new[] { "Death Urkle" }; break;
                case "113": items = new[] { "Gorilla Splooge" }; break;
                case "114": items = new[] { "White Stink" }; break;
                case "115": items = new[] { "Death Cock" }; break;
                case "116": items = new[] { "Banana Thunderfuck", "Fruity Balls", "Fruity Rhino", "Pink Puke", "White Punch" }; break;
                case "117": items = new[] { "OG Splooge" }; break;
                case "118": items = new[] { "Tokyo Ass", "Wedding Thunderfuck" }; break;
                case "120": items = new[] { "Island Diamond", "Pink Puke" }; break;
                case "121": items = new[] { "Stinky Rhino" }; break;
                case "131": items = new[] { "Banana Dick", "California Dick" }; break;
                case "136": items = new[] { "White Cheese" }; break;
                case "145": items = new[] { "Purple Punch" }; break;
                case "146": items = new[] { "Granddaddy Stink" }; break;
                case "200": items = new[] { "Girl Scout Punch" }; break;
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
            string[] prices = new string[] {
        "41", "43", "47", "49", "50", "51", "52", "53", "54", "55", "57", "58", "59", "60", "61", "62", "64", "66", "67", "69", "70", "71", "72", "73", "74", "76", "77", "78", "81", "82", "83", "84", "85", "86", "87", "90", "91", "92", "94", "95", "96", "97", "98", "99", "100", "101", "102", "104", "107", "108", "109", "110", "111", "113", "114", "115", "116", "117", "118", "120", "121", "131", "136", "145", "146", "200"
    };

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
