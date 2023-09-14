using System;
using System.IO;
using System.Text;

namespace MinecraftMaxWeapons
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();
            Console.WriteLine("UserName:");
            String username = Console.ReadLine();
            if (username == "")
            {
                username = "@a";
            }


            Console.WriteLine("Giving Items");

            string sword = "netherite_sword{Enchantments:[{id:sharpness,lvl:9999},{id:smite,lvl:9999},{id:bane_of_arthropods,lvl:9999},{id:cleaving,lvl:9999},{id:sweeping,lvl:9999},{id:fire_aspect,lvl:9999},{id:looting,lvl:9999},{id:thorns,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, sword));

            string axe = "netherite_axe{Enchantments:[{id:sharpness,lvl:9999},{id:smite,lvl:9999},{id:bane_of_arthropods,lvl:9999},{id:thorns,lvl:9999},{id:fire_aspect,lvl:9999},{id:looting,lvl:9999},{id:fortune,lvl:9999},{id:efficiency,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, axe));

            string shield = "shield{BlockEntityTag:{Base:3,Patterns:[{Pattern:\"dls\",Color:0},{Pattern:\"gru\",Color:3},{Pattern:\"gra\",Color:0},{Pattern:\"bo\",Color:15}]},Enchantments:[{id:sharpness,lvl:9999},{id:thorns,lvl:9999},{id:looting,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, shield));

            string pickaxe = "give @p diamond_pickaxe{Enchantments:[{id:efficiency,lvl:1000},{id:unbreaking,lvl:1000},{id:fortune,lvl:1000}]}";
            output.AppendLine(String.Format("give {0} {1}", username, pickaxe));

            string bow = "bow{Enchantments:[{id:power,lvl:99999},{id:sharpness,lvl:9999},{id:thorns,lvl:9999},{id:infinity,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, bow));

            string helmet = "netherite_helmet{Enchantments:[{id:protection,lvl:9999},{id:feather_falling,lvl:9999},{id:respiration,lvl:9999},{id:depth_strider,lvl:9999},{id:aqua_affinity,lvl:9999},{id:thorns,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, helmet));

            string chestplate = "netherite_chestplate{Enchantments:[{id:protection,lvl:9999},{id:feather_falling,lvl:9999},{id:respiration,lvl:9999},{id:depth_strider,lvl:9999},{id:aqua_affinity,lvl:9999},{id:thorns,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, chestplate));

            string leggings = "netherite_leggings{Enchantments:[{id:protection,lvl:9999},{id:feather_falling,lvl:9999},{id:respiration,lvl:9999},{id:depth_strider,lvl:9999},{id:aqua_affinity,lvl:9999},{id:thorns,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, leggings));

            string boots = "netherite_boots{Enchantments:[{id:protection,lvl:9999},{id:feather_falling,lvl:9999},{id:respiration,lvl:9999},{id:depth_strider,lvl:9999},{id:aqua_affinity,lvl:9999},{id:thorns,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, boots));

            string crossbow = "crossbow{Enchantments:[{id:quick_charge,lvl:5},{id:multishot,lvl:10},{id:piercing,lvl:10},{id:knockback,lvl:5},{id:fire_aspect,lvl:9999},{id:thorns,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, crossbow));

            string arrows = "minecraft:arrow 256";
            output.AppendLine(String.Format("give {0} {1}", username, arrows));

            string fireworks = "minecraft:firework_rocket 256";
            output.AppendLine(String.Format("give {0} {1}", username, fireworks));

            string effects = "experience add @s 999 levels\neffect give @p absorption 1000000 4 true\neffect give @p conduit_power 1000000 255 true\neffect give @p regeneration 1000000 255 true\neffect give @p resistance 1000000 255 true\neffect give @p speed 1000000 1 true\neffect give @p strength 1000000 255 true\neffect give @p water_breathing 1000000 255 true\neffect give @p dolphins_grace 1000000 1 true\neffect give @p fire_resistance 1000000 255 true\neffect give @p glowing 1000000 255 true\neffect give @p haste 1000000 255 true\neffect give @p hero_of_the_village 99999 255 true\neffect give @p instant_damage 99999 255 true\neffect give @p instant_health 99999 255 true\neffect give @p jump_boost 99999 1 true\neffect give @p luck 99999 255 true\neffect give @p night_vision 99999 255 true";
            output.AppendLine(String.Format("give {0} {1}", username, effects));



            string fifoPath = File.ReadAllLines("options.txt")[0];
            fifoPath = fifoPath + "/fifo";
            FileStream fs = File.OpenWrite(fifoPath);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("say Weapons Given");
                sw.WriteLine(output.ToString());
            }

            Console.ReadLine();

        }

    }   
}

