namespace Pure3D.Chunks
{
    [ChunkType(65540)]
    public class BoundingSphere(File file, uint type) : Chunk(file, type)
    {
        public Vector3 Centre;
        public float Radius;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Centre = Util.ReadVector3(reader);
            Radius = reader.ReadSingle();
        }

        public override string ToString()
        {
            return $"Bounding Sphere (Centre: {Centre}, Radius: {Radius})";
        }

        public override string ToShortString()
        {
            return "Bounding Sphere";
        }
    }
}