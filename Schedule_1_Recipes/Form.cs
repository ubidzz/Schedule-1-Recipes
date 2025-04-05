using System.Diagnostics;
using System.Globalization;

namespace Schedule1Recipes
{
    public partial class Schedule1GameRecipes : Form
    {
        public Schedule1GameRecipes()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ListDropdown.KeyPress += ListDropdown_KeyPress;
            try
            {
                // Create a new form for the popup window
                Form popupForm = new()
                {
                    Text = "Information!",
                    Width = 288,
                    Height = 235,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    StartPosition = FormStartPosition.CenterScreen
                };

                // Add a rich text box for the message
                RichTextBox richTextBox = new()
                {
                    Location = new Point(10, 10),
                    Width = 250,
                    Height = 135,
                    ReadOnly = true,
                    Enabled = false
                };
                popupForm.Controls.Add(richTextBox);

                // Set the text of the rich text box
                richTextBox.Text = "This program is meant to be used on a different monitor so that you don't have to tab out of the game to see the recipes. \n\n";
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.AppendText("The Schedule 1 Recipes program will open when you close this popup window! \n\n");
                richTextBox.SelectionLength = 0;
                richTextBox.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox.SelectionFont = new Font("Microsoft Sans Serif", 10.25f, FontStyle.Bold);
                richTextBox.AppendText("Don't do drugs!");

                // Add a close button to the popup form
                Button closeButton = new()
                {
                    Text = "Close Window",
                    Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold),
                    Location = new Point(65, 160),
                    Width = 140
                };
                closeButton.Click += (sender, e) => popupForm.Close();
                popupForm.Controls.Add(closeButton);

                // Center the button
                closeButton.Location = new Point((popupForm.Width - closeButton.Width) / 2, closeButton.Location.Y);

                // Show the popup form when the program starts
                popupForm.ShowDialog();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during form load   
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            try
            {
                // Hide Prices onload
                PricesDropdown.Visible = false;
                DrugPrices.Visible = false;

                // Hide Weed Strains
                ItemText.Visible = false;
                ListDropdown.Visible = false;

                // Hide Methamphetamine Prices


                UncheckAll.Visible = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                ListAll.Visible = false;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during form load
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void WeedButton_Click(object sender, EventArgs e)
        {
            // Display Weed Recipes text
            ItemText.Text = "Weed Recipes";
            ItemText.Font = new Font(ItemText.Font.FontFamily, 14, FontStyle.Bold);

            // Display Recipes stuff
            DisplayRecipesStuff();

            // Build the weed price list
            WeedPricesChart WeedPriceList = new(ListDropdown, PricesDropdown);
            WeedPriceList.BuildPricelist();

            // Show weed recipes
            WeedStrainRecipe WeedRecipes = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox, DrugAddictivenessProgressBar);
            WeedRecipes.ShowWeedStrainRecipe();

            // Add Weed Prices
            //BuildPricelist();
        }

        private void MethamphetamineButton_Click(object sender, EventArgs e)
        {
            // Display Methamphetamine Recipes text
            ItemText.Text = "Methamphetamine Recipes";
            ItemText.Font = new Font(ItemText.Font.FontFamily, 14, FontStyle.Bold);

            // Display Recipes stuff
            DisplayRecipesStuff();

            // Show Methamphetamine Strains list
            MethamphetamineStrainList AddMethamphetamineList = new(ListDropdown);
            AddMethamphetamineList.AddMethamphetamineList();

            // Show Methamphetamine recipes
            MethamphetamineStrainRecipe AddMethamphetamineRecipes = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox, DrugAddictivenessProgressBar);
            AddMethamphetamineRecipes.ShowMethamphetamineStrainRecipe();

            // Add Methamphetamine Prices
            //BuildPricelist();
        }

