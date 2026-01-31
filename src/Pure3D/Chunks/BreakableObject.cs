using System.IO;

namespace Pure3D.Chunks
{
    [ChunkType(50335744)]
    public class BreakableObject(File file, uint type) : Chunk(file, type)
    {
        public uint Index;
        public uint Count;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Index = reader.ReadUInt32();
            Count = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"{Count} Breakable Objects (Index: {Index})";
        }

        public override string ToShortString()
        {
            return "Breakable Object";
        }
    }
}
