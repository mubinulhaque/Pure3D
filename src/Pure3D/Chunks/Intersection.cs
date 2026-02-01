namespace Pure3D.Chunks
{
    [ChunkType(50331652)]
    public class Intersection(File file, uint type) : Named(file, type)
    {
        public Vector3 Position;
        public float Radius;
        public uint TrafficBehaviour;

        public override void ReadHeader(Stream stream, long length)
        {
            base.ReadHeader(stream, length);
            BinaryReader reader = new(stream);
            Position = Util.ReadVector3(reader);
            Radius = reader.ReadSingle();
            TrafficBehaviour = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"{ToShortString()}: {Name} (Position: {Position}, Radius: {Radius}, Traffic: {TrafficBehaviour})";
        }

        public override string ToShortString()
        {
            return "Intersection";
        }
    }
}