        private void CocaineButton_Click(object sender, EventArgs e)
        {
            //Display Cocaine Recipes text
            ItemText.Text = "Cocaine Recipes";
            ItemText.Font = new Font(ItemText.Font.FontFamily, 14, FontStyle.Bold);

            // Display Recipes stuff
            DisplayRecipesStuff();

            // Show Cocaine Strains list
            CocaineStrainList AddCocaineList = new(ListDropdown);
            AddCocaineList.AddCocaineList();

            // Add Cocaine Prices
            //BuildPricelist();

            // Show Cocaine recipes
            CocaineStrainRecipe AddCocaineRecipes = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox, DrugAddictivenessProgressBar);
            AddCocaineRecipes.ShowCocaineStrainRecipe();
        }

        private void PricesDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedDrug = ItemText.Text;
            switch (SelectedDrug)
            {
                case "Weed Recipes":

                    WeedPricesChart AddWeedStrains = new(ListDropdown, PricesDropdown);
                    AddWeedStrains.AddWeedPricesChart();

                    break;
                case "Methamphetamine Recipes":
                    /*
                    MethamphetamineStrainRecipe AddMethamphetamineRecipe = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox);
                    AddMethamphetamineRecipe.ShowMethamphetamineStrainRecipe();
                    */
                    break;
                case "Cocaine Recipes":
                    /*
                    CocaineStrainRecipe AddCocaineRecipe = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox);
                    AddCocaineRecipe.ShowCocaineStrainRecipe();
                    */
                    break;
            }
        }

        private void ListDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddictivenessProgressTextBox.ForeColor = Color.DarkRed;
            AddictivenessProgressTextBox.Font = new Font(AddictivenessProgressTextBox.Font.Name, AddictivenessProgressTextBox.Font.Size, FontStyle.Bold);

            string SelectedDrug = ItemText.Text;
            switch (SelectedDrug)
            {
                case "Weed Recipes":
                    WeedStrainRecipe AddWeedRecipe = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox, DrugAddictivenessProgressBar);
                    AddWeedRecipe.ShowWeedStrainRecipe();
                    break;
                case "Methamphetamine Recipes":
                    MethamphetamineStrainRecipe AddMethamphetamineRecipe = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox, DrugAddictivenessProgressBar);
                    AddMethamphetamineRecipe.ShowMethamphetamineStrainRecipe();
                    break;
                case "Cocaine Recipes":
                    CocaineStrainRecipe AddCocaineRecipe = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox, DrugAddictivenessProgressBar);
                    AddCocaineRecipe.ShowCocaineStrainRecipe();
                    break;
            }
        }

        private void UncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckedRecipeListBox.Items.Count; i++)
            {
                CheckedRecipeListBox.SetItemChecked(i, false);
            }
        }

        private void DonationButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://www.paypal.com/ncp/payment/BS4KJ7EBU77TW", UseShellExecute = true });
        }

        // Display Recipes buttons, textBoxs, Dropdowns
        private void DisplayRecipesStuff()
        {
            ListDropdown.Items.Clear();
            ListDropdown.Refresh();
            PricesDropdown.Items.Clear();
            PricesDropdown.Refresh();
            PricesDropdown.Visible = true;
            DrugPrices.Visible = true;
            UncheckAll.Visible = true;
            ItemText.Visible = true;
            ListDropdown.Visible = true;
            ListAll.Visible = true;
        }


        private void ListDropdown_KeyPress(object? sender, KeyPressEventArgs e)
        {
            string pressedKey = e.KeyChar.ToString();
            string[] items = [.. ListDropdown.Items.Cast<object>().Select(item => item.ToString()!)];
            string? match = items.FirstOrDefault(i => i.StartsWith(pressedKey, StringComparison.OrdinalIgnoreCase));

            if (match is not null)
            {
                ListDropdown.SelectedItem = match;
                string newText = match[(ListDropdown.Text.Length + 1)..]; // Remove the matched text
                ListDropdown.Text = newText;
                if (sender != null)
                {
                    ListDropdown_SelectedIndexChanged(sender, EventArgs.Empty); // Call the method
                }
            }
        }

        private void ListAll_Click(object sender, EventArgs e)
        {
            string SelectedDrug = ItemText.Text;
            switch (SelectedDrug)
            {
                case "Weed Recipes":

                    WeedStrainList AddAllWeedStrains = new(ListDropdown, PricesDropdown);
                    AddAllWeedStrains.AddWeedList();

                    break;
                case "Methamphetamine Recipes":
                    /*
                    MethamphetamineStrainRecipe AddMethamphetamineRecipe = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox);
                    AddMethamphetamineRecipe.ShowMethamphetamineStrainRecipe();
                    */
                    break;
                case "Cocaine Recipes":
                    /*
                    CocaineStrainRecipe AddCocaineRecipe = new(ListDropdown, CheckedRecipeListBox, ItemSellPrice, AddictivenessProgressTextBox);
                    AddCocaineRecipe.ShowCocaineStrainRecipe();
                    */
                    break;
            }
        }
    }
}
