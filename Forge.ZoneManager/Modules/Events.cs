using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using UnityEngine;

namespace Forge.ZoneManager.Modules
{
    public class Events : UnturnedPlayerComponent
    {
        public static void onDamageAnimalRequested(ref DamageAnimalParameters parameters, ref bool shouldAllow)
        {
            throw new NotImplementedException();
        }

        public static void onDamageBarricadeRequested(CSteamID instigatorSteamID, Transform barricadeTransform, ref ushort pendingTotalDamage, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            throw new NotImplementedException();
        }

        public static void onDamagePlayerRequested(ref DamagePlayerParameters parameters, ref bool shouldAllow)
        {
            throw new NotImplementedException();
        }

        public static void onDamageStructureRequested(CSteamID instigatorSteamID, Transform structureTransform, ref ushort pendingTotalDamage, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            throw new NotImplementedException();
        }

        public static void onDamageTireRequested(CSteamID instigatorSteamID, InteractableVehicle vehicle, int tireIndex, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            throw new NotImplementedException();
        }

        public static void onDamageVehicleRequested(CSteamID instigatorSteamID, InteractableVehicle vehicle, ref ushort pendingTotalDamage, ref bool canRepair, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            throw new NotImplementedException();
        }

        public static void onDamageZombieRequested(ref DamageZombieParameters parameters, ref bool shouldAllow)
        {
            throw new NotImplementedException();
        }

        public static void onPlayerConnected(UnturnedPlayer player)
        {
            throw new NotImplementedException();
        }

        public static void onPlayerDisconnected(UnturnedPlayer player)
        {
            throw new NotImplementedException();
        }

        public static void onSiphonVehicleRequested(InteractableVehicle vehicle, Player instigatingPlayer, ref bool shouldAllow, ref ushort desiredAmount)
        {
            throw new NotImplementedException();
        }

        public static void onVehicleCarjacked(InteractableVehicle vehicle, Player instigatingPlayer, ref bool allow, ref Vector3 force, ref Vector3 torque)
        {
            throw new NotImplementedException();
        }

        public static void onVehicleLockpicked(InteractableVehicle vehicle, Player instigatingPlayer, ref bool allow)
        {
            throw new NotImplementedException();
        }
    }
}