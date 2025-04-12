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
                    case "Afghan Cum":
                        CheckedRecipeListBox.Items.Add("Meth + Cuke = Aspen Cake", false);
                        CheckedRecipeListBox.Items.Add("Aspen Cake + Mouth Wash = Gorilla Assblaster", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Assblaster + Donut = Stinky Queef", false);
                        CheckedRecipeListBox.Items.Add("Stinky Queef + Donut = Sweet Sliime", false);
                        CheckedRecipeListBox.Items.Add("Sweet Sliime + Mouth Wash = Stawberry Cum", false);
                        CheckedRecipeListBox.Items.Add("Stawberry Cum + Addy = Afghan Cum", false);
                        ItemSellPrice.Text = "$188";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Stawberry Cum":
                        CheckedRecipeListBox.Items.Add("Meth + Cuke = Aspen Cake", false);
                        CheckedRecipeListBox.Items.Add("Aspen Cake + Mouth Wash = Gorilla Assblaster", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Assblaster + Donut = Stinky Queef", false);
                        CheckedRecipeListBox.Items.Add("Stinky Queef + Donut = Sweet Sliime", false);
                        CheckedRecipeListBox.Items.Add("Sweet Sliime + Mouth Wash = Stawberry Cum", false);
                        ItemSellPrice.Text = "$161";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sweet Sliime":
                        CheckedRecipeListBox.Items.Add("Meth + Cuke = Aspen Cake", false);
                        CheckedRecipeListBox.Items.Add("Aspen Cake + Mouth Wash = Gorilla Assblaster", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Assblaster + Donut = Stinky Queef", false);
                        CheckedRecipeListBox.Items.Add("Stinky Queef + Donut = Sweet Sliime", false);
                        ItemSellPrice.Text = "$122";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Stinky Queef":
                        CheckedRecipeListBox.Items.Add("Meth + Cuke = Aspen Cake", false);
                        CheckedRecipeListBox.Items.Add("Aspen Cake + Mouth Wash = Gorilla Assblaster", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Assblaster + Donut = Stinky Queef", false);
                        ItemSellPrice.Text = "$122";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Gorilla Assblaster":
                        CheckedRecipeListBox.Items.Add("Meth + Cuke = Aspen Cake", false);
                        CheckedRecipeListBox.Items.Add("Aspen Cake + Mouth Wash = Gorilla Assblaster", false);
                        ItemSellPrice.Text = "$106";
                        AddictivenessProgressTextBox.Text = "94%";
                        DrugAddictivenessProgressBar.Value = 94;
                        break;
                    case "Aspen Cake":
                        CheckedRecipeListBox.Items.Add("Meth + Cuke = Aspen Cake", false);
                        ItemSellPrice.Text = "$85";
                        AddictivenessProgressTextBox.Text = "94%";
                        DrugAddictivenessProgressBar.Value = 94;
                        break;
                    case "Afghtan Fruit":
                        CheckedRecipeListBox.Items.Add("Meth + Mouth Wash = Fat Ass", false);
                        CheckedRecipeListBox.Items.Add("Fat Ass + Mouth Wash = Ice Cream Death", false);
                        CheckedRecipeListBox.Items.Add("Ice Cream Death + Gasoline = Tokyo McLovin", false);
                        CheckedRecipeListBox.Items.Add("Tokyo McLovin + Paracetamol = Afghtan Fruit", false);
                        ItemSellPrice.Text = "$162";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Tokyo McLovin":
                        CheckedRecipeListBox.Items.Add("Meth + Mouth Wash = Fat Ass", false);
                        CheckedRecipeListBox.Items.Add("Fat Ass + Mouth Wash = Ice Cream Death", false);
                        CheckedRecipeListBox.Items.Add("Ice Cream Death + Gasoline = Tokyo McLovin", false);
                        ItemSellPrice.Text = "$113";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Ice Cream Death":
                        CheckedRecipeListBox.Items.Add("Meth + Mouth Wash = Fat Ass", false);
                        CheckedRecipeListBox.Items.Add("Fat Ass + Mouth Wash = Ice Cream Death", false);
                        ItemSellPrice.Text = "$113";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Fat Ass":
                        CheckedRecipeListBox.Items.Add("Meth + Mouth Wash = Fat Ass", false);
                        ItemSellPrice.Text = "$91";
                        AddictivenessProgressTextBox.Text = "60%";
                        DrugAddictivenessProgressBar.Value = 60;
                        break;
                    case "Aspen Fuel":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        CheckedRecipeListBox.Items.Add("Sweet Smegma + Mouth Wash = Tokyo Express", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Express + Horse Semen = Nightmare Puke", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Puke + Energy Drink = Sexy Puke", false);
                        CheckedRecipeListBox.Items.Add("Sexy Puke + Addy = Aspen Fuel", false);
                        ItemSellPrice.Text = "$196";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sexy Puke":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        CheckedRecipeListBox.Items.Add("Sweet Smegma + Mouth Wash = Tokyo Express", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Express + Horse Semen = Nightmare Puke", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Puke + Energy Drink = Sexy Puke", false);
                        ItemSellPrice.Text = "$167";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Nightmare Puke":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        CheckedRecipeListBox.Items.Add("Sweet Smegma + Mouth Wash = Tokyo Express", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Express + Horse Semen = Nightmare Puke", false);
                        ItemSellPrice.Text = "$160";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Tokyo Express":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        CheckedRecipeListBox.Items.Add("Sweet Smegma + Mouth Wash = Tokyo Express", false);
                        ItemSellPrice.Text = "$123";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sweet Smegma":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        ItemSellPrice.Text = "$102";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "ASpen Stink":
                        CheckedRecipeListBox.Items.Add("Meth + Motor Oil = Big Balls", false);
                        CheckedRecipeListBox.Items.Add("Big Balls + Cuke = Shiny Mint", false);
                        CheckedRecipeListBox.Items.Add("Shiny Mint + Paracetamol = ASpen Stink", false);
                        ItemSellPrice.Text = "$125";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Banana Cookies":
                        CheckedRecipeListBox.Items.Add("Meth + Addy = Gorilla Bud", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Bud + Viagra = Sexy Death", false);
                        CheckedRecipeListBox.Items.Add("Sexy Death + Iodine = Banana Cookies", false);
                        ItemSellPrice.Text = "$162";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sexy Death":
                        CheckedRecipeListBox.Items.Add("Meth + Addy = Gorilla Bud", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Bud + Viagra = Sexy Death", false);
                        ItemSellPrice.Text = "$133";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Gorilla Bud":
                        CheckedRecipeListBox.Items.Add("Meth + Addy = Gorilla Bud", false);
                        ItemSellPrice.Text = "$101";
                        AddictivenessProgressTextBox.Text = "97%";
                        DrugAddictivenessProgressBar.Value = 97;
                        break;
                    case "Banana McLovin":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        CheckedRecipeListBox.Items.Add("Sweet Smegma + Mouth Wash = Tokyo Express", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Express + Horse Semen = Nightmare Puke", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Puke + Energy Drink = Sexy Puke", false);
                        CheckedRecipeListBox.Items.Add("Sexy Puke + Addy = Aspen Fuel", false);
                        CheckedRecipeListBox.Items.Add("Aspen Fuel + Gasoline = Strawberry Fuel", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Fuel + Cuke = LA Balls", false);
                        CheckedRecipeListBox.Items.Add("LA Balls + Battery = Banana McLovin", false);
                        ItemSellPrice.Text = "$231";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Banana Urkle":
                        CheckedRecipeListBox.Items.Add("Meth + Paracetamol = Ultra Queff", false);
                        CheckedRecipeListBox.Items.Add("Ultra Queff + Cuke = Banana Urkle", false);
                        ItemSellPrice.Text = "$85";
                        AddictivenessProgressTextBox.Text = "94%";
                        DrugAddictivenessProgressBar.Value = 94;
                        break;
                    case "Big Shart":
                        CheckedRecipeListBox.Items.Add("Meth + Paracetamol = Ultra Queff", false);
                        CheckedRecipeListBox.Items.Add("Ultra Queff + Cuke = Banana Urkle", false);
                        ItemSellPrice.Text = "$85";
                        AddictivenessProgressTextBox.Text = "94%";
                        DrugAddictivenessProgressBar.Value = 94;
                        break;
                    case "Slimy Bud":
                        CheckedRecipeListBox.Items.Add("Meth + Horse Semen = Death Thunderfuck", false);
                        CheckedRecipeListBox.Items.Add("Death Thunderfuck + Paracetamol = Sliny Fuel", false);
                        CheckedRecipeListBox.Items.Add("Sliny Fuel + Gasoline = Fat Durkle", false);
                        CheckedRecipeListBox.Items.Add("Fat Durkle + Cuke = Slimy Bud", false);
                        ItemSellPrice.Text = "$167";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Fat Durkle":
                        CheckedRecipeListBox.Items.Add("Meth + Horse Semen = Death Thunderfuck", false);
                        CheckedRecipeListBox.Items.Add("Death Thunderfuck + Paracetamol = Sliny Fuel", false);
                        CheckedRecipeListBox.Items.Add("Sliny Fuel + Gasoline = Fat Durkle", false);
                        ItemSellPrice.Text = "$139";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Sliny Fuel":
                        CheckedRecipeListBox.Items.Add("Meth + Horse Semen = Death Thunderfuck", false);
                        CheckedRecipeListBox.Items.Add("Death Thunderfuck + Paracetamol = Sliny Fuel", false);
                        ItemSellPrice.Text = "$123";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Death Thunderfuck":
                        CheckedRecipeListBox.Items.Add("Meth + Horse Semen = Death Thunderfuck", false);
                        ItemSellPrice.Text = "$106";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Bio Fuel":
                        CheckedRecipeListBox.Items.Add("Meth + Mega Bean = Slimy Urkle", false);
                        CheckedRecipeListBox.Items.Add("Slimy Urkle + Battery = Gorilla McLovin", false);
                        CheckedRecipeListBox.Items.Add("Gorilla McLovin + Paracetamol = Weddding Ghost", false);
                        CheckedRecipeListBox.Items.Add("Weddding Ghost + Cuke = Bio Fuel", false);
                        ItemSellPrice.Text = "$120";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Weddding Ghost":
                        CheckedRecipeListBox.Items.Add("Meth + Mega Bean = Slimy Urkle", false);
                        CheckedRecipeListBox.Items.Add("Slimy Urkle + Battery = Gorilla McLovin", false);
                        CheckedRecipeListBox.Items.Add("Gorilla McLovin + Paracetamol = Weddding Ghost", false);
                        ItemSellPrice.Text = "$122";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Gorilla McLovin":
                        CheckedRecipeListBox.Items.Add("Meth + Mega Bean = Slimy Urkle", false);
                        CheckedRecipeListBox.Items.Add("Slimy Urkle + Battery = Gorilla McLovin", false);
                        ItemSellPrice.Text = "$123";
                        AddictivenessProgressTextBox.Text = "90%";
                        DrugAddictivenessProgressBar.Value = 90;
                        break;
                    case "Slimy Urkle":
                        CheckedRecipeListBox.Items.Add("Meth + Mega Bean = Slimy Urkle", false);
                        ItemSellPrice.Text = "$95";
                        AddictivenessProgressTextBox.Text = "70%";
                        DrugAddictivenessProgressBar.Value = 70;
                        break;
                    case "California Monkey":
                        CheckedRecipeListBox.Items.Add("Meth + Banana = Strawy Crack", false);
                        CheckedRecipeListBox.Items.Add("Strawy Crack + Mouth Wash = Dark Urkle", false);
                        CheckedRecipeListBox.Items.Add("Dark Urkle + Addy = Tokyo Fruit", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Fruit + Donut = Gorilla Cake", false);
                        CheckedRecipeListBox.Items.Add("Gorilla Cake + Chili = California Monkey", false);
                        ItemSellPrice.Text = "$189";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Gorilla Cake":
                        CheckedRecipeListBox.Items.Add("Meth + Banana = Strawy Crack", false);
                        CheckedRecipeListBox.Items.Add("Strawy Crack + Mouth Wash = Dark Urkle", false);
                        CheckedRecipeListBox.Items.Add("Dark Urkle + Addy = Tokyo Fruit", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Fruit + Donut = Gorilla Cake", false);
                        ItemSellPrice.Text = "$151";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Tokyo Fruit":
                        CheckedRecipeListBox.Items.Add("Meth + Banana = Strawy Crack", false);
                        CheckedRecipeListBox.Items.Add("Strawy Crack + Mouth Wash = Dark Urkle", false);
                        CheckedRecipeListBox.Items.Add("Dark Urkle + Addy = Tokyo Fruit", false);
                        ItemSellPrice.Text = "$136";
                        AddictivenessProgressTextBox.Text = "97%";
                        DrugAddictivenessProgressBar.Value = 97;
                        break;
                    case "Dark Urkle":
                        CheckedRecipeListBox.Items.Add("Meth + Banana = Strawy Crack", false);
                        CheckedRecipeListBox.Items.Add("Strawy Crack + Mouth Wash = Dark Urkle", false);
                        ItemSellPrice.Text = "$105";
                        AddictivenessProgressTextBox.Text = "60%";
                        DrugAddictivenessProgressBar.Value = 60;
                        break;
                    case "Strawy Crack":
                        CheckedRecipeListBox.Items.Add("Meth + Banana = Strawy Crack", false);
                        ItemSellPrice.Text = "$84";
                        AddictivenessProgressTextBox.Text = "60%";
                        DrugAddictivenessProgressBar.Value = 60;
                        break;
                    case "California Urkle":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        CheckedRecipeListBox.Items.Add("Sweet Smegma + Mouth Wash = Tokyo Express", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Express + Horse Semen = Nightmare Puke", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Puke + Energy Drink = Sexy Puke", false);
                        CheckedRecipeListBox.Items.Add("Sexy Puke + Addy = Aspen Fuel", false);
                        CheckedRecipeListBox.Items.Add("Aspen Fuel + Donut = White Durkle", false);
                        CheckedRecipeListBox.Items.Add("White Durkle + Chili = Tokyo Monkey", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Monkey + Banana = California Urkle", false);
                        ItemSellPrice.Text = "$258";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Tokyo Monkey":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        CheckedRecipeListBox.Items.Add("Sweet Smegma + Mouth Wash = Tokyo Express", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Express + Horse Semen = Nightmare Puke", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Puke + Energy Drink = Sexy Puke", false);
                        CheckedRecipeListBox.Items.Add("Sexy Puke + Addy = Aspen Fuel", false);
                        CheckedRecipeListBox.Items.Add("Aspen Fuel + Donut = White Durkle", false);
                        CheckedRecipeListBox.Items.Add("White Durkle + Chili = Tokyo Monkey", false);
                        ItemSellPrice.Text = "$244";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "White Durkle":
                        CheckedRecipeListBox.Items.Add("Meth + Viagra = Sweet Smegma", false);
                        CheckedRecipeListBox.Items.Add("Sweet Smegma + Mouth Wash = Tokyo Express", false);
                        CheckedRecipeListBox.Items.Add("Tokyo Express + Horse Semen = Nightmare Puke", false);
                        CheckedRecipeListBox.Items.Add("Nightmare Puke + Energy Drink = Sexy Puke", false);
                        CheckedRecipeListBox.Items.Add("Sexy Puke + Addy = Aspen Fuel", false);
                        CheckedRecipeListBox.Items.Add("Aspen Fuel + Donut = White Durkle", false);
                        ItemSellPrice.Text = "$216";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Dark Cum":
                        CheckedRecipeListBox.Items.Add("Meth + Chili = Mega Smegma", false);
                        CheckedRecipeListBox.Items.Add("Mega Smegma + Gasoline = Strawberry Urkle", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Urkle + Banana = Purple Shart", false);
                        CheckedRecipeListBox.Items.Add("Purple Shart + Banana = Island Death", false);
                        CheckedRecipeListBox.Items.Add("Island Death + Donut = Extreme Rhino", false);
                        CheckedRecipeListBox.Items.Add("Extreme Rhino + Donut = Dark Cum", false);
                        ItemSellPrice.Text = "$154";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Extreme Rhino":
                        CheckedRecipeListBox.Items.Add("Meth + Chili = Mega Smegma", false);
                        CheckedRecipeListBox.Items.Add("Mega Smegma + Gasoline = Strawberry Urkle", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Urkle + Banana = Purple Shart", false);
                        CheckedRecipeListBox.Items.Add("Purple Shart + Banana = Island Death", false);
                        CheckedRecipeListBox.Items.Add("Island Death + Donut = Extreme Rhino", false);
                        ItemSellPrice.Text = "$154";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Island Death":
                        CheckedRecipeListBox.Items.Add("Meth + Chili = Mega Smegma", false);
                        CheckedRecipeListBox.Items.Add("Mega Smegma + Gasoline = Strawberry Urkle", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Urkle + Banana = Purple Shart", false);
                        CheckedRecipeListBox.Items.Add("Purple Shart + Banana = Island Death", false);
                        ItemSellPrice.Text = "$148";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Purple Shart":
                        CheckedRecipeListBox.Items.Add("Meth + Chili = Mega Smegma", false);
                        CheckedRecipeListBox.Items.Add("Mega Smegma + Gasoline = Strawberry Urkle", false);
                        CheckedRecipeListBox.Items.Add("Strawberry Urkle + Banana = Purple Shart", false);
                        ItemSellPrice.Text = "$111";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Strawberry Urkle":
                        CheckedRecipeListBox.Items.Add("Meth + Chili = Mega Smegma", false);
                        CheckedRecipeListBox.Items.Add("Mega Smegma + Gasoline = Strawberry Urkle", false);
                        ItemSellPrice.Text = "$97";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                    case "Mega Smegma":
                        CheckedRecipeListBox.Items.Add("Meth + Chili = Mega Smegma", false);
                        ItemSellPrice.Text = "$97";
                        AddictivenessProgressTextBox.Text = "100%";
                        DrugAddictivenessProgressBar.Value = 100;
                        break;
                }
            }
        }
    }
}
