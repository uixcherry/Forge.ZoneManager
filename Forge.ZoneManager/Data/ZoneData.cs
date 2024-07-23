using System.Collections.Generic;

namespace Forge.ZoneManager.Data
{
    public class Zone
    {
        public string name { get; set; }
        public List<Node> nodes { get; set; }
        public List<string> flags { get; set; }
    }

    public class Node
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }
}