using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using static Fake_Obf_Remover.Logger;
using Type = Fake_Obf_Remover.Logger.Type;

namespace Fake_Obf_Remover
{
    internal static class FakeObfuscator
    {
        private static readonly List<string> FakeObfuscators = new List<string>()
        {
            "DotNetPatcherObfuscatorAttribute",
            "DotNetPatcherPackerAttribute",
            "DotfuscatorAttribute",
            "ObfuscatedByGoliath",
            "dotNetProtector",
            "PoweredByAttribute",
            "AssemblyInfoAttribute",
            "BabelAttribute",
            "CryptoObfuscator.ProtectedWithCryptoObfuscatorAttribute",
            "Xenocode.Client.Attributes.AssemblyAttributes.ProcessedByXenocode",
            "NineRays.Obfuscator.Evaluation",
            "YanoAttribute",
            "SmartAssembly.Attributes.PoweredByAttribute",
            "NetGuard",
            "BabelObfuscatorAttribute",
            "ConfusedByAttribute",
            "Xenocode",
            "Yano",
            "RoseObfuscator",
            "ObfuscatedByRose",
            "DotNetPatcher",
            "Dotfuscator",
            "CryptoObfuscator",
            "BabelObfuscator",
            "ﺁﻐﻬﻌﭢ",
            "ګٷٷڿﻬ",
            "ګﺁړڈﺇ",
            "de4fuckyou",
            "CrytpoObfuscator",
            "Beds-Protector",
            "OiCuntJollyGoodDayYeHavin_____________________________________________________",
            "ZYXDNGuarder"
        };

        public static void Execute(ModuleDefMD module)
        {
            Write("Removing the Fake Obfuscators...");

            
            var removed = 0;
            foreach (TypeDef type in module.Types.ToList().Where(t => FakeObfuscators.Contains(t.Name)))
            {
                module.Types.Remove(type);

                removed++;
                Write($"Removed the fake obfuscator type: {type.Name}", Type.Debug);
            }

            Write(removed == 0 ? "No Fake Obfscators found !" :
                  removed == 1 ? $"Removed {removed} fake obfuscator type !" :
                  removed > 1 ? $"Removed {removed} fake obfuscator types !" : "", Type.Success);
        }
    }
}
