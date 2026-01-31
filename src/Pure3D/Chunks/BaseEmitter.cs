using System.IO;

namespace Pure3D.Chunks
{
    [ChunkType(88069)]
    public class BaseEmitter(File file, uint type) : VersionNamed(file, type)
    {
        public string ParticleType;
        public string GeneratorType;
        public bool ZTest;
        public bool ZWrite;
        public bool Fog;
        public uint MaxParticleCount;
        public bool InfiniteLife;
        public float RotationalCohesion;
        public float TranslationalCohesion;

        public override void ReadHeader(Stream stream, long length)
        {
            base.ReadHeader(stream, length);
            BinaryReader reader = new(stream);
            ParticleType = Util.ReadString(reader, 4);
            GeneratorType = Util.ReadString(reader, 4);
            ZTest = reader.ReadUInt32() == 1;
            ZWrite = reader.ReadUInt32() == 1;
            Fog = reader.ReadUInt32() == 1;
            MaxParticleCount = reader.ReadUInt32();
            InfiniteLife = reader.ReadUInt32() == 1;
            RotationalCohesion = reader.ReadSingle();
            TranslationalCohesion = reader.ReadSingle();
        }

        public override string ToString()
        {
            return $"{ToShortString()}: {Name} (Particles: {ParticleType}, Generator: {GeneratorType}, Version: {Version})";
        }

        public override string ToShortString()
        {
            return "Base Emitter";
        }
    }
}