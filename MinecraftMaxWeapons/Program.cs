using System;
using System.IO;
using System.Reflection;
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

            
            string sword = "netherite_sword{ Enchantments: [{ id: sharpness,lvl: 9999},{ id: smite,lvl: 9999},{ id: bane_of_arthropods,lvl: 9999},{ id: cleaving,lvl: 9999},{ id: sweeping,lvl: 9999},{ id: fire_aspect,lvl: 9999},{ id: looting,lvl: 9999},{ id: thorns,lvl: 9999}],Unbreakable: 1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, sword));

            string shovel = "minecraft:netherite_shovel{Unbreakable:1,Enchantments:[{id:efficiency,lvl:1000},{id:fortune,lvl:1000}]} 1";
            output.AppendLine(String.Format("give {0} {1}", username, shovel));

            string axe = "netherite_axe{Enchantments:[{id:sharpness,lvl:9999},{id:smite,lvl:9999},{id:bane_of_arthropods,lvl:9999},{id:thorns,lvl:9999},{id:fire_aspect,lvl:9999},{id:looting,lvl:9999},{id:fortune,lvl:9999},{id:efficiency,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, axe));

            string shield = "shield{BlockEntityTag:{Base:3,Patterns:[{Pattern:\"dls\",Color:0},{Pattern:\"gru\",Color:3},{Pattern:\"gra\",Color:0},{Pattern:\"bo\",Color:15}]},Enchantments:[{id:sharpness,lvl:9999},{id:thorns,lvl:9999},{id:looting,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, shield));

            string pickaxe = "netherite_pickaxe{Enchantments:[{id:efficiency,lvl:1000},{id:unbreaking,lvl:1000},{id:fortune,lvl:1000}]} 1";
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

            string elytra = "minecraft:elytra{Unbreakable: 1,Enchantments: [{ id: mending,lvl: 1000}]} 1";
            output.AppendLine(String.Format("give {0} {1}", username, elytra));

            string crossbow = "crossbow{Enchantments:[{id:quick_charge,lvl:5},{id:multishot,lvl:10},{id:piercing,lvl:10},{id:knockback,lvl:5},{id:fire_aspect,lvl:9999},{id:thorns,lvl:9999}],Unbreakable:1} 1";
            output.AppendLine(String.Format("give {0} {1}", username, crossbow));

            string arrows = "minecraft:arrow 256";
            output.AppendLine(String.Format("give {0} {1}", username, arrows));
            
            string fireworks = "minecraft:firework_rocket{Fireworks:{Flight: 64}} 256";
            output.AppendLine(String.Format("give {0} {1}", username, fireworks));

            string effects = "absorption 1000000 4 true\neffect give @a conduit_power 1000000 255 true\neffect give @a regeneration 1000000 255 true\neffect give @a resistance 1000000 255 true\neffect give @a speed 1000000 1 true\neffect give @a strength 1000000 255 true\neffect give @a water_breathing 1000000 255 true\neffect give @a dolphins_grace 1000000 1 true\neffect give @a fire_resistance 1000000 255 true\neffect give @a glowing 1000000 255 true\neffect give @a haste 1000000 255 true\neffect give @a hero_of_the_village 99999 255 true\neffect give @a instant_damage 99999 255 true\neffect give @a instant_health 99999 255 true\neffect give @a jump_boost 99999 1 true\neffect give @a luck 99999 255 true\neffect give @a night_vision 99999 255 true";
            output.AppendLine(String.Format("effect give {0} {1}", username, effects));

            string experince = "999 levels";
            output.AppendLine(String.Format("experience add {0} {1}", username, experince));

            File.WriteAllText("log.txt", output.ToString());


            string optionsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "options.txt");

            
            Console.WriteLine(String.Format("Reading Options Path: {0}", optionsPath));

            string fifoPath = File.ReadAllLines(optionsPath)[0];
            Console.WriteLine(String.Format("Writing to FIFO Steam: {0}", fifoPath));

            Console.ReadLine();
            fifoPath = fifoPath + "/fifo";
            FileStream fs = File.OpenWrite(fifoPath);

            System.Threading.Thread.Sleep(1000);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("say Weapons Given");
                sw.WriteLine(output.ToString());
            }



            Console.WriteLine(output.ToString());
 
            Console.ReadLine();

        }

    }   
}

