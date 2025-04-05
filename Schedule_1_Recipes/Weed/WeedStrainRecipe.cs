namespace Schedule1Recipes
{
    internal sealed class WeedStrainRecipe(ComboBox ListDropdown, CheckedListBox CheckedRecipeListBox, TextBox ItemSellPrice, TextBox AddictivenessProgressTextBox, ProgressBar DrugAddictivenessProgressBar)
    {
        private ComboBox ListDropdown { get; set; } = ListDropdown;
        private CheckedListBox CheckedRecipeListBox { get; set; } = CheckedRecipeListBox;
        private TextBox ItemSellPrice { get; set; } = ItemSellPrice;
        private TextBox AddictivenessProgressTextBox { get; set; } = AddictivenessProgressTextBox;
        private ProgressBar DrugAddictivenessProgressBar { get; set; } = DrugAddictivenessProgressBar;

        public void ShowWeedStrainRecipe()
        {
            if (ListDropdown.SelectedItem != null)
            {
                string SelectedWeed = ListDropdown.SelectedItem?.ToString() ?? string.Empty;
                CheckedRecipeListBox.Items.Clear(); // Clear existing items
                CheckedRecipeListBox.CheckOnClick = true;

                switch (SelectedWeed)
                {
                    case "Tokyo Ass":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Mouthwash = Death Urkle", false);
                        CheckedRecipeListBox.Items.Add("Death Urkle + Red Ball = Tokyo Ass", false);
                        ItemSellPrice.Text = "$118";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "California Smegma":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        ItemSellPrice.Text = "$59";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "California Rhino":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        ItemSellPrice.Text = "$74";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Island Rhino":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        ItemSellPrice.Text = "$82";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Banana Diamond":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        ItemSellPrice.Text = "$92";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sweet Cum":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        ItemSellPrice.Text = "$101";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Death Urkle":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Mouthwash = Death Urkle", false);
                        ItemSellPrice.Text = "$111";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Afghan Punch":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Banana = Dream Cum", false);
                        CheckedRecipeListBox.Items.Add("Dream Cum + Paracetamol = White Slime", false);
                        CheckedRecipeListBox.Items.Add("White Slime + Donut = California Afghan Punch", false);
                        ItemSellPrice.Text = "$85";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "White Slime":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Banana = Dream Cum", false);
                        CheckedRecipeListBox.Items.Add("Dream Cum + Paracetamol = White Slime", false);
                        ItemSellPrice.Text = "$76";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Dream Cum":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Banana = Dream Cum", false);
                        ItemSellPrice.Text = "$67";
                        AddictivenessProgressTextBox.Text = "85%";
                        DrugAddictivenessProgressBar.Value = 85;
                        break;
                    case "Big Cum":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        ItemSellPrice.Text = "$67";
                        AddictivenessProgressTextBox.Text = "85%";
                        DrugAddictivenessProgressBar.Value = 85;
                        break;
                    case "Afghan Queef":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Gasoline = Afghan Queef", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Afghan Rhino":
                        CheckedRecipeListBox.Items.Add("Green Crack + Battery = Sweet Cake", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cake + Addy = Afghan Rhino", false);
                        ItemSellPrice.Text = "$72";
                        AddictivenessProgressTextBox.Text = "96%";
                        DrugAddictivenessProgressBar.Value = 96;
                        break;
                    case "Girl Scout Punch":
                        CheckedRecipeListBox.Items.Add("Og Kush + Paracetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        CheckedRecipeListBox.Items.Add("Pink Ass + Paracetamol = Fat Fuel", false);
                        CheckedRecipeListBox.Items.Add("Fat Fuel + Gasoline = Bio Puke", false);
                        CheckedRecipeListBox.Items.Add("Bio Puke + Cuke = Extreme Mokey", false);
                        CheckedRecipeListBox.Items.Add("Extreme Mokey + Mega Bean = White Cheese", false);
                        CheckedRecipeListBox.Items.Add("White Cheese + Battery = Girl Scout Punch", false);
                        ItemSellPrice.Text = "$200";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "White Cheese":
                        CheckedRecipeListBox.Items.Add("Og Kush + Paracetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        CheckedRecipeListBox.Items.Add("Pink Ass + Paracetamol = Fat Fuel", false);
                        CheckedRecipeListBox.Items.Add("Fat Fuel + Gasoline = Bio Puke", false);
                        CheckedRecipeListBox.Items.Add("Bio Puke + Cuke = Extreme Mokey", false);
                        CheckedRecipeListBox.Items.Add("Extreme Mokey + Mega Bean = White Cheese", false);
                        ItemSellPrice.Text = "$136";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Extreme Mokey":
                        CheckedRecipeListBox.Items.Add("Og Kush + Paracetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        CheckedRecipeListBox.Items.Add("Pink Ass + Paracetamol = Fat Fuel", false);
                        CheckedRecipeListBox.Items.Add("Fat Fuel + Gasoline = Bio Puke", false);
                        CheckedRecipeListBox.Items.Add("Bio Puke + Cuke = Extreme Mokey", false);
                        ItemSellPrice.Text = "$98";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Bio Puke":
                        CheckedRecipeListBox.Items.Add("Og Kush + Paracetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        CheckedRecipeListBox.Items.Add("Pink Ass + Paracetamol = Fat Fuel", false);
                        CheckedRecipeListBox.Items.Add("Fat Fuel + Gasoline = Bio Puke", false);
                        ItemSellPrice.Text = "$84";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Fat Fuel":
                        CheckedRecipeListBox.Items.Add("Og Kush + Paracetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        CheckedRecipeListBox.Items.Add("Pink Ass + Paracetamol = Fat Fuel", false);
                        ItemSellPrice.Text = "$73";
                        AddictivenessProgressTextBox.Text = "98%";
                        DrugAddictivenessProgressBar.Value = 98;
                        break;
                    case "Pink Ass":
                        CheckedRecipeListBox.Items.Add("Og Kush + Paracetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        ItemSellPrice.Text = "$47";
                        AddictivenessProgressTextBox.Text = "48%";
                        DrugAddictivenessProgressBar.Value = 48;
                        break;
                    case "Aspen Death":
                        CheckedRecipeListBox.Items.Add("Og Kush + Paracetamol = Aspen Death", false);
                        ItemSellPrice.Text = "$55";
                        AddictivenessProgressTextBox.Text = "68%";
                        DrugAddictivenessProgressBar.Value = 68;
                        break;
                    case "Afgham Punch":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Banana = Dream Cum", false);
                        CheckedRecipeListBox.Items.Add("Dream Cum + Paracetamol = White Slime", false);
                        CheckedRecipeListBox.Items.Add("White Slime + Donut = Afgham Punch", false);
                        ItemSellPrice.Text = "$85";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Afgham Queef":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Gasoline = Afgham Queef", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Afgham Rhino":
                        CheckedRecipeListBox.Items.Add("Green Crack + Battery = Stinky Cake", false);
                        CheckedRecipeListBox.Items.Add("Stinky Cake + Addy = Afgham Rhino", false);
                        ItemSellPrice.Text = "$72";
                        AddictivenessProgressTextBox.Text = "96%";
                        DrugAddictivenessProgressBar.Value = 96;
                        break;
                    case "Aspen Fruit":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        CheckedRecipeListBox.Items.Add("Fat Cum + Battery = Shiny Splooge", false);
                        CheckedRecipeListBox.Items.Add("Shiny Splooge + Addy = Nightmare Monkey", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Monkey + Donut = Pink Piss", false);
                        CheckedRecipeListBox.Items.Add("Pink Piss + Chili = Mega Cheese", false);
                        CheckedRecipeListBox.Items.Add("Mega Cheese + Energy Drink = Mega Rhino", false);
                        CheckedRecipeListBox.Items.Add("Mega Rhino + Flu Medicine = Thick McLovin", false);
                        CheckedRecipeListBox.Items.Add("Thick McLovin + Cuke = Nightmare Grool", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Grool + Iodine = Aspen Fruit", false);
                        ItemSellPrice.Text = "$99";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Nightmare Grool":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        CheckedRecipeListBox.Items.Add("Fat Cum + Battery = Shiny Splooge", false);
                        CheckedRecipeListBox.Items.Add("Shiny Splooge + Addy = Nightmare Monkey", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Monkey + Donut = Pink Piss", false);
                        CheckedRecipeListBox.Items.Add("Pink Piss + Chili = Mega Cheese", false);
                        CheckedRecipeListBox.Items.Add("Mega Cheese + Energy Drink = Mega Rhino", false);
                        CheckedRecipeListBox.Items.Add("Mega Rhino + Flu Medicine = Thick McLovin", false);
                        CheckedRecipeListBox.Items.Add("Thick McLovin + Cuke = Nightmare Grool", false);
                        ItemSellPrice.Text = "$108";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Thick McLovin":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        CheckedRecipeListBox.Items.Add("Fat Cum + Battery = Shiny Splooge", false);
                        CheckedRecipeListBox.Items.Add("Shiny Splooge + Addy = Nightmare Monkey", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Monkey + Donut = Pink Piss", false);
                        CheckedRecipeListBox.Items.Add("Pink Piss + Chili = Mega Cheese", false);
                        CheckedRecipeListBox.Items.Add("Mega Cheese + Energy Drink = Mega Rhino", false);
                        CheckedRecipeListBox.Items.Add("Mega Rhino + Flu Medicine = Thick McLovin", false);
                        ItemSellPrice.Text = "$95";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Mega Rhino":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        CheckedRecipeListBox.Items.Add("Fat Cum + Battery = Shiny Splooge", false);
                        CheckedRecipeListBox.Items.Add("Shiny Splooge + Addy = Nightmare Monkey", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Monkey + Donut = Pink Piss", false);
                        CheckedRecipeListBox.Items.Add("Pink Piss + Chili = Mega Cheese", false);
                        CheckedRecipeListBox.Items.Add("Mega Cheese + Energy Drink = Mega Rhino", false);
                        ItemSellPrice.Text = "$108";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Mega Cheese":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        CheckedRecipeListBox.Items.Add("Fat Cum + Battery = Shiny Splooge", false);
                        CheckedRecipeListBox.Items.Add("Shiny Splooge + Addy = Nightmare Monkey", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Monkey + Donut = Pink Piss", false);
                        CheckedRecipeListBox.Items.Add("Pink Piss + Chili = Mega Cheese", false);
                        ItemSellPrice.Text = "$104";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Pink Piss":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        CheckedRecipeListBox.Items.Add("Fat Cum + Battery = Shiny Splooge", false);
                        CheckedRecipeListBox.Items.Add("Shiny Splooge + Addy = Nightmare Monkey", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Monkey + Donut = Pink Piss", false);
                        ItemSellPrice.Text = "$90";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Nightmare Monkey":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        CheckedRecipeListBox.Items.Add("Fat Cum + Battery = Shiny Splooge", false);
                        CheckedRecipeListBox.Items.Add("Shiny Splooge + Addy = Nightmare Monkey", false);
                        ItemSellPrice.Text = "$83";
                        AddictivenessProgressTextBox.Text = "96%";
                        DrugAddictivenessProgressBar.Value = 96;
                        break;
                    case "Shiny Splooge":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        CheckedRecipeListBox.Items.Add("Fat Cum + Battery = Shiny Splooge", false);
                        ItemSellPrice.Text = "$67";
                        AddictivenessProgressTextBox.Text = "59%";
                        DrugAddictivenessProgressBar.Value = 59;
                        break;
                    case "Fat Cum":
                        CheckedRecipeListBox.Items.Add("Green Crack + Mouth Wash = Fat Cum", false);
                        ItemSellPrice.Text = "$53";
                        AddictivenessProgressTextBox.Text = "39%";
                        DrugAddictivenessProgressBar.Value = 39;
                        break;
                    case "Aspen Mint":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Paracetamol = California Puke", false);
                        CheckedRecipeListBox.Items.Add("California Puke + Banana = Wedding Puke", false);
                        CheckedRecipeListBox.Items.Add("Wedding Puke + Addy = Thick Cock", false);
                        CheckedRecipeListBox.Items.Add("Thick Cock + Cuke = Aspen Mint", false);
                        ItemSellPrice.Text = "$90";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Thick Cock":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Paracetamol = California Puke", false);
                        CheckedRecipeListBox.Items.Add("California Puke + Banana = Wedding Puke", false);
                        CheckedRecipeListBox.Items.Add("Wedding Puke + Addy = Thick Cock", false);
                        ItemSellPrice.Text = "$91";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Wedding Puke":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Paracetamol = California Puke", false);
                        CheckedRecipeListBox.Items.Add("California Puke + Banana = Wedding Puke", false);
                        ItemSellPrice.Text = "$76";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "California Puke":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Paracetamol = California Puke", false);
                        ItemSellPrice.Text = "$52";
                        AddictivenessProgressTextBox.Text = "37%";
                        DrugAddictivenessProgressBar.Value = 37;
                        break;
                    case "Aspen Rhino":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Addy = Aspen Rhino", false);
                        ItemSellPrice.Text = "$78";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "California Grool":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        ItemSellPrice.Text = "$62";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Ultra Grool":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        ItemSellPrice.Text = "$54";
                        AddictivenessProgressTextBox.Text = "99%";
                        DrugAddictivenessProgressBar.Value = 99;
                        break;
                    case "Aspen Smegma":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Cuke = Aspen Smegma", false);
                        ItemSellPrice.Text = "$52";
                        AddictivenessProgressTextBox.Text = "39%";
                        DrugAddictivenessProgressBar.Value = 39;
                        break;
                    case "Banana Cheese":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Energy Drink = Banana Cheese", false);
                        ItemSellPrice.Text = "$107";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "California Dick":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Donut = Mega Fuel", false);
                        CheckedRecipeListBox.Items.Add("Mega Fuel + Energy Drink = California Punch", false);
                        CheckedRecipeListBox.Items.Add("California Punch + Battery = Miracle McLovin", false);
                        CheckedRecipeListBox.Items.Add("Miracle McLovin + Cuke = Wedding Rhino", false);
                        CheckedRecipeListBox.Items.Add("Wedding Rhino + Addy = Miracle Crack", false);
                        CheckedRecipeListBox.Items.Add("Miracle Crack + Banana = California Dick", false);
                        ItemSellPrice.Text = "$131";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Miracle Crack":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Donut = Mega Fuel", false);
                        CheckedRecipeListBox.Items.Add("Mega Fuel + Energy Drink = California Punch", false);
                        CheckedRecipeListBox.Items.Add("California Punch + Battery = Miracle McLovin", false);
                        CheckedRecipeListBox.Items.Add("Miracle McLovin + Cuke = Wedding Rhino", false);
                        CheckedRecipeListBox.Items.Add("Wedding Rhino + Addy = Miracle Crack", false);
                        ItemSellPrice.Text = "$109";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Wedding Rhino":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Donut = Mega Fuel", false);
                        CheckedRecipeListBox.Items.Add("Mega Fuel + Energy Drink = California Punch", false);
                        CheckedRecipeListBox.Items.Add("California Punch + Battery = Miracle McLovin", false);
                        CheckedRecipeListBox.Items.Add("Miracle McLovin + Cuke = Wedding Rhino", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Miracle McLovin":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Donut = Mega Fuel", false);
                        CheckedRecipeListBox.Items.Add("Mega Fuel + Energy Drink = California Punch", false);
                        CheckedRecipeListBox.Items.Add("California Punch + Battery = Miracle McLovin", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "California Punch":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Donut = Mega Fuel", false);
                        CheckedRecipeListBox.Items.Add("Mega Fuel + Energy Drink = California Punch", false);
                        ItemSellPrice.Text = "$69";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Mega Fuel":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Donut = Mega Fuel", false);
                        ItemSellPrice.Text = "$70";
                        AddictivenessProgressTextBox.Text = "95%";
                        DrugAddictivenessProgressBar.Value = 95;
                        break;
                    case "Banana Dick":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Donut = Mega Fuel", false);
                        CheckedRecipeListBox.Items.Add("Mega Fuel + Energy Drink = California Punch", false);
                        CheckedRecipeListBox.Items.Add("California Punch + Battery = Miracle McLovin", false);
                        CheckedRecipeListBox.Items.Add("Miracle McLovin + Cuke = Wedding Rhino", false);
                        CheckedRecipeListBox.Items.Add("Wedding Rhino + Addy = Miracle Crack", false);
                        CheckedRecipeListBox.Items.Add("Miracle Crack + Banana = Banana Dick", false);
                        ItemSellPrice.Text = "$131";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Banana Thunderfuck":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Baanana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Mega Bean = Wedding Express", false);
                        CheckedRecipeListBox.Items.Add("Wedding Express + Cuke = Banana Thunderfuck", false);
                        ItemSellPrice.Text = "$116";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Wedding Express":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Baanana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Mega Bean = Wedding Express", false);
                        ItemSellPrice.Text = "$101";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Big Crack":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Mouth Wash = Bio Bud", false);
                        CheckedRecipeListBox.Items.Add("Bio Bud + Iodine = Big Crack", false);
                        ItemSellPrice.Text = "$76";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Bio Bud":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Mouth Wash = Bio Bud", false);
                        ItemSellPrice.Text = "$61";
                        AddictivenessProgressTextBox.Text = "75%";
                        DrugAddictivenessProgressBar.Value = 75;
                        break;
                    case "Strawberry Shart":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        ItemSellPrice.Text = "$50";
                        AddictivenessProgressTextBox.Text = "75%";
                        DrugAddictivenessProgressBar.Value = 75;
                        break;
                    case "Big Express":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Addy = Slimy Haze", false);
                        CheckedRecipeListBox.Items.Add("Slimy Haze + Paracetamol = Big Express", false);
                        ItemSellPrice.Text = "$66";
                        AddictivenessProgressTextBox.Text = "74%";
                        DrugAddictivenessProgressBar.Value = 74;
                        break;
                    case "Slimy Haze":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Addy = Slimy Haze", false);
                        ItemSellPrice.Text = "$57";
                        AddictivenessProgressTextBox.Text = "42%";
                        DrugAddictivenessProgressBar.Value = 42;
                        break;
                    case "Big Fruit":
                        CheckedRecipeListBox.Items.Add("Green Crack + Paracetamol = Dark Bud", false);
                        CheckedRecipeListBox.Items.Add("Dark Bud + Paracetamol = Strawberry Mint", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Mint + Banana = Island Cock", false);
                        CheckedRecipeListBox.Items.Add("Island Cock + Gasoline = Wedding Ass", false);
                        CheckedRecipeListBox.Items.Add("Wedding Ass + Cuke = Big Fruit", false);
                        ItemSellPrice.Text = "$76";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Wedding Ass":
                        CheckedRecipeListBox.Items.Add("Green Crack + Paracetamol = Dark Bud", false);
                        CheckedRecipeListBox.Items.Add("Dark Bud + Paracetamol = Strawberry Mint", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Mint + Banana = Island Cock", false);
                        CheckedRecipeListBox.Items.Add("Island Cock + Gasoline = Wedding Ass", false);
                        ItemSellPrice.Text = "$62";
                        AddictivenessProgressTextBox.Text = "85%";
                        DrugAddictivenessProgressBar.Value = 85;
                        break;
                    case "Island Cock":
                        CheckedRecipeListBox.Items.Add("Green Crack + Paracetamol = Dark Bud", false);
                        CheckedRecipeListBox.Items.Add("Dark Bud + Paracetamol = Strawberry Mint", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Mint + Banana = Island Cock", false);
                        ItemSellPrice.Text = "$61";
                        AddictivenessProgressTextBox.Text = "37%";
                        DrugAddictivenessProgressBar.Value = 37;
                        break;
                    case "Strawberry Mint":
                        CheckedRecipeListBox.Items.Add("Green Crack + Paracetamol = Dark Bud", false);
                        CheckedRecipeListBox.Items.Add("Dark Bud + Paracetamol = Strawberry Mint", false);
                        ItemSellPrice.Text = "$54";
                        AddictivenessProgressTextBox.Text = "37%";
                        DrugAddictivenessProgressBar.Value = 37;
                        break;
                    case "Dark Bud":
                        CheckedRecipeListBox.Items.Add("Green Crack + Paracetamol = Dark Bud", false);
                        ItemSellPrice.Text = "$43";
                        AddictivenessProgressTextBox.Text = "37%";
                        DrugAddictivenessProgressBar.Value = 37;
                        break;
                    case "Bio Mint":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Cuke = Strawberry Cheese", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Cheese + Mouth Wash = Bio Mint", false);
                        ItemSellPrice.Text = "$69";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Strawberry Cheese":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Cuke = Strawberry Cheese", false);
                        ItemSellPrice.Text = "$58";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "California Death":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Banana = Dream Cum", false);
                        CheckedRecipeListBox.Items.Add("Dream Cum + Paracetamol = White Slime", false);
                        CheckedRecipeListBox.Items.Add("White Slime + Donut = Afghan Punch", false);
                        CheckedRecipeListBox.Items.Add("Afghan Punch + Mouth Wash = Tokyo Mint", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Mint + Energy Drink = California Death", false);
                        ItemSellPrice.Text = "$102";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Tokyo Mint":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Banana = Dream Cum", false);
                        CheckedRecipeListBox.Items.Add("Dream Cum + Paracetamol = White Slime", false);
                        CheckedRecipeListBox.Items.Add("White Slime + Donut = Afghan Punch", false);
                        CheckedRecipeListBox.Items.Add("Afghan Punch + Mouth Wash = Tokyo Mint", false);
                        ItemSellPrice.Text = "$96";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "California Gold":
                        CheckedRecipeListBox.Items.Add("Green Crack + Barttery = Stinky Cake", false);
                        CheckedRecipeListBox.Items.Add("Stinky Cake + Addy = Afghan Rhino", false);
                        CheckedRecipeListBox.Items.Add("Afghan Rhino + Motor Oil = Fruity Haze", false);
                        CheckedRecipeListBox.Items.Add("Fruity Haze + Gasoline = Pink Balls", false);
                        CheckedRecipeListBox.Items.Add("Pink Balls + Mega Bean = California Gold", false);
                        ItemSellPrice.Text = "$90";
                        AddictivenessProgressTextBox.Text = "99%";
                        DrugAddictivenessProgressBar.Value = 99;
                        break;
                    case "Pink Balls":
                        CheckedRecipeListBox.Items.Add("Green Crack + Barttery = Stinky Cake", false);
                        CheckedRecipeListBox.Items.Add("Stinky Cake + Addy = Afghan Rhino", false);
                        CheckedRecipeListBox.Items.Add("Afghan Rhino + Motor Oil = Fruity Haze", false);
                        CheckedRecipeListBox.Items.Add("Fruity Haze + Gasoline = Pink Balls", false);
                        ItemSellPrice.Text = "$85";
                        AddictivenessProgressTextBox.Text = "92%";
                        DrugAddictivenessProgressBar.Value = 92;
                        break;
                    case "Fruity Haze":
                        CheckedRecipeListBox.Items.Add("Green Crack + Barttery = Stinky Cake", false);
                        CheckedRecipeListBox.Items.Add("Stinky Cake + Addy = Afghan Rhino", false);
                        CheckedRecipeListBox.Items.Add("Afghan Rhino + Motor Oil = Fruity Haze", false);
                        ItemSellPrice.Text = "$81";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Stinky Cake":
                        CheckedRecipeListBox.Items.Add("Green Crack + Barttery = Stinky Cake", false);
                        ItemSellPrice.Text = "$57";
                        AddictivenessProgressTextBox.Text = "59d%";
                        DrugAddictivenessProgressBar.Value = 59;
                        break;
                    case "Death Cock":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Addy = Slimy Haze", false);
                        CheckedRecipeListBox.Items.Add("Slimy Haze + Paracetamol = Big Express", false);
                        CheckedRecipeListBox.Items.Add("Big Express + Energy Drink = Pink Fuel", false);
                        CheckedRecipeListBox.Items.Add("Pink Fuel + Cuke = Nightmare Crystal", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Crystal + Mouth Wash = Strawberry Durkle", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Durkle + Viagra = Tokyo Piss", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Piss + Iodine = Death Cock", false);
                        ItemSellPrice.Text = "$115";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Tokyo Piss":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Addy = Slimy Haze", false);
                        CheckedRecipeListBox.Items.Add("Slimy Haze + Paracetamol = Big Express", false);
                        CheckedRecipeListBox.Items.Add("Big Express + Energy Drink = Pink Fuel", false);
                        CheckedRecipeListBox.Items.Add("Pink Fuel + Cuke = Nightmare Crystal", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Crystal + Mouth Wash = Strawberry Durkle", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Durkle + Viagra = Tokyo Piss", false);
                        ItemSellPrice.Text = "$100";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Strawberry Durkle":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Addy = Slimy Haze", false);
                        CheckedRecipeListBox.Items.Add("Slimy Haze + Paracetamol = Big Express", false);
                        CheckedRecipeListBox.Items.Add("Big Express + Energy Drink = Pink Fuel", false);
                        CheckedRecipeListBox.Items.Add("Pink Fuel + Cuke = Nightmare Crystal", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Crystal + Mouth Wash = Strawberry Durkle", false);
                        ItemSellPrice.Text = "$87";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Nightmare Crystal":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Addy = Slimy Haze", false);
                        CheckedRecipeListBox.Items.Add("Slimy Haze + Paracetamol = Big Express", false);
                        CheckedRecipeListBox.Items.Add("Big Express + Energy Drink = Pink Fuel", false);
                        CheckedRecipeListBox.Items.Add("Pink Fuel + Cuke = Nightmare Crystal", false);
                        ItemSellPrice.Text = "$76";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Pink Fuel":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Addy = Slimy Haze", false);
                        CheckedRecipeListBox.Items.Add("Slimy Haze + Paracetamol = Big Express", false);
                        CheckedRecipeListBox.Items.Add("Big Express + Energy Drink = Pink Fuel", false);
                        ItemSellPrice.Text = "$77";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Extreme Durkle":
                        CheckedRecipeListBox.Items.Add("Green Crack + Gasoline = Extreme Durkle", false);
                        ItemSellPrice.Text = "$41";
                        AddictivenessProgressTextBox.Text = "28%";
                        DrugAddictivenessProgressBar.Value = 28;
                        break;
                    case "Fat Mint":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Donut = Mega Fuel", false);
                        CheckedRecipeListBox.Items.Add("Mega Fuel + Energy Drink = California Punch", false);
                        CheckedRecipeListBox.Items.Add("California Punch + Banana = Wedding Puke", false);
                        CheckedRecipeListBox.Items.Add("Wedding Puke + Addy = Thick Cock", false);
                        CheckedRecipeListBox.Items.Add("Thick Cock + Cuke = Aspen Mint", false);
                        CheckedRecipeListBox.Items.Add("Aspen Mint + Paracetamol = Fat Mint", false);
                        ItemSellPrice.Text = "$116";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Fat Shart":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Addy = Aspen Rhino", false);
                        CheckedRecipeListBox.Items.Add("Aspen Rhino + Iodine = Fat Shart", false);
                        ItemSellPrice.Text = "$86";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Fruity Ass":
                        CheckedRecipeListBox.Items.Add("Green Crack + Addy = Fruity Ass", false);
                        ItemSellPrice.Text = "$58";
                        AddictivenessProgressTextBox.Text = "76%";
                        DrugAddictivenessProgressBar.Value = 76;
                        break;
                    case "Fruity Balls":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Addy = Aspen Rhino", false);
                        CheckedRecipeListBox.Items.Add("Aspen Rhino + Iodine = Fat Shart", false);
                        CheckedRecipeListBox.Items.Add("Fat Shart + Battery = Shiny Shart", false);
                        CheckedRecipeListBox.Items.Add("Shiny Shart + Energy Drink = Pink Haze", false);
                        CheckedRecipeListBox.Items.Add("Pink Haze + Chili = Fruity Balls", false);
                        ItemSellPrice.Text = "$118";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Pink Haze":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Addy = Aspen Rhino", false);
                        CheckedRecipeListBox.Items.Add("Aspen Rhino + Iodine = Fat Shart", false);
                        CheckedRecipeListBox.Items.Add("Fat Shart + Battery = Shiny Shart", false);
                        CheckedRecipeListBox.Items.Add("Shiny Shart + Energy Drink = Pink Haze", false);
                        ItemSellPrice.Text = "$104";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Shiny Shart":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Addy = Aspen Rhino", false);
                        CheckedRecipeListBox.Items.Add("Aspen Rhino + Iodine = Fat Shart", false);
                        CheckedRecipeListBox.Items.Add("Fat Shart + Battery = Shiny Shart", false);
                        ItemSellPrice.Text = "$100";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Fruity Cum":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Viagra = Wedding Bud", false);
                        CheckedRecipeListBox.Items.Add("Wedding Bud + Flu Medicine = Sweet ThunderFuck", false);
                        CheckedRecipeListBox.Items.Add("Sweet ThunderFuck + Iodine = Shiny Shart", false);
                        CheckedRecipeListBox.Items.Add("Shiny Shart + Energy Drink = Fruity Cum", false);
                        ItemSellPrice.Text = "$101";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sweet ThunderFuck":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Viagra = Wedding Bud", false);
                        CheckedRecipeListBox.Items.Add("Wedding Bud + Flu Medicine = Sweet ThunderFuck", false);
                        ItemSellPrice.Text = "$95";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Wedding Bud":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Viagra = Wedding Bud", false);
                        ItemSellPrice.Text = "$86";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Fruity Rhino":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Cuke = Stawberry Cheese", false);
                        CheckedRecipeListBox.Items.Add("Stawberry Cheese + Mouth Wash = Bio Mint", false);
                        CheckedRecipeListBox.Items.Add("Bio Mint + Iodine = Hairy Balls", false);
                        CheckedRecipeListBox.Items.Add("Hairy Balls + Mega Bean = Sweet Cheese", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cheese + Motor Oil = Pink Fruit", false);
                        CheckedRecipeListBox.Items.Add("Pink Fruit + Gasoline = Sweet Assblaster", false);
                        CheckedRecipeListBox.Items.Add("Sweet Assblaster + Donut = Fruity Rhino", false);
                        ItemSellPrice.Text = "$116";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sweet Assblaster":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Cuke = Stawberry Cheese", false);
                        CheckedRecipeListBox.Items.Add("Stawberry Cheese + Mouth Wash = Bio Mint", false);
                        CheckedRecipeListBox.Items.Add("Bio Mint + Iodine = Hairy Balls", false);
                        CheckedRecipeListBox.Items.Add("Hairy Balls + Mega Bean = Sweet Cheese", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cheese + Motor Oil = Pink Fruit", false);
                        CheckedRecipeListBox.Items.Add("Pink Fruit + Gasoline = Sweet Assblaster", false);
                        ItemSellPrice.Text = "$108";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Pink Fruit":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Cuke = Stawberry Cheese", false);
                        CheckedRecipeListBox.Items.Add("Stawberry Cheese + Mouth Wash = Bio Mint", false);
                        CheckedRecipeListBox.Items.Add("Bio Mint + Iodine = Hairy Balls", false);
                        CheckedRecipeListBox.Items.Add("Hairy Balls + Mega Bean = Sweet Cheese", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cheese + Motor Oil = Pink Fruit", false);
                        ItemSellPrice.Text = "$96";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sweet Cheese":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Cuke = Stawberry Cheese", false);
                        CheckedRecipeListBox.Items.Add("Stawberry Cheese + Mouth Wash = Bio Mint", false);
                        CheckedRecipeListBox.Items.Add("Bio Mint + Iodine = Hairy Balls", false);
                        CheckedRecipeListBox.Items.Add("Hairy Balls + Mega Bean = Sweet Cheese", false);
                        ItemSellPrice.Text = "$82";
                        AddictivenessProgressTextBox.Text = "44%";
                        DrugAddictivenessProgressBar.Value = 44;
                        break;
                    case "Hairy Balls":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Cuke = Stawberry Cheese", false);
                        CheckedRecipeListBox.Items.Add("Stawberry Cheese + Mouth Wash = Bio Mint", false);
                        CheckedRecipeListBox.Items.Add("Bio Mint + Iodine = Hairy Balls", false);
                        ItemSellPrice.Text = "$83";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Stawberry Cheese":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Cuke = Stawberry Cheese", false);
                        ItemSellPrice.Text = "$58";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Girl Scout Crystal":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Gasoline = Afghan Queef", false);
                        CheckedRecipeListBox.Items.Add("Afghan Queef + Mega Bean = Girl Scout Crytal", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Girl Scout Dick":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Viagra = Big Cum", false);
                        CheckedRecipeListBox.Items.Add("Big Cum + Banana = Dream Cum", false);
                        CheckedRecipeListBox.Items.Add("Dream Cum + Paracetamol = White Slime", false);
                        CheckedRecipeListBox.Items.Add("White Slime + Donut = Afghan Punch", false);
                        CheckedRecipeListBox.Items.Add("Afghan Punch + Mouth Wash = Tokyo Mint", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Mint + Energy Drink = California Death", false);
                        CheckedRecipeListBox.Items.Add("California Death + Cuke = Girl Scout Dick", false);
                        ItemSellPrice.Text = "$110";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Gorilla Splooge":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Mouth Wash = Death Urkle", false);
                        CheckedRecipeListBox.Items.Add("Death Urkle + Energy Drink = Tokyo Ass", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Ass + Motor Oil = Gorilla Splooge", false);
                        ItemSellPrice.Text = "$113";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Gorilla Stink":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Mouth Wash = Bio Bud", false);
                        CheckedRecipeListBox.Items.Add("Bio Bud + Mega Bean = Gorilla Stink", false);
                        ItemSellPrice.Text = "$62";
                        AddictivenessProgressTextBox.Text = "34%";
                        DrugAddictivenessProgressBar.Value = 34;
                        break;
                    case "Granddaddy Cookies":
                        CheckedRecipeListBox.Items.Add("OG Kush + Palacetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        CheckedRecipeListBox.Items.Add("Pink Ass + Chili = Mega Cheese", false);
                        CheckedRecipeListBox.Items.Add("Mega Cheese + Energy Drink = Mega Rhino", false);
                        CheckedRecipeListBox.Items.Add("Mega Rhino + Flu Medicine = Thick McLonin", false);
                        CheckedRecipeListBox.Items.Add("Thick McLonin + Cuke = Nightmare Grool", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Grool + Iodine = Aspen Fruit", false);
                        CheckedRecipeListBox.Items.Add("Aspen Fruit + Chili = Slimy Splooge", false);
                        CheckedRecipeListBox.Items.Add("Slimy Splooge + Gasoline = Granddaddy Cookies", false);
                        ItemSellPrice.Text = "$97";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Slimy Splooge":
                        CheckedRecipeListBox.Items.Add("OG Kush + Palacetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        CheckedRecipeListBox.Items.Add("Pink Ass + Chili = Mega Cheese", false);
                        CheckedRecipeListBox.Items.Add("Mega Cheese + Energy Drink = Mega Rhino", false);
                        CheckedRecipeListBox.Items.Add("Mega Rhino + Flu Medicine = Thick McLonin", false);
                        CheckedRecipeListBox.Items.Add("Thick McLonin + Cuke = Nightmare Grool", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Grool + Iodine = Aspen Fruit", false);
                        CheckedRecipeListBox.Items.Add("Aspen Fruit + Chili = Slimy Splooge", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Thick McLonin":
                        CheckedRecipeListBox.Items.Add("OG Kush + Palacetamol = Aspen Death", false);
                        CheckedRecipeListBox.Items.Add("Aspen Death + Cuke = Pink Ass", false);
                        CheckedRecipeListBox.Items.Add("Pink Ass + Chili = Mega Cheese", false);
                        CheckedRecipeListBox.Items.Add("Mega Cheese + Energy Drink = Mega Rhino", false);
                        CheckedRecipeListBox.Items.Add("Mega Rhino + Flu Medicine = Thick McLonin", false);
                        ItemSellPrice.Text = "$95";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Granddaddy Stink":
                        CheckedRecipeListBox.Items.Add("Sour Diesel + Flue Medicine = California Cookies", false);
                        CheckedRecipeListBox.Items.Add("California Cookies + Addy = Super Dick", false);
                        CheckedRecipeListBox.Items.Add("Super Dick + Motor Oil = Mega Diesel", false);
                        CheckedRecipeListBox.Items.Add("Mega Diesel + Viagra = Extreme Balls", false);
                        CheckedRecipeListBox.Items.Add("Extreme Balls + Mouth Wash = Dark Ghost", false);
                        CheckedRecipeListBox.Items.Add("Dark Ghost + Horse Semen = Stinky Rhino", false);
                        CheckedRecipeListBox.Items.Add("Stinky Rhino + Addy = Granddaddy Stink", false);
                        ItemSellPrice.Text = "$146";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Stinky Rhino":
                        CheckedRecipeListBox.Items.Add("Sour Diesel + Flue Medicine = California Cookies", false);
                        CheckedRecipeListBox.Items.Add("California Cookies + Addy = Super Dick", false);
                        CheckedRecipeListBox.Items.Add("Super Dick + Motor Oil = Mega Diesel", false);
                        CheckedRecipeListBox.Items.Add("Mega Diesel + Viagra = Extreme Balls", false);
                        CheckedRecipeListBox.Items.Add("Extreme Balls + Mouth Wash = Dark Ghost", false);
                        CheckedRecipeListBox.Items.Add("Dark Ghost + Horse Semen = Stinky Rhino", false);
                        ItemSellPrice.Text = "$121";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Dark Ghost":
                        CheckedRecipeListBox.Items.Add("Sour Diesel + Flue Medicine = California Cookies", false);
                        CheckedRecipeListBox.Items.Add("California Cookies + Addy = Super Dick", false);
                        CheckedRecipeListBox.Items.Add("Super Dick + Motor Oil = Mega Diesel", false);
                        CheckedRecipeListBox.Items.Add("Mega Diesel + Viagra = Extreme Balls", false);
                        CheckedRecipeListBox.Items.Add("Extreme Balls + Mouth Wash = Dark Ghost", false);
                        ItemSellPrice.Text = "$101";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Extreme Balls":
                        CheckedRecipeListBox.Items.Add("Sour Diesel + Flue Medicine = California Cookies", false);
                        CheckedRecipeListBox.Items.Add("California Cookies + Addy = Super Dick", false);
                        CheckedRecipeListBox.Items.Add("Super Dick + Motor Oil = Mega Diesel", false);
                        CheckedRecipeListBox.Items.Add("Mega Diesel + Viagra = Extreme Balls", false);
                        ItemSellPrice.Text = "$90";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Mega Diesel":
                        CheckedRecipeListBox.Items.Add("Sour Diesel + Flue Medicine = California Cookies", false);
                        CheckedRecipeListBox.Items.Add("California Cookies + Addy = Super Dick", false);
                        CheckedRecipeListBox.Items.Add("Super Dick + Motor Oil = Mega Diesel", false);
                        ItemSellPrice.Text = "$74";
                        AddictivenessProgressTextBox.Text = "83%";
                        DrugAddictivenessProgressBar.Value = 83;
                        break;
                    case "Super Dick":
                        CheckedRecipeListBox.Items.Add("Sour Diesel + Flue Medicine = California Cookies", false);
                        CheckedRecipeListBox.Items.Add("California Cookies + Addy = Super Dick", false);
                        ItemSellPrice.Text = "$62";
                        AddictivenessProgressTextBox.Text = "52%";
                        DrugAddictivenessProgressBar.Value = 52;
                        break;
                    case "California Cookies":
                        CheckedRecipeListBox.Items.Add("Sour Diesel + Flue Medicine = California Cookies", false);
                        ItemSellPrice.Text = "$49";
                        AddictivenessProgressTextBox.Text = "15%";
                        DrugAddictivenessProgressBar.Value = 15;
                        break;
                    case "Hairy Gold":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Mouth Wash = Bio Bud", false);
                        CheckedRecipeListBox.Items.Add("Bio Bud + Mega Bean = Gorilla Stink", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Stink + Addy = Pink Rhino", false);
                        CheckedRecipeListBox.Items.Add("Pink Rhino + Hairy Gold = Dark Ghost", false);
                        ItemSellPrice.Text = "$91";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Pink Rhino":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Mouth Wash = Bio Bud", false);
                        CheckedRecipeListBox.Items.Add("Bio Bud + Mega Bean = Gorilla Stink", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Stink + Addy = Pink Rhino", false);
                        ItemSellPrice.Text = "$64";
                        AddictivenessProgressTextBox.Text = "58%";
                        DrugAddictivenessProgressBar.Value = 58;
                        break;
                    case "Hairy Mint":
                        CheckedRecipeListBox.Items.Add("Green Crack + Donut = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Paracetamol = Mega Monkey", false);
                        CheckedRecipeListBox.Items.Add("Mega Monkey + Donut = Hairy Mint", false);
                        ItemSellPrice.Text = "$69";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Mega Monkey":
                        CheckedRecipeListBox.Items.Add("Green Crack + Donut = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Paracetamol = Mega Monkey", false);
                        ItemSellPrice.Text = "$60";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Hairy Shart":
                        CheckedRecipeListBox.Items.Add("Green Crack + Addy = Fruity Ass", false);
                        CheckedRecipeListBox.Items.Add("Fruity Ass + Iodine = Miracle Shart", false);
                        CheckedRecipeListBox.Items.Add("Miracle Shart + Battery = Sweet Fruit", false);
                        CheckedRecipeListBox.Items.Add("Sweet Fruit + Mega Bean = Thick Piss", false);
                        CheckedRecipeListBox.Items.Add("Thick Piss + Gasoilne = Ice Cream Durkle", false);
                        CheckedRecipeListBox.Items.Add("Ice Cream Durkle + Battery = Slimy Balls", false);
                        CheckedRecipeListBox.Items.Add("Slimy Balls + Addy = Hairy Shart", false);
                        ItemSellPrice.Text = "$101";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Slimy Balls":
                        CheckedRecipeListBox.Items.Add("Green Crack + Addy = Fruity Ass", false);
                        CheckedRecipeListBox.Items.Add("Fruity Ass + Iodine = Miracle Shart", false);
                        CheckedRecipeListBox.Items.Add("Miracle Shart + Battery = Sweet Fruit", false);
                        CheckedRecipeListBox.Items.Add("Sweet Fruit + Mega Bean = Thick Piss", false);
                        CheckedRecipeListBox.Items.Add("Thick Piss + Gasoilne = Ice Cream Durkle", false);
                        CheckedRecipeListBox.Items.Add("Ice Cream Durkle + Battery = Slimy Balls", false);
                        ItemSellPrice.Text = "$102";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Ice Cream Durkle":
                        CheckedRecipeListBox.Items.Add("Green Crack + Addy = Fruity Ass", false);
                        CheckedRecipeListBox.Items.Add("Fruity Ass + Iodine = Miracle Shart", false);
                        CheckedRecipeListBox.Items.Add("Miracle Shart + Battery = Sweet Fruit", false);
                        CheckedRecipeListBox.Items.Add("Sweet Fruit + Mega Bean = Thick Piss", false);
                        CheckedRecipeListBox.Items.Add("Thick Piss + Gasoilne = Ice Cream Durkle", false);
                        ItemSellPrice.Text = "$91";
                        AddictivenessProgressTextBox.Text = "68%";
                        DrugAddictivenessProgressBar.Value = 68;
                        break;
                    case "Thick Piss":
                        CheckedRecipeListBox.Items.Add("Green Crack + Addy = Fruity Ass", false);
                        CheckedRecipeListBox.Items.Add("Fruity Ass + Iodine = Miracle Shart", false);
                        CheckedRecipeListBox.Items.Add("Miracle Shart + Battery = Sweet Fruit", false);
                        CheckedRecipeListBox.Items.Add("Sweet Fruit + Mega Bean = Thick Piss", false);
                        ItemSellPrice.Text = "$89";
                        AddictivenessProgressTextBox.Text = "79%";
                        DrugAddictivenessProgressBar.Value = 79;
                        break;
                    case "Sweet Fruit":
                        CheckedRecipeListBox.Items.Add("Green Crack + Addy = Fruity Ass", false);
                        CheckedRecipeListBox.Items.Add("Fruity Ass + Iodine = Miracle Shart", false);
                        CheckedRecipeListBox.Items.Add("Miracle Shart + Battery = Sweet Fruit", false);
                        ItemSellPrice.Text = "$87";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Miracle Shart":
                        CheckedRecipeListBox.Items.Add("Green Crack + Addy = Fruity Ass", false);
                        CheckedRecipeListBox.Items.Add("Fruity Ass + Iodine = Miracle Shart", false);
                        ItemSellPrice.Text = "$73";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "LA Crack":
                        CheckedRecipeListBox.Items.Add("Granddad Purple + Cuke = Aspen Smegma", false);
                        CheckedRecipeListBox.Items.Add("Aspen Smegma + Donut = Sweet Shart", false);
                        CheckedRecipeListBox.Items.Add("Sweet Shart + Mouth Wash = Strwberry Piss", false);
                        CheckedRecipeListBox.Items.Add("Strwberry Piss + Energine Drink = Super Slime", false);
                        CheckedRecipeListBox.Items.Add("Super Slime + Flu Medicine = La Crack", false);
                        ItemSellPrice.Text = "$87";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Super Slime":
                        CheckedRecipeListBox.Items.Add("Granddad Purple + Cuke = Aspen Smegma", false);
                        CheckedRecipeListBox.Items.Add("Aspen Smegma + Donut = Sweet Shart", false);
                        CheckedRecipeListBox.Items.Add("Sweet Shart + Mouth Wash = Strwberry Piss", false);
                        CheckedRecipeListBox.Items.Add("Strwberry Piss + Energine Drink = Super Slime", false);
                        ItemSellPrice.Text = "$77";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Strawberry Piss":
                        CheckedRecipeListBox.Items.Add("Granddad Purple + Cuke = Aspen Smegma", false);
                        CheckedRecipeListBox.Items.Add("Aspen Smegma + Donut = Sweet Shart", false);
                        CheckedRecipeListBox.Items.Add("Sweet Shart + Mouth Wash = Strawberry Piss", false);
                        ItemSellPrice.Text = "$71";
                        AddictivenessProgressTextBox.Text = "71%";
                        DrugAddictivenessProgressBar.Value = 71;
                        break;
                    case "Sweet Shart":
                        CheckedRecipeListBox.Items.Add("Granddad Purple + Cuke = Aspen Smegma", false);
                        CheckedRecipeListBox.Items.Add("Aspen Smegma + Donut = Sweet Shart", false);
                        ItemSellPrice.Text = "$62";
                        AddictivenessProgressTextBox.Text = "49%";
                        DrugAddictivenessProgressBar.Value = 49;
                        break;
                    case "Mega Bud":
                        CheckedRecipeListBox.Items.Add("Granddad Purple + Energine Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Mouth Wash = Bio Bud", false);
                        CheckedRecipeListBox.Items.Add("Bio Bud + Mega Bean = Gorilla Stink", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Stink + Iodine = Pink Rhino", false);
                        CheckedRecipeListBox.Items.Add("Pink Rhino + Motor Oil = Hairy Gold", false);
                        CheckedRecipeListBox.Items.Add("Hairy Gold + Gasoilne = White Smegma", false);
                        CheckedRecipeListBox.Items.Add("White Smegma + Donut = Mega Bud", false);
                        ItemSellPrice.Text = "$107";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "White Smegma":
                        CheckedRecipeListBox.Items.Add("Granddad Purple + Energine Drink = Strawberry Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Shart + Mouth Wash = Bio Bud", false);
                        CheckedRecipeListBox.Items.Add("Bio Bud + Mega Bean = Gorilla Stink", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Stink + Iodine = Pink Rhino", false);
                        CheckedRecipeListBox.Items.Add("Pink Rhino + Motor Oil = Hairy Gold", false);
                        CheckedRecipeListBox.Items.Add("Hairy Gold + Gasoilne = White Smegma", false);
                        ItemSellPrice.Text = "$97";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Mega Punch":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Bannana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Bannana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Gasoline = Afghan Queef", false);
                        CheckedRecipeListBox.Items.Add("Afghan Queef + Mega Bean = Girl Scout Crystal", false);
                        CheckedRecipeListBox.Items.Add("Girl Scout Crystal + Mouth Wash = Mega Punch", false);
                        ItemSellPrice.Text = "$108";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Nightmare Balls":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Bannana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Bannana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Gasoline = Afghan Queef", false);
                        CheckedRecipeListBox.Items.Add("Afghan Queef + Mega Bean = Girl Scout Crystal", false);
                        CheckedRecipeListBox.Items.Add("Girl Scout Crystal + Mouth Wash = Mega Punch", false);
                        CheckedRecipeListBox.Items.Add("Mega Punch + Energine Drink = Nightmare Balls", false);
                        ItemSellPrice.Text = "$90";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "OG Rhino":
                        CheckedRecipeListBox.Items.Add("Green Crack + Paracetamol = Dark Bud", false);
                        CheckedRecipeListBox.Items.Add("Dark Bud + Paracetamol = Strawberry Mint", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Mint + Banana = Island Cock", false);
                        CheckedRecipeListBox.Items.Add("Island Cock + Gasoline = Wedding Ass", false);
                        CheckedRecipeListBox.Items.Add("Wedding Ass + Cuke = Big Fruit", false);
                        CheckedRecipeListBox.Items.Add("Big Fruit + Viagra = OG Rhino", false);
                        ItemSellPrice.Text = "$83";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "OG Splooge":
                        CheckedRecipeListBox.Items.Add("Green Crack + Paracetamol = Dark Bud", false);
                        CheckedRecipeListBox.Items.Add("Dark Bud + Paracetamol = Strawberry Mint", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Mint + Banana = Island Cock", false);
                        CheckedRecipeListBox.Items.Add("Island Cock + Gasoline = Wedding Ass", false);
                        CheckedRecipeListBox.Items.Add("Wedding Ass + Cuke = Big Fruit", false);
                        CheckedRecipeListBox.Items.Add("Big Fruit + Viagra = OG Rhino", false);
                        CheckedRecipeListBox.Items.Add("OG Rhino + Viagra = OG Splooge", false);
                        ItemSellPrice.Text = "$117";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Purple Punch":
                        CheckedRecipeListBox.Items.Add("OG Kush + Addy = Wedding Crack", false);
                        CheckedRecipeListBox.Items.Add("Wedding Crack + Motor Oil = Dark Slime", false);
                        CheckedRecipeListBox.Items.Add("Dark Slime + Viagra = La Fruit", false);
                        CheckedRecipeListBox.Items.Add("La Fruit + Mouth Wash = Dark Balls", false);
                        CheckedRecipeListBox.Items.Add("Dark Balls + Donut = White Punch", false);
                        CheckedRecipeListBox.Items.Add("White Punch + Horse Semen = Pink Puke", false);
                        CheckedRecipeListBox.Items.Add("Pink Puke + Addy = Island Diamond", false);
                        CheckedRecipeListBox.Items.Add("Island Diamond + Chili = Purple Punch", false);
                        ItemSellPrice.Text = "$145";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Pink Puke":
                        CheckedRecipeListBox.Items.Add("OG Kush + Addy = Wedding Crack", false);
                        CheckedRecipeListBox.Items.Add("Wedding Crack + Motor Oil = Dark Slime", false);
                        CheckedRecipeListBox.Items.Add("Dark Slime + Viagra = La Fruit", false);
                        CheckedRecipeListBox.Items.Add("La Fruit + Mouth Wash = Dark Balls", false);
                        CheckedRecipeListBox.Items.Add("Dark Balls + Donut = White Punch", false);
                        CheckedRecipeListBox.Items.Add("White Punch + Horse Semen = Pink Puke", false);
                        ItemSellPrice.Text = "$120";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "White Punch":
                        CheckedRecipeListBox.Items.Add("OG Kush + Addy = Wedding Crack", false);
                        CheckedRecipeListBox.Items.Add("Wedding Crack + Motor Oil = Dark Slime", false);
                        CheckedRecipeListBox.Items.Add("Dark Slime + Viagra = La Fruit", false);
                        CheckedRecipeListBox.Items.Add("La Fruit + Mouth Wash = Dark Balls", false);
                        CheckedRecipeListBox.Items.Add("Dark Balls + Donut = White Punch", false);
                        ItemSellPrice.Text = "$116";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Wedding Crack":
                        CheckedRecipeListBox.Items.Add("OG Kush + Addy = Wedding Crack", false);
                        ItemSellPrice.Text = "$54";
                        AddictivenessProgressTextBox.Text = "42%";
                        DrugAddictivenessProgressBar.Value = 42;
                        break;
                    case "Stinky Puke":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Mouth Wash = Death Urkle", false);
                        CheckedRecipeListBox.Items.Add("Death Urkle + Energy Drink = Tokyo Ass", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Ass + Mega Bean = Stinky Puke", false);
                        ItemSellPrice.Text = "$94";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Strawberry Thunderfuck":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Banana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Banana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Mouth Wash = Death Urkle", false);
                        CheckedRecipeListBox.Items.Add("Death Urkle + Energy Drink = Tokyo Ass", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Ass + Cuke = Strawberry Thunderfuck", false);
                        ItemSellPrice.Text = "$109";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sweet Haze":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Cuke = Aspen Smegma", false);
                        CheckedRecipeListBox.Items.Add("Aspen Smegma + Donut = Sweet Shart", false);
                        CheckedRecipeListBox.Items.Add("Sweet Shart + Mouth Wash = Strawberry Piss", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Piss + Energy Drink = Super Slime", false);
                        CheckedRecipeListBox.Items.Add("Super Slime + Flu Medicine = LA Crack", false);
                        CheckedRecipeListBox.Items.Add("LA Crack + Banana = Sweet Haze", false);
                        ItemSellPrice.Text = "$102";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sweet Thunderfuck":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Viagra = Wedding Bud", false);
                        CheckedRecipeListBox.Items.Add("Wedding Bud + Flu Medicine = Sweet Thunderfuck", false);
                        ItemSellPrice.Text = "$95";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Thick Stink":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Donut = Thick Stink", false);
                        ItemSellPrice.Text = "$54";
                        AddictivenessProgressTextBox.Text = "15%";
                        DrugAddictivenessProgressBar.Value = 15;
                        break;
                    case "Thick Balls":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Viagra = Wedding Bud", false);
                        CheckedRecipeListBox.Items.Add("Wedding Bud + Flu Medicine = Sweet Thunderfuck", false);
                        CheckedRecipeListBox.Items.Add("Sweet Thunderfuck + Iodine = Thick Balls", false);
                        ItemSellPrice.Text = "$110";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Thick Dick":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Paracetamol = Mega Monkey", false);
                        CheckedRecipeListBox.Items.Add("Mega Monkey + Donut = Hairy Mint", false);
                        CheckedRecipeListBox.Items.Add("Hairy Mint + Banana = Thick Dick", false);
                        ItemSellPrice.Text = "$91";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Tokyo Balls":
                        CheckedRecipeListBox.Items.Add("Green Crack + Energy Drink = Ultra Grool", false);
                        CheckedRecipeListBox.Items.Add("Ultra Grool + Chili = California Grool", false);
                        CheckedRecipeListBox.Items.Add("California Grool + Addy = Aspen Rhino", false);
                        CheckedRecipeListBox.Items.Add("Aspen Rhino + Iodine = Fat Shart", false);
                        CheckedRecipeListBox.Items.Add("Fat Shart + Battery = Shiny Shart", false);
                        CheckedRecipeListBox.Items.Add("Shiny Shart + Energy Drink = Pink Haze", false);
                        CheckedRecipeListBox.Items.Add("Pink Haze + Chili = Fruity Balls", false);
                        CheckedRecipeListBox.Items.Add("Fruity Balls + Mega Bean = Tokyo Balls", false);
                        ItemSellPrice.Text = "$102";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Ultra Cake":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Banana = Ultra Cake", false);
                        ItemSellPrice.Text = "$51";
                        AddictivenessProgressTextBox.Text = "5%";
                        DrugAddictivenessProgressBar.Value = 5;
                        break;
                    case "Ultra Cookies":
                        CheckedRecipeListBox.Items.Add("Green Crack + Donut = Ultra Cookies", false);
                        ItemSellPrice.Text = "$52";
                        AddictivenessProgressTextBox.Text = "49%";
                        DrugAddictivenessProgressBar.Value = 49;
                        break;
                    case "Ultra Puke":
                        CheckedRecipeListBox.Items.Add("Green Crack + Addy = Fruity Ass", false);
                        CheckedRecipeListBox.Items.Add("Fruity Ass + Iodine = Miracle Shart", false);
                        CheckedRecipeListBox.Items.Add("Miracle Shart + Battery = Sweet Fruit", false);
                        CheckedRecipeListBox.Items.Add("Sweet Fruit + Mega Bean = Thick Piss", false);
                        CheckedRecipeListBox.Items.Add("Thick Piss + Gasoline = Ice Cream Durkle", false);
                        CheckedRecipeListBox.Items.Add("Ice Cream Durkle + Battery = Slimy Balls", false);
                        CheckedRecipeListBox.Items.Add("Slimy Balls + Addy = Hairy Shart", false);
                        CheckedRecipeListBox.Items.Add("Hairy Shart + Gasoline = Ultra Puke", false);
                        ItemSellPrice.Text = "$99";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Wedding Thunderfuck":
                        CheckedRecipeListBox.Items.Add("Granddaddy Purple + Energy Drink = Strawbery Shart", false);
                        CheckedRecipeListBox.Items.Add("Strawbery Shart + Flu Medicine = LA Crack", false);
                        CheckedRecipeListBox.Items.Add("LA Crack + Banana = Sweet Haze", false);
                        CheckedRecipeListBox.Items.Add("Sweet Haze + Viagra = Wedding Thunderfuck", false);
                        ItemSellPrice.Text = "$118";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "White Stink":
                        CheckedRecipeListBox.Items.Add("Green Crack + Viagra = California Smegma", false);
                        CheckedRecipeListBox.Items.Add("California Smegma + Banana = California Rhino", false);
                        CheckedRecipeListBox.Items.Add("California Rhino + Paracetamol = Island Rhino", false);
                        CheckedRecipeListBox.Items.Add("Island Rhino + Donut = Bannana Diamond", false);
                        CheckedRecipeListBox.Items.Add("Bannana Diamond + Flu Medicine = Sweet Cum", false);
                        CheckedRecipeListBox.Items.Add("Sweet Cum + Mouth Wash = Death Urkle", false);
                        CheckedRecipeListBox.Items.Add("Death Urkle + Energy Drink = Tokyo Ass", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Ass + Chili = White Stink", false);
                        ItemSellPrice.Text = "$114";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                }
            }
        }
    }
}
