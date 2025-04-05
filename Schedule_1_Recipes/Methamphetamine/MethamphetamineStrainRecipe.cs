namespace Schedule1Recipes
{
    internal sealed class MethamphetamineStrainRecipe(ComboBox ListDropdown, CheckedListBox CheckedRecipeListBox, TextBox ItemSellPrice, TextBox AddictivenessProgressTextBox, ProgressBar DrugAddictivenessProgressBar)
    {
        private ComboBox ListDropdown { get; set; } = ListDropdown;
        private CheckedListBox CheckedRecipeListBox { get; set; } = CheckedRecipeListBox;
        private TextBox ItemSellPrice { get; set; } = ItemSellPrice;
        private TextBox AddictivenessProgressTextBox { get; set; } = AddictivenessProgressTextBox;
        private ProgressBar DrugAddictivenessProgressBar { get; set; } = DrugAddictivenessProgressBar;

        public void ShowMethamphetamineStrainRecipe()
        {
            if (ListDropdown.SelectedItem != null)
            {
                string SelectedWeed = ListDropdown.SelectedItem?.ToString() ?? string.Empty;
                CheckedRecipeListBox.Items.Clear(); // Clear existing items
                CheckedRecipeListBox.CheckOnClick = true;

                switch (SelectedWeed)
                {
                    case "Strawbery Bud":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        CheckedRecipeListBox.Items.Add("Big Balls + Cuke = Shiny Mint", false);
                        CheckedRecipeListBox.Items.Add("Shiny Mint + Paracetamol = Aspen Stink", false);
                        CheckedRecipeListBox.Items.Add("Aspen Stink + Gasoline = Strawberry Fuel", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Fuel + Cuke = LA Balls", false);
                        CheckedRecipeListBox.Items.Add("LA Balls + Battery = Bannana McLovin", false);
                        CheckedRecipeListBox.Items.Add("Bannana McLovin + Horse Semen = Stinky Punch", false);
                        CheckedRecipeListBox.Items.Add("Stinky Punch + Mega Bean = Strawbery Bud", false);
                        ItemSellPrice.Text = "$343";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Stinky Punch":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        CheckedRecipeListBox.Items.Add("Big Balls + Cuke = Shiny Mint", false);
                        CheckedRecipeListBox.Items.Add("Shiny Mint + Paracetamol = Aspen Stink", false);
                        CheckedRecipeListBox.Items.Add("Aspen Stink + Gasoline = Strawberry Fuel", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Fuel + Cuke = LA Balls", false);
                        CheckedRecipeListBox.Items.Add("LA Balls + Battery = Bannana McLovin", false);
                        CheckedRecipeListBox.Items.Add("Bannana McLovin + Horse Semen = Stinky Punch", false);
                        ItemSellPrice.Text = "$267";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Bannana McLovin":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        CheckedRecipeListBox.Items.Add("Big Balls + Cuke = Shiny Mint", false);
                        CheckedRecipeListBox.Items.Add("Shiny Mint + Paracetamol = Aspen Stink", false);
                        CheckedRecipeListBox.Items.Add("Aspen Stink + Gasoline = Strawberry Fuel", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Fuel + Cuke = LA Balls", false);
                        CheckedRecipeListBox.Items.Add("LA Balls + Battery = Bannana McLovin", false);
                        ItemSellPrice.Text = "$231";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "LA Balls":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        CheckedRecipeListBox.Items.Add("Big Balls + Cuke = Shiny Mint", false);
                        CheckedRecipeListBox.Items.Add("Shiny Mint + Paracetamol = Aspen Stink", false);
                        CheckedRecipeListBox.Items.Add("Aspen Stink + Gasoline = Strawberry Fuel", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Fuel + Cuke = LA Balls", false);
                        ItemSellPrice.Text = "$175";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Strawberry Fuel":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        CheckedRecipeListBox.Items.Add("Big Balls + Cuke = Shiny Mint", false);
                        CheckedRecipeListBox.Items.Add("Shiny Mint + Paracetamol = Aspen Stink", false);
                        CheckedRecipeListBox.Items.Add("Aspen Stink + Gasoline = Strawberry Fuel", false);
                        ItemSellPrice.Text = "$147";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Aspen Stink":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        CheckedRecipeListBox.Items.Add("Big Balls + Cuke = Shiny Mint", false);
                        CheckedRecipeListBox.Items.Add("Shiny Mint + Paracetamol = Aspen Stink", false);
                        ItemSellPrice.Text = "$147";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Shiny Mint":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        CheckedRecipeListBox.Items.Add("Big Balls + Cuke = Shiny Mint", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Big Balls":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "90%";
                        DrugAddictivenessProgressBar.Value = 90;
                        break;
                }
            }
        }
    }
}
