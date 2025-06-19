namespace AssetTool.Chaos
{
    public class FBVHParticles : TParticles3
    {
        public TBoundingVolumeHierarchy<TParticles3, TList<TInt32>> MBVH;

        [Location("void FBVHParticles::Serialize(FChaosArchive& Ar)")]
        public override ITransferible Move2(Transfer transfer)
        {
            base.Move2(transfer);
            transfer.Move(ref MBVH);
            return this;
        }
    }
}
