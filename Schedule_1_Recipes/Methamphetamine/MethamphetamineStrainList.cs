namespace Schedule1Recipes
{
    internal sealed class MethamphetamineStrainList(ComboBox ListDropdown)
    {
        private ComboBox ListDropdown { get; set; } = ListDropdown;

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
            Array.Sort(items);
            foreach (string item in items)
            {
                ListDropdown.Items.Add(item);
            }

            ListDropdown.SelectedIndex = 0;
        }
    }
}
