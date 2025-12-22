using System.IO;

namespace Pure3D.Chunks
{
    public class BaseAnimation(File file, uint type) : Chunk(file, type)
    {
        public uint Version; // I think it's Version at least

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Version = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"{ToShortString()} (Version: {Version})";
        }

        public override string ToShortString()
        {
            return "Base Animation";
        }
    }

    [ChunkType(88073)]
    public class EmitterAnimation(File file, uint type) : BaseAnimation(file, type)
    {
        public override string ToShortString()
        {
            return "Emitter Animation";
        }
    }

    [ChunkType(88072)]
    public class ParticleAnimation(File file, uint type) : BaseAnimation(file, type)
    {
        public override string ToShortString()
        {
            return "Particle Animation";
        }
    }

    [ChunkType(88074)]
    public class GeneratorAnimation(File file, uint type) : BaseAnimation(file, type)
    {
        public override string ToShortString()
        {
            return "Generator Animation";
        }
    }
}