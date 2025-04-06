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
                "Strawbery Bud",
                "Stinky Punch",
                "Bannana McLovin",
                "LA Balls",
                "Strawberry Fuel",
                "Aspen Stink",
                "Shiny Mint",
                "Big Balls"
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
