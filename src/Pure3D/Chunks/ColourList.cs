namespace Pure3D.Chunks
{
    [ChunkType(65544)]
    public class ColourList(File file, uint type) : Chunk(file, type)
    {
        public uint[] Colours;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            uint len = reader.ReadUInt32();
            Colours = new uint[len];
            for (int i = 0; i < len; i++)
                Colours[i] = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Colour List ({Colours.Length} Colours)";
        }

        public override string ToShortString()
        {
            return $"{Colours.Length} Colours";
        }
    }
}