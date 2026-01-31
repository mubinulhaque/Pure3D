namespace Pure3D.Chunks
{
    [ChunkType(94212)]
    public class BillboardPerspectiveInfo(File file, uint type) : Chunk(file, type)
    {
        public uint Version;
        public uint Perspective;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Version = reader.ReadUInt32();
            Perspective = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Billboard Perspective: {Perspective})";
        }

        public override string ToShortString()
        {
            return "Billboard Perspective Info";
        }
    }
}