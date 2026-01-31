namespace Pure3D.Chunks
{
    [ChunkType(1184016)]
    public class ChannelInterpolationMode(File file, uint type) : Chunk(file, type)
    {
        public uint Version;
        public uint Mode;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Version = reader.ReadUInt32();
            Mode = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Channel Interpolation Mode: {Mode}";
        }

        public override string ToShortString()
        {
            return "Channel Interpolation Mode";
        }
    }
}