using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace Forge.ZoneManager.Modules
{
    public class ZoneStorage
    {
        private readonly string _jsonFilePath;
        public List<StorageZone> Zones { get; private set; } = new List<StorageZone>();

        public ZoneStorage(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
            LoadZones();
        }

        public void LoadZones()
        {
            if (File.Exists(_jsonFilePath))
            {
                string json = File.ReadAllText(_jsonFilePath);
                Zones = JsonConvert.DeserializeObject<List<StorageZone>>(json) ?? new List<StorageZone>();
            }
        }

        public void SaveZones()
        {
            string json = JsonConvert.SerializeObject(Zones, Formatting.Indented);
            File.WriteAllText(_jsonFilePath, json);
        }

        public void CreateZone(StorageZone newZone)
        {
            if (Zones.Any(z => z.Name.Equals(newZone.Name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException($"Zone with the name {newZone.Name} already exists.");
            }

            Zones.Add(newZone);
            SaveZones();
        }

        public StorageZone ReadZone(string name)
        {
            return Zones.FirstOrDefault(z => z.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateZone(StorageZone updatedZone)
        {
            var zone = Zones.FirstOrDefault(z => z.Name.Equals(updatedZone.Name, StringComparison.OrdinalIgnoreCase));
            if (zone == null)
            {
                throw new InvalidOperationException($"Zone with the name {updatedZone.Name} does not exist.");
            }

            zone.Nodes = updatedZone.Nodes;
            zone.Flags = updatedZone.Flags;
            SaveZones();
        }

        public void DeleteZone(string name)
        {
            var zone = Zones.FirstOrDefault(z => z.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (zone == null)
            {
                throw new InvalidOperationException($"Zone with the name {name} does not exist.");
            }

            Zones.Remove(zone);
            SaveZones();
        }
    }

    public class StorageZone
    {
        public string Name { get; set; }
        public List<Vector3> Nodes { get; set; } = new List<Vector3>();
        public List<StorageZoneFlagType> Flags { get; set; } = new List<StorageZoneFlagType>();
    }

    public enum StorageZoneFlagType
    {
        NoAnimalDamage,
        NoDamage,
        NoTireDamage,
        NoVehicleDamage,
        NoZombieDamage,
        NoVehicleSiphoning,
        NoVehicleCarjack,
        NoLockpick
    }
}