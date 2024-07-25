using Forge.ZoneManager.Modules;
using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using SDG.Unturned;
using System.IO;

namespace Forge.ZoneManager
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Instance { get; private set; }
        private Modules.ZoneManager _zoneManager;

        protected override void Load()
        {
            Instance = this;
            string jsonFilePath = Path.Combine(Directory, "zones.json");
            _zoneManager = new Modules.ZoneManager(jsonFilePath);

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
            VehicleManager.onSiphonVehicleRequested -= Events.onSiphonVehicleRequested;

            DamageTool.damagePlayerRequested -= Events.onDamagePlayerRequested;
            DamageTool.damageAnimalRequested -= Events.onDamageAnimalRequested;
            DamageTool.damageZombieRequested -= Events.onDamageZombieRequested;

            Instance = null;
        }

        public override TranslationList DefaultTranslations => new TranslationList
        {
            { "", "" }
        };
    }
}