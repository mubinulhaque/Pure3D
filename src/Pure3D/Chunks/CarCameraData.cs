namespace Pure3D.Chunks
{
    [ChunkType(50331904)]
    public class CarCameraData(File file, uint type) : Chunk(file, type)
    {
        public uint Index;
        public float Rotation;
        public float Angle;
        public float Distance;
        public Vector3 Look;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Index = reader.ReadUInt32();
            Rotation = reader.ReadSingle();
            Angle = reader.ReadSingle();
            Distance = reader.ReadSingle();
            Look = Util.ReadVector3(reader);
        }

        public override string ToString()
        {
            return $"({ToShortString()}) {Index} (Rotation: {Rotation}, Angle: {Angle}, Distance: {Distance}, Look: {Look})";
        }

        public override string ToShortString()
        {
            return "Car Camera Data";
        }
    }
}