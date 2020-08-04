using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DtD_LootViewer
{
    class lootContainernames
    {

        public static Dictionary<int, string> getNames()
        {
            //Initialize the names of Each of the Container IDs
            Dictionary<int, string> tempNames = new Dictionary<int, string>();

            //Attempt to Load the Container Names from the XML file, if Failed, set Defaults
            try
            {
                System.Xml.Linq.XElement rootElement = System.Xml.Linq.XElement.Load("containernames.xml");
                foreach(KeyValuePair<string, string> kv in rootElement.Elements().ToDictionary(key => key.Name.ToString(), val => val.Value))
                {
                    tempNames.Add(Int32.Parse(kv.Key.Substring(2)), kv.Value);
                }
            }
            catch
            {
                //File doesn't exist, create records manually
                tempNames.Add(1, "Empty");
                tempNames.Add(2, "Player dropped backpacks");
                tempNames.Add(3, "Player crafted cntGreenDrawerSecure");
                tempNames.Add(4, "Dropped Bag on Destroy");
                tempNames.Add(5, "StorageGeneric, paintable cube storage");
                tempNames.Add(6, "WallSafe/deskSafe");
                tempNames.Add(7, "Gun safe");
                tempNames.Add(8, "Sink/lower Cupboards");
                tempNames.Add(9, "Backpacks/Duffles");
                tempNames.Add(10, "Garbage/TrashPile");
                tempNames.Add(11, "Stove/oven");
                tempNames.Add(12, "POI Storage Box");
                tempNames.Add(13, "Laundry Basket");
                tempNames.Add(14, "Mailbox");
                tempNames.Add(15, "Misc Storage/Cardboard boxes");
                tempNames.Add(16, "Metal Garbage Can");
                tempNames.Add(17, "Cupboard");
                tempNames.Add(18, "Washing Machine");
                tempNames.Add(19, "Cars");
                tempNames.Add(20, "Refridgerators");
                tempNames.Add(21, "Microwave Oven");
                tempNames.Add(22, "Garage Storage");
                //	lootcontainer 23 Supply Crate Melee weapons			
                tempNames.Add(24, "Metal desk");
                tempNames.Add(25, "Bird Nest");
                //  lootcontainer 26 Supply Crate Food 
                //  lootcontainer 27 Supply Crate Building Supplies 
                //  lootcontainer 28 Supply Crate Ammo 
                //  lootcontainer 29 Supply Crate Ranged weapons Day 3 
                //  lootcontainer 30 Supply Crate Health 
                //  lootcontainer 31 Supply Crate Explosives 
                //  lootcontainer 32 Supply Crate Ranged weapons Day 5 
                //  lootcontainer 33 Supply Crate Ranged weapons Day 7 				
                tempNames.Add(34, "Supply Crate/normal airdrop");
                tempNames.Add(35, "Tree Stump");
                tempNames.Add(36, "Suitcase/Luggage");
                tempNames.Add(37, "Bath Tub");
                tempNames.Add(38, "Shamway Manager's Safe");
                tempNames.Add(39, "Brew Master's Safe");
                tempNames.Add(40, "Munitions Ammo Box");
                tempNames.Add(41, "LootChest Hero");
                tempNames.Add(42, "NightstandClosed");
                tempNames.Add(43, "Lockers");
                tempNames.Add(44, "File Cabinet");
                tempNames.Add(45, "Cooler");
                tempNames.Add(46, "Trash Compactor");
                tempNames.Add(47, "Refridgerated foods(Helper)");
                tempNames.Add(48, "Purse");
                tempNames.Add(49, "Bookcase");
                tempNames.Add(50, "Shotgun Messiah Crate");
                tempNames.Add(51, "Pop n Pills Case");
                tempNames.Add(52, "Beer Cooler");
                tempNames.Add(53, "Working Stiffs Crate");
                tempNames.Add(54, "Shopping Cart");
                tempNames.Add(55, "Cash Register");
                tempNames.Add(56, "Apache Artifact Chest");
                tempNames.Add(57, "CharcoalGrillClosed");
                tempNames.Add(58, "Shopping Basket");
                tempNames.Add(59, "Shamway Cardboard Box");
                tempNames.Add(60, "Bookstore Bookcase");
                tempNames.Add(61, "Treasure Chest");
                tempNames.Add(62, "Dummy for NPC traders");
                tempNames.Add(63, "Mountainman Loot");
                tempNames.Add(64, "Gas Pump");
                tempNames.Add(65, "Toilet");
                tempNames.Add(66, "Dumpster");
                tempNames.Add(67, "Mortician Drawer");
                tempNames.Add(68, "Furnace Drawer");
                tempNames.Add(69, "Green Drawer");
                tempNames.Add(70, "EntityLootContainerRegular");
                tempNames.Add(71, "EntityLootContainerStrong");
                tempNames.Add(72, "FetchQuest Satchel");
                tempNames.Add(73, "EntityLootContainerBoss");
                tempNames.Add(74, "EntityLootContainerBandit");
                tempNames.Add(75, "GasGrillClosed");
                tempNames.Add(76, "Bicycle Storage");
                tempNames.Add(77, "Minibike Storage");
                tempNames.Add(78, "Motorcycle Storage");
                tempNames.Add(79, "4x4Truck Storage");
                tempNames.Add(80, "Gyrocopter Storage");
                //  tempNames.Add(81, "Helicopter Storage");
                //  tempNames.Add(82, "Jokeblimp Storage");
                tempNames.Add(83, "Army Truck");
				tempNames.Add(84, "Metal clothes rack, pants");			
                tempNames.Add(85, "metal clothes rack, shirts");
                tempNames.Add(86, "Store shelves, food");			
                tempNames.Add(87, "Food store crate");						
                tempNames.Add(88, "Construction supplies shipping crate");
                tempNames.Add(89, "Bookstore shipping crate");
                tempNames.Add(90, "Car parts shipping crate");
                tempNames.Add(91, "Collapsed Forge");
                tempNames.Add(92, "Collapsed Workbench");
                tempNames.Add(93, "Collapsed CementMixer");
                tempNames.Add(94, "Collapsed ChemistryStation");
                tempNames.Add(95, "Hidden Stash/CrateHero");
                tempNames.Add(96, "Lab Equipment Crate");
                tempNames.Add(97, "Collapsed Batterybank");
                tempNames.Add(98, "Collapsed Generatorbank");
                tempNames.Add(99, "WaterCooler Full");
                tempNames.Add(100, "WeaponsBagSmall");
                tempNames.Add(101, "WeaponsBagLarge");
                tempNames.Add(102, "BuriedFoodStashChest");
                tempNames.Add(103, "Loot block for testing prefabs");
                tempNames.Add(104, "Weapon loot test template");
                tempNames.Add(105, "Tool loot test template");
                tempNames.Add(106, "Pill Case");
                tempNames.Add(107, "Medic LootPile");
                tempNames.Add(108, "AmmoPile Small");
                tempNames.Add(109, "AmmoPile Medium");
                tempNames.Add(110, "AmmoPile Large");
                tempNames.Add(111, "FoodPile Small");
                tempNames.Add(112, "FoodPile Medium");
                tempNames.Add(113, "FoodPile Large");
                tempNames.Add(114, "MedicalPile Small");
                tempNames.Add(115, "MedicalPile Medium");
                tempNames.Add(116, "MedicalPile Large");
                tempNames.Add(117, "UtilityCart Full");
                tempNames.Add(118, "Coffee Makers");
                tempNames.Add(119, "Soda Fountain");
                tempNames.Add(120, "Gas Barrel Old");
                tempNames.Add(121, "HardenedChest Secure");
                tempNames.Add(122, "Buried WeaponChest");
                tempNames.Add(123, "Closet Hanger/ Modular");
                tempNames.Add(124, "RollingToolBoxClosed");
				tempNames.Add(125, "ToolBoxClosed");
                tempNames.Add(126, "Store shelves");
                tempNames.Add(127, "Store shelves");
                tempNames.Add(128, "FreezerGroceriesMiddleFullClosed");
                tempNames.Add(129, "FreezerBeveragesMiddleFullClosed");
                tempNames.Add(130, "ClothesShelfJeans01");
                tempNames.Add(131, "Medicine cabinets");
                tempNames.Add(132, "DisplayCaseAmmoLeftBroken");
                tempNames.Add(133, "ShoesPileSneakers");
                tempNames.Add(134, "ShoesPileSneakers");
                tempNames.Add(135, "BookPile01");
                tempNames.Add(136, "BookShelfSingleBottomFull01");
                tempNames.Add(137, "GunRackWallArmor");
                tempNames.Add(138, "GunRackWallGuns01");
                tempNames.Add(139, "JunkDrone");
                tempNames.Add(140, "StoreShelfElectronicsSingle");
                tempNames.Add(141, "Clothes shelf, shirts");
                tempNames.Add(142, "Metal clothes rack, pants");
                tempNames.Add(143, "WineBarrel");
			}

            return tempNames;

        }
    }
}
