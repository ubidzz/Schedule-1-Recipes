namespace Schedule1Recipes
{
    internal sealed class CocaineStrainRecipe(ComboBox ListDropdown, CheckedListBox CheckedRecipeListBox, TextBox ItemSellPrice, TextBox AddictivenessProgressTextBox, ProgressBar DrugAddictivenessProgressBar)
    {
        private ComboBox ListDropdown { get; set; } = ListDropdown;
        private CheckedListBox CheckedRecipeListBox { get; set; } = CheckedRecipeListBox;
        private TextBox ItemSellPrice { get; set; } = ItemSellPrice;
        private TextBox AddictivenessProgressTextBox { get; set; } = AddictivenessProgressTextBox;
        private ProgressBar DrugAddictivenessProgressBar { get; set; } = DrugAddictivenessProgressBar;
        public void ShowCocaineStrainRecipe()
        {
            if (ListDropdown.SelectedItem != null)
            {
                string SelectedWeed = ListDropdown.SelectedItem?.ToString() ?? string.Empty;
                CheckedRecipeListBox.Items.Clear(); // Clear existing items
                CheckedRecipeListBox.CheckOnClick = true;

                Graphics g = DrugAddictivenessProgressBar.CreateGraphics();
                Rectangle rect = DrugAddictivenessProgressBar.ClientRectangle;
                g.FillRectangle(Brushes.Red, 0, 0, rect.Width, rect.Height);

                switch (SelectedWeed)
                {
                    case "Afghan Punch":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Banana = Dream Cum", false);
                        CheckedRecipeListBox.Items.Add("Dream Cum + Paracetamol = White Slime", false);
                        CheckedRecipeListBox.Items.Add("White Slime + Donut = California Afghan Punch", false);
                        ItemSellPrice.Text = "$85";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                }
            }
        }
    }
}
