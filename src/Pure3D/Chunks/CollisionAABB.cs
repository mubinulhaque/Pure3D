using System.IO;

namespace Pure3D.Chunks
{
    [ChunkType(117506054)]
    public class CollisionAABB : Chunk
    {

        public CollisionAABB(File file, uint type) : base(file, type)
        {
        }

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            reader.ReadUInt32(); // For some reason, there are 4 bytes here that do nothing
        }

        public override string ToString()
        {
            return "Collision Axis-Aligned Bounding Box";
        }
    }
}