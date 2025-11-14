
namespace AssetTool.Chaos
{
    [Location("https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/Experimental/Chaos/Public/Chaos/Particles.h")]
    public class TParticles3 : ITransferable
    {
        public FBool bSerialize;
        public List<TVector3> MX;

        [Location("void Serialize(FArchive& Ar) at 122")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bSerialize);
            transfer.Move(ref MX);
            return this;
        }

        public int Size()
        {
            return MX.Count;
        }

        public TVec3 GetX(int Index)
        {
            return MX[Index];
        }
    }
}
