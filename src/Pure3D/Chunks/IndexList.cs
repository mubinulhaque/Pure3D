namespace Pure3D.Chunks
{
    [ChunkType(65546)]
    public class IndexList(File file, uint type) : Chunk(file, type)
    {
        public uint[] Indices;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            uint len = reader.ReadUInt32();
            Indices = new uint[len];
            for (int i = 0; i < len; i++)
                Indices[i] = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Index List ({Indices.Length} Indices)";
        }

        public override string ToShortString()
        {
            return $"{Indices.Length} Indices";
        }
    }
}