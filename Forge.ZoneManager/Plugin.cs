using Forge.ZoneManager.Modules;
using Newtonsoft.Json;
using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using SDG.Unturned;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;

namespace Forge.ZoneManager
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Instance { get; private set; }

        protected override void Load()
        {
            Instance = this;

            U.Events.OnPlayerConnected += Events.onPlayerConnected;
            U.Events.OnPlayerDisconnected += Events.onPlayerDisconnected;

            BarricadeManager.onDamageBarricadeRequested += Events.onDamageBarricadeRequested;
            StructureManager.onDamageStructureRequested += Events.onDamageStructureRequested;

            VehicleManager.onVehicleLockpicked += Events.onVehicleLockpicked;
            VehicleManager.onDamageVehicleRequested += Events.onDamageVehicleRequested;
            VehicleManager.onDamageTireRequested += Events.onDamageTireRequested;
            VehicleManager.onVehicleCarjacked += Events.onVehicleCarjacked;
            VehicleManager.onSiphonVehicleRequested += Events.onSiphonVehicleRequested;

            DamageTool.damagePlayerRequested += Events.onDamagePlayerRequested;
            DamageTool.damageAnimalRequested += Events.onDamageAnimalRequested;
            DamageTool.damageZombieRequested += Events.onDamageZombieRequested;

            LoadZones();
        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events.onPlayerConnected;
            U.Events.OnPlayerDisconnected -= Events.onPlayerDisconnected;

            BarricadeManager.onDamageBarricadeRequested -= Events.onDamageBarricadeRequested;
            StructureManager.onDamageStructureRequested -= Events.onDamageStructureRequested;

            VehicleManager.onVehicleLockpicked -= Events.onVehicleLockpicked;
            VehicleManager.onDamageVehicleRequested -= Events.onDamageVehicleRequested;
            VehicleManager.onDamageTireRequested -= Events.onDamageTireRequested;
            VehicleManager.onVehicleCarjacked -= Events.onVehicleCarjacked;
            VehicleManager.onSiphonVehicleRequested += Events.onSiphonVehicleRequested;

            DamageTool.damagePlayerRequested -= Events.onDamagePlayerRequested;
            DamageTool.damageAnimalRequested -= Events.onDamageAnimalRequested;
            DamageTool.damageZombieRequested -= Events.onDamageZombieRequested;

            Instance = null;
        }

        private void LoadZones()
        {
            string filePath = Path.Combine(Directory, "zones.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var zones = JsonConvert.DeserializeObject<List<Zone>>(json);
            }
        }

        public override TranslationList DefaultTranslations => new TranslationList
        {
            { "", "" }
        };
    }
}