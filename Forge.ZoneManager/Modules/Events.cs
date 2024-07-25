using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace Forge.ZoneManager.Modules
{
    public static class Events
    {
        public static void onDamageAnimalRequested(ref DamageAnimalParameters parameters, ref bool shouldAllow)
        {
            ZoneManager.CheckZoneRestrictions(parameters.animal.transform.position, StorageZoneFlagType.NoAnimalDamage, ref shouldAllow);
        }

        public static void onDamageBarricadeRequested(CSteamID instigatorSteamID, Transform barricadeTransform, ref ushort pendingTotalDamage, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            ZoneManager.CheckZoneRestrictions(barricadeTransform.position, StorageZoneFlagType.NoDamage, ref shouldAllow);
        }

        public static void onDamagePlayerRequested(ref DamagePlayerParameters parameters, ref bool shouldAllow)
        {
            ZoneManager.CheckPlayerDamageRestrictions(ref parameters, ref shouldAllow);
        }

        public static void onDamageStructureRequested(CSteamID instigatorSteamID, Transform structureTransform, ref ushort pendingTotalDamage, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            ZoneManager.CheckZoneRestrictions(structureTransform.position, StorageZoneFlagType.NoDamage, ref shouldAllow);
        }

        public static void onDamageTireRequested(CSteamID instigatorSteamID, InteractableVehicle vehicle, int tireIndex, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            ZoneManager.CheckZoneRestrictions(vehicle.transform.position, StorageZoneFlagType.NoTireDamage, ref shouldAllow);
        }

        public static void onDamageVehicleRequested(CSteamID instigatorSteamID, InteractableVehicle vehicle, ref ushort pendingTotalDamage, ref bool canRepair, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            ZoneManager.CheckZoneRestrictions(vehicle.transform.position, StorageZoneFlagType.NoVehicleDamage, ref shouldAllow);
        }

        public static void onDamageZombieRequested(ref DamageZombieParameters parameters, ref bool shouldAllow)
        {
            ZoneManager.CheckZoneRestrictions(parameters.zombie.transform.position, StorageZoneFlagType.NoZombieDamage, ref shouldAllow);
        }

        public static void onPlayerConnected(UnturnedPlayer player)
        {
            ZoneManager.OnPlayerConnected(player);
        }

        public static void onPlayerDisconnected(UnturnedPlayer player)
        {
            ZoneManager.OnPlayerDisconnected(player);
        }

        public static void onSiphonVehicleRequested(InteractableVehicle vehicle, Player instigatingPlayer, ref bool shouldAllow, ref ushort desiredAmount)
        {
            ZoneManager.CheckZoneRestrictions(vehicle.transform.position, StorageZoneFlagType.NoVehicleSiphoning, ref shouldAllow);
        }

        public static void onVehicleCarjacked(InteractableVehicle vehicle, Player instigatingPlayer, ref bool allow, ref Vector3 force, ref Vector3 torque)
        {
            ZoneManager.CheckZoneRestrictions(vehicle.transform.position, StorageZoneFlagType.NoVehicleCarjack, ref allow);
        }

        public static void onVehicleLockpicked(InteractableVehicle vehicle, Player instigatingPlayer, ref bool allow)
        {
            ZoneManager.CheckZoneRestrictions(vehicle.transform.position, StorageZoneFlagType.NoLockpick, ref allow);
        }
    }
}