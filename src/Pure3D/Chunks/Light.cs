namespace Pure3D.Chunks
{
    [ChunkType(77824)]
    public class Light(File file, uint type) : VersionNamed(file, type)
    {
        public LightTypes LightType;
        public uint Colour;
        public float Constant;
        public float Linear;
        public float Squared;
        public bool Enabled;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Name = Util.ReadString(reader);
            Version = reader.ReadUInt32();
            LightType = (LightTypes)reader.ReadUInt32();
            Colour = reader.ReadUInt32();
            Constant = reader.ReadSingle();
            Linear = reader.ReadSingle();
            Squared = reader.ReadSingle();
            Enabled = reader.ReadUInt32() == 1;
        }

        public override string ToString()
        {
            return $"{ToShortString()}: {Name} (Type: {LightType}, Enabled: {Enabled}, Version: {Version})";
        }

        public enum LightTypes
        {
            AMBIENT,
            POINT,
            DIRECTIONAL,
            SPOT
        }

        public override string ToShortString()
        {
            return "Light";
        }
    }

    public abstract class LightVector(File file, uint type) : Chunk(file, type)
    {
        public Vector3 Vector;

        public override void ReadHeader(Stream stream, long length)
        {
            Vector = Util.ReadVector3(new BinaryReader(stream));
        }

        public override string ToString()
        {
            return $"{ToShortString()}: {Vector}";
        }

        public override string ToShortString()
        {
            return "Light Vector";
        }
    }

    [ChunkType(77825)]
    public class LightDirection(File file, uint type) : LightVector(file, type)
    {
        public override string ToShortString()
        {
            return "Light Direction";
        }
    }

    [ChunkType(77826)]
    public class LightPosition(File file, uint type) : LightVector(file, type)
    {
        public override string ToShortString()
        {
            return "Light Position";
        }
    }

    [ChunkType(77828)]
    public class LightShadow(File file, uint type) : Chunk(file, type)
    {
        public bool Shadow;

        public override void ReadHeader(Stream stream, long length)
        {
            Shadow = new BinaryReader(stream).ReadUInt32() == 1;
        }

        public override string ToString()
        {
            return $"{ToShortString()}: {Shadow}";
        }

        public override string ToShortString()
        {
            return "Light Shadow";
        }
    }
}
