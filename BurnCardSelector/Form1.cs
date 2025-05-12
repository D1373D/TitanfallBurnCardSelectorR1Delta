using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace BurnCardSelector
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> cardIDToCardName = new Dictionary<string, string>();
        public Dictionary<string, string> cardNameToCardID = new Dictionary<string, string>();
        public Dictionary<string, Image> cardIDToCardImage = new Dictionary<string, Image>();
        public Dictionary<string, int> cardIDInventoryDic = new Dictionary<string, int>();
        public Dictionary<string, int>[] saveSlots = new Dictionary<string, int>[5];
        public string selectedItemID;
        public string selectedItemName;
        public string profilePath;
        public string profileRaw;
        public int quantityToAdd = 1;
        public int currentCardsInInv = 0;
        public bool isInvListEmpty = true;
        public int maxCardsInInv = 97;
        public string[] equippedCardSlot1;
        public string[] equippedCardSlot2;
        public string[] equippedCardSlot3;
        //public List<string> inventoryCards = new List<string>();
        public static Image GetImageFromResources(string resourceName)
        {
            //CARD NAME TO IMG
            var prop = typeof(Properties.Resources).GetProperty(resourceName, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            return prop?.GetValue(null) as Image;
        }
        private void AssembleDictionaries()
        {
            equippedCardSlot1 = ["pdata_null", "pdata_null", "pdata_null", "pdata_null", "pdata_null"];
            equippedCardSlot2 = ["pdata_null", "pdata_null", "pdata_null", "pdata_null", "pdata_null"];
            equippedCardSlot3 = ["pdata_null", "pdata_null", "pdata_null", "pdata_null", "pdata_null"];
            saveSlots[0] = new Dictionary<string, int>();
            saveSlots[1] = new Dictionary<string, int>();
            saveSlots[2] = new Dictionary<string, int>();
            saveSlots[3] = new Dictionary<string, int>();
            saveSlots[4] = new Dictionary<string, int>();
            cardIDToCardName = new Dictionary<string, string>
            {
                { "bc_rocket_launcher_m2", "Amped_Archer" },
                { "bc_defender_m2", "Amped_Charge_Rifle" },
                { "bc_smr_m2", "Amped_Sidewinder" },
                { "bc_mgl_m2", "Amped_Mag_Launcher" },
                { "bc_titan_arc_cannon_m2", "Amped_Arc_Cannon" },
                { "bc_titan_sniper_m2", "Amped_Railgun" },
                { "bc_titan_xo16_m2", "Amped_XO16" },
                { "bc_titan_triple_threat_m2", "Amped_Triple_Threat" },
                { "bc_titan_rocket_launcher_m2", "Amped_Quad_Rocket" },
                { "bc_titan_40mm_m2", "Amped_40mm" },
                { "bc_titan_homing_rockets_m2", "Amped_Slaved_Warheads" },
                { "bc_titan_shoulder_rockets_m2", "Amped_Missile_System" },
                { "bc_titan_salvo_rockets_m2", "Amped_Rocket_Salvo" },
                { "bc_titan_dumbfire_missile_m2", "Amped_Cluster_Missile" },
                { "bc_titan_vortex_shield_m2", "Amped_Vortex_Shield" },
                { "bc_titan_electric_smoke_m2", "Amped_Electric_Smoke" },
                { "bc_titan_shield_wall_m2", "Amped_Particle_Wall" },
                { "bc_titan_melee_m2", "Explosive_Punch" },
                {"bc_extra_dash", "Turbo_Engine" },
                { "bc_nuclear_core", "Massive_Payload" },
                { "bc_autopistol_m2", "Amped_RE45" },
                { "bc_semipistol_m2", "Amped_P2011" },
                { "bc_hemlok_m2", "Amped_Hemlok" },
                { "bc_smart_pistol_m2", "Amped_Smart_Pistol" },
                { "bc_rspn101_m2", "Amped_R101C" },
                { "bc_sniper_m2", "Amped_Kraber" },
                { "bc_lmg_m2", "Amped_LMG" },
                { "bc_dmr_m2", "Amped_DMR" },
                { "bc_r97_m2", "Amped_R97" },
                { "bc_car_m2", "Amped_CAR" },
                { "bc_g2_m2", "Amped_G2A4" },
                { "bc_wingman_m2", "Amped_Wingman" },
                { "bc_shotgun_m2", "Amped_EVA8" },
                { "bc_frag_m2", "Bottomless_Frags" },
                { "bc_satchel_m2", "Surplus_Satchels" },
                { "bc_arc_m2", "Shock_Rocks" },
                { "bc_summon_ogre", "Reserve_Ogre" },
                { "bc_summon_stryder", "Spare_Stryder" },
                { "bc_summon_atlas", "Atlas_Refurb" },
                { "bc_wifi_spectre_hack", "WiFi_Virus" },
                { "bc_fast_build_2", "Outsource" },
                { "bc_free_build_time_1", "Decisive_Action" },
                { "bc_free_build_time_2", "Pull_Rank" },
                { "bc_core_charged", "Super_Charger" },
                { "bc_cloak_forever", "Ghost_Squad" },
                { "bc_double_xp", "Fast_Learner" },
                { "bc_double_agent", "Double_Agent" },
                { "bc_rematch", "Rematch" },
                { "bc_fast_movespeed", "Prosthetic_Legs" },
                { "bc_prox_m2", "Personal_Alarm_System" },
                { "bc_pilot_warning", "Spider_Sense" },
                { "bc_minimap_scan", "Satellite_Uplink" },
                { "bc_conscription", "Conscription" },
                { "bc_sonar_forever", "Echo_Vision" },
                { "bc_stim_forever", "Adrenaline_Transfusion" },
                { "bc_super_sonar", "Aural_Implant" },
                { "bc_super_stim", "Smuggled_Stimulant" },
                { "bc_super_cloak", "Active_Camo" },
                { "bc_auto_sonar", "Packet_Sniffer" },
                { "bc_minimap", "Map_Hack" },
                { "bc_play_spectre", "Spectre_Camo" },
                { "bc_hunt_titan", "Titan_Salvage" },
                { "bc_hunt_soldier", "Thin_The_Ranks" },
                { "bc_hunt_spectre", "Urban_Renewal" },
                { "bc_hunt_pilot", "Most_Wanted_List" },
                { "bc_dice_ondeath", "Select_A_Burn_Card" },
                { "pdata_null", "Empty" },
                { "bc_auto_refill", "Roll_The_Dice" }
            };
            cardNameToCardID = cardIDToCardName.ToDictionary(pair => pair.Value, pair => pair.Key);
            foreach (var ID in cardIDToCardName)
            {
                cardIDToCardImage.Add(ID.Key, GetImageFromResources(ID.Value));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProfilecfg();
            AssembleDictionaries();
            BurnCardFullList.Items.AddRange(cardIDToCardName.Values.ToArray());
            BurnCardFullList.Items.Remove("Empty");
            BurnCardFullList.SelectedIndex = 0;
            quantityToAdd = (int)InventoryQuantityButton.Value;
            for(int i = 1;i<=5;i++)
            {
                LoadoutsListBox.Items.Add("Loadout Slot " + i);
            }
            LoadAllLoadouts();
            LoadoutsListBox.SelectedIndex = 0;
        }
        public void LoadProfilecfg()
        {
            profilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved Games\\Respawn\\R1Delta\\profile\\profile.cfg");
            try
            {
                profileRaw = File.ReadAllText(profilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}");
            }
        }
        public void WriteProfilecfg()
        {
            //assemble raw card array
            string[] inventoryCards = new string[97];
            int k = 0;
            foreach (DataGridViewRow row in CardInventoryTable.Rows)
            {
                for (int i = 0; i < (int)row.Cells["X"].Value; i++)
                {
                    inventoryCards[k] = cardNameToCardID[row.Cells["Card"].Value.ToString()];
                    k++;
                }
            }
            string[] profileSplitByLine = profileRaw.Split(new[] { '\n' }, StringSplitOptions.None);
            int lineOffset=0;
            for(int i = 0;i<300;i++)
            {
                if (profileSplitByLine[i].Contains("__ burnCardDeck[0]"))
                {
                    lineOffset= i;
                }
            }
            for (int i = 0; i < k; i++)
            {
                profileSplitByLine[i + lineOffset] = "__ burnCardDeck["+i+"] " + inventoryCards[i];
            }
            for(int i = k;i<97;i++)
            {
                profileSplitByLine[i + lineOffset]= "__ burnCardDeck["+i+"] " + "pdata_" + "null";
            }
            //last 3 and first 3
            profileSplitByLine[230]= "__ burnCardDeck[97] "+"pdata_"+"null";
            profileSplitByLine[231] = "__ burnCardDeck[98] " + "pdata_" + "null";
            profileSplitByLine[232] = "__ burnCardDeck[99] " + "pdata_" + "null";
            for(int i=900; i<1200;i++)
            {
                if (profileSplitByLine[i].Contains("__ persData_activeBurnCards[0]."))
                {
                    profileSplitByLine[i] = "__ persData_activeBurnCards[0].cardRef " + '"' + cardNameToCardID[EquippedCard0.Text] + '"';
                    profileSplitByLine[i+3] = "__ persData_activeBurnCards[1].cardRef " + '"' + cardNameToCardID[EquippedCard1.Text] + '"';
                    profileSplitByLine[i+6] = "__ persData_activeBurnCards[2].cardRef " + '"' + cardNameToCardID[EquippedCard2.Text] + '"';
                    break;
                }
            }
            string resultString = string.Join("\n", profileSplitByLine);
            try
            {
                // Write the content to the specified file
                File.WriteAllText(profilePath, resultString);
                MessageBox.Show("File written successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }
        public void LoadAllLoadouts()
        {
            //make directory
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved Games\\Respawn\\BurnCardEditor\\"));
            //load all 5 files,even is id, odd is quantity
            //1
            for (int i = 0; i < 5; i++)
            {
                string loadoutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved Games\\Respawn\\BurnCardEditor\\Loadout" + (i + 1).ToString() + ".ldt");
                if (!File.Exists(loadoutPath))
                {
                    File.Create(loadoutPath).Close();
                }
                string loadoutRaw = File.ReadAllText(loadoutPath);
                string[] loadoutRawSplit = loadoutRaw.Split(new[] { '\n' }, StringSplitOptions.None);
                //selected cards
                if (loadoutRawSplit.Length <= 1 || loadoutRawSplit[1] == null || loadoutRawSplit[1] == "pdata_null")
                {
                    equippedCardSlot2[i] = "pdata_null";
                }
                else
                {
                    equippedCardSlot1[i] = Regex.Replace(loadoutRawSplit[0], @"\r\n?|\n", "");
                }
                if (loadoutRawSplit.Length <= 2 || loadoutRawSplit[1] == null || loadoutRawSplit[1] == "pdata_null")
                {
                    equippedCardSlot2[i] = "pdata_null";
                }
                else
                {
                    equippedCardSlot2[i] = Regex.Replace(loadoutRawSplit[1], @"\r\n?|\n", "");
                }
                if (loadoutRawSplit.Length <= 3 || loadoutRawSplit[2] == null || loadoutRawSplit[2] == "pdata_null")
                {
                    equippedCardSlot3[i] = "pdata_null";
                }
                else
                {
                    equippedCardSlot3[i] = Regex.Replace(loadoutRawSplit[2], @"\r\n?|\n", "");
                }
                //ID on line 0, quantity on line 1
                //save slot number i:a string to int dictionary--ID to its quantity saveSlots[slotnumber][ID on line k]=quantity on line k + 1
                for (int k = 3; k < (loadoutRawSplit.Length-3) / 2; k += 2)
                {
                    saveSlots[i][Regex.Replace(loadoutRawSplit[k+3], @"\r\n?|\n", "")] = int.Parse(Regex.Replace(loadoutRawSplit[k+4], @"\r\n?|\n", ""));
                }
            }
        }
        public void LoadSelectedLoadout(object sender, EventArgs e)
        {
            currentCardsInInv = 0;
            //copy save slot dict into inventory dict
            cardIDInventoryDic.Clear();
            int selectedIndex = LoadoutsListBox.SelectedIndex;
            foreach (string key in saveSlots[selectedIndex].Keys)
            {
                cardIDInventoryDic[key] = saveSlots[selectedIndex][key];
                currentCardsInInv += saveSlots[selectedIndex][key];
            }
            //update UI
            EquippedCard0.Text = cardIDToCardName[equippedCardSlot1[selectedIndex]];
            EquippedCard1.Text = cardIDToCardName[equippedCardSlot2[selectedIndex]];
            EquippedCard2.Text = cardIDToCardName[equippedCardSlot3[selectedIndex]];
            CardInventoryTable.Rows.Clear();
            foreach(string key in cardIDInventoryDic.Keys)
            {
                if(key!=null)
                {
                    CardInventoryTable.Rows.Add(cardIDToCardName[key], cardIDInventoryDic[key]);
                    CardInventoryTable.Rows[0].Selected = true;
                    selectedItemID = key;
                    selectedItemName=cardIDToCardName[key];
                }
            }
        }
        public void SaveSelectedLoadout(object sender, EventArgs e)
        {
            //save highlighted loadout
            //put the 3 equipped cards into the highlighted loadout slot
            equippedCardSlot1[LoadoutsListBox.SelectedIndex] = cardNameToCardID[EquippedCard0.Text];
            equippedCardSlot2[LoadoutsListBox.SelectedIndex] = cardNameToCardID[EquippedCard1.Text];
            equippedCardSlot3[LoadoutsListBox.SelectedIndex] = cardNameToCardID[EquippedCard2.Text];
            //copy dict into save slot
            int selectedIndex = LoadoutsListBox.SelectedIndex;
            foreach (string key in cardIDInventoryDic.Keys)
            {
                saveSlots[selectedIndex][key] = cardIDInventoryDic[key];
            }
            /*
            foreach (string key in cardIDInventoryDic.Keys)
            {
                //MessageBox.Show(saveSlots[LoadoutsListBox.SelectedIndex][key].ToString());
                saveSlots[LoadoutsListBox.SelectedIndex][key] = cardIDInventoryDic[key];
            }*/
            WriteAllLoadouts();
        }
        public void WriteAllLoadouts()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                builder.Clear();
                builder.AppendLine(equippedCardSlot1[i]);
                builder.AppendLine(equippedCardSlot2[i]);
                builder.AppendLine(equippedCardSlot3[i]);
                if (saveSlots != null && saveSlots.Length > 0)
                {
                    foreach (string key in saveSlots[i].Keys)
                    {
                        builder.AppendLine(key);
                        builder.AppendLine(saveSlots[i][key].ToString());
                    }
                    File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved Games\\Respawn\\BurnCardEditor\\Loadout" + (i + 1).ToString() + ".ldt"), builder.ToString());
                }
                else
                {
                    File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved Games\\Respawn\\BurnCardEditor\\Loadout" + (i + 1).ToString() + ".ldt"), builder.ToString());
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateMaxAddValue()
        {
            InventoryQuantityButton.Maximum = 97 - currentCardsInInv;
            quantityToAdd = (int)InventoryQuantityButton.Value;
        }
        private void QuantityChanged(object sender, EventArgs e)
        {
            UpdateMaxAddValue();
        }
        private void AddCard_Click(object sender, EventArgs e)
        {
            UpdateMaxAddValue();
            currentCardsInInv += quantityToAdd;

            if (string.IsNullOrEmpty(selectedItemName) || quantityToAdd <= 0)
                return;

            if (cardIDInventoryDic.ContainsKey(selectedItemID))
            {
                cardIDInventoryDic[selectedItemID] += quantityToAdd;

                // find the row
                foreach (DataGridViewRow row in CardInventoryTable.Rows)
                {
                    if (row.Cells["Card"].Value.ToString() == selectedItemName)
                    {
                        row.Cells["X"].Value = cardIDInventoryDic[selectedItemID];
                        break;
                    }
                }
            }
            else
            {
                // Add to dictionary
                cardIDInventoryDic[selectedItemID] = quantityToAdd;

                // Add new row to DataGridView
                CardInventoryTable.Rows.Add(selectedItemName, quantityToAdd);
            }
            if (CardInventoryTable.Rows.Count > 0)
            {
                CardInventoryTable.Rows[0].Selected = true;
            }
            UpdateMaxAddValue();
        }
        private void RemoveCards_Click(object sender, EventArgs e)
        {
            if (cardIDInventoryDic.ContainsKey(selectedItemID) && CardInventoryTable.Rows.Count > 0)
            {
                currentCardsInInv -= cardIDInventoryDic[selectedItemID];
                UpdateMaxAddValue();
                foreach (DataGridViewRow row in CardInventoryTable.Rows)
                {
                    if (row.Cells["Card"].Value.ToString() == selectedItemName)
                    {
                        CardInventoryTable.Rows.Remove(row);
                        cardIDInventoryDic.Remove(selectedItemID);
                        break;
                    }
                }
            }
            if(CardInventoryTable.Rows.Count > 0)
            {
                selectedItemName = CardInventoryTable.Rows[0].Cells["Card"].Value.ToString();
                selectedItemID = cardNameToCardID[selectedItemName];
            }

        }

        private void BurnCardFullList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItemName = BurnCardFullList.SelectedItem?.ToString();
            selectedItemID = cardNameToCardID[selectedItemName];

            if (!string.IsNullOrEmpty(selectedItemID))
            {
                Image img = GetImageFromResources(selectedItemName);

                if (img != null)
                {
                    BurnCardDisplayBox.Image = img;
                }
            }
        }
        private void Button_AddEquipped0_Click(object sender, EventArgs e)
        {
            EquippedCard0.Text = BurnCardFullList.SelectedItem?.ToString();
        }

        private void Button_AddEquipped1_Click(object sender, EventArgs e)
        {
            EquippedCard1.Text = BurnCardFullList.SelectedItem?.ToString();
        }

        private void Button_AddEquipped2_Click(object sender, EventArgs e)
        {
            EquippedCard2.Text = BurnCardFullList.SelectedItem?.ToString();
        }

        private void ApplyProfile_Click(object sender, EventArgs e)
        {
            WriteProfilecfg();
        }
    }
}
