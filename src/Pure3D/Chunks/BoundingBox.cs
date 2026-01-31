namespace Pure3D.Chunks
{
    [ChunkType(65539)]
    public class BoundingBox(File file, uint type) : Chunk(file, type)
    {
        public Vector3 Low;
        public Vector3 High;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Low = Util.ReadVector3(reader);
            High = Util.ReadVector3(reader);
        }

        public override string ToString()
        {
            return $"Bounding Box (Low: {Low}, High: {High})";
        }

        public override string ToShortString()
        {
            return "Bounding Box";
        }
    }
}