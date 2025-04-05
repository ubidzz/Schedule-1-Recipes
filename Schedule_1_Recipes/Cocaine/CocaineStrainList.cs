namespace Schedule1Recipes
{
    internal sealed class CocaineStrainList(ComboBox ListDropdown)
    {
        private ComboBox ListDropdown { get; set; } = ListDropdown;

        // List all weeds
        public void AddCocaineList()
        {
            string[] items = [
                "Afghan Punch",
                "Afghan Queef",
                "Afghan Rhino 2"
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
