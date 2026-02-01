namespace Pure3D.Chunks
{
    [ChunkType(73728)]
    public class GameAttribute(File file, uint type) : VersionNamed(file, type) // I think it's VersionNamed, at least
    {
        public uint NumParameters;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Name = Util.ReadString(reader);
            Version = reader.ReadUInt32();
            NumParameters = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Game Attribute: {Name} ({NumParameters} Parameters, Version {Version})";
        }

        public override string ToShortString()
        {
            return "Game Attribute";
        }
    }
}