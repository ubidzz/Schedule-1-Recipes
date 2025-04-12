namespace Schedule1Recipes
{
    internal sealed class MethamphetamineStrainList(ComboBox ListDropdown, ComboBox PricesDropdown)
    {
        private ComboBox ListDropdown { get; set; } = ListDropdown;
        private ComboBox PricesDropdown { get; set; } = PricesDropdown;

        // List all weeds
        public void AddMethamphetamineList()
        {
            string[] items = [
                "Afghan Cum",
                "Afghan Fruit",
                "ASpen Stink",
                "Aspen Cake",
                "Aspen Fuel",
                "Bananana Cookies",
                "Bananana Urkle",
                "Banana Cookies",
                "Banana McLovin",
                "Banana Urkle",
                "Big Balls",
                "Big Shart",
                "Bio Fuel",
                "California Monkey",
                "California Urkle",
                "Dark Cum",
                "Dark Urkle",
                "Death Thunderfuck",
                "Extreme Cake",
                "Extreme Cheese",
                "Extreme Piss",
                "Extreme Rhino",
                "Extreme Shart",
                "Fat Ass",
                "Fat Balls",
                "Fat Durkle",
                "Fat Haze",
                "Girl Scout Death",
                "Gorilla Assblaster",
                "Gorilla Bud",
                "Gorilla Cake",
                "Gorilla McLovin",
                "Gorilla Slime",
                "Gorilla Smegma",
                "Granddaddy Cheese",
                "Granddaddy Crack",
                "Hairy Assblaster",
                "Ice Cream Cock",
                "Ice Cream Death",
                "Ice Cream Fuel",
                "Ice Cream Ghost",
                "Island Death",
                "Island Slime",
                "LA Balls",
                "Mega Fruit",
                "Mega Smegma",
                "Miracle Cock",
                "Miracle Durkle",
                "Nightmare Fruit",
                "Pink Thunderfuck",
                "Purple Diamond",
                "Purple Gold",
                "Purple Monkey",
                "Purple Shart",
                "Sexy Death",
                "Sexy Fruit",
                "Sexy Puke",
                "Shiny Bud",
                "Shiny Fuel",
                "Shiny Mint",
                "Slimy Bud",
                "Slimy Durkle",
                "Slimy Puke",
                "Slimy Urkle",
                "Sliny Fuel",
                "Stawberry Cock",
                "Stawberry Cum",
                "Strawberry Bud",
                "Strawberry Cum",
                "Strawberry Fuel",
                "Strawberry Urkle",
                "Strawy Crack",
                "Stinky Punch",
                "Stinky Queef",
                "Stinky Smegma",
                "Stinky Thunderfuck",
                "Super Crack",
                "Super Fuel",
                "Sweet Death",
                "Sweet Slime",
                "Thick Ass",
                "Tokyo Fruit",
                "Tokyo McLovin",
                "Tokyo Monkey",
                "Ultra Cheese",
                "Ultra Fuel",
                "Ultra Queef",
                "Weddding Ghost",
                "Wedding Diesel",
                "Wedding Haze",
                "White Crack",
                "White Dick",
                "White Durkle"
            ];

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
