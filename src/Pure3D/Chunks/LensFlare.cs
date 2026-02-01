namespace Pure3D.Chunks
{
    [ChunkType(66060301)]
    public class LensFlare(File file, uint type) : VersionNamed(file, type)
    {
        public uint NumBillboardQuadGroups;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Name = Util.ReadString(reader);
            Version = reader.ReadUInt32();
            NumBillboardQuadGroups = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"{ToShortString()}: {Name} ({NumBillboardQuadGroups} Billboard Quad Groups, Version: {Version})";
        }

        public override string ToShortString()
        {
            return "Lens Flare";
        }
    }
}
