namespace AssetTool.Chaos
{
    public class FBVHParticles : TParticles3
    {
        public TBoundingVolumeHierarchy<TParticles3, TList<TInt32>> MBVH;

        [Location("void FBVHParticles::Serialize(FChaosArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MBVH);
            return this;
        }
    }
}
