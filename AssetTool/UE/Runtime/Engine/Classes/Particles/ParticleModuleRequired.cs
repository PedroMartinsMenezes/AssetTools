namespace AssetTool
{
    [JsonAsset("ParticleModuleRequired")]
    public class UParticleModuleRequired : UObject
    {
        public FBool bCooked;
        public FSubUVDerivedData DerivedData;

        [Location("void UParticleModuleRequired::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.MovedParticleCutoutsToRequiredModule)
            {
                transfer.Move(ref bCooked);
                if (bCooked)
                {
                    transfer.Move(ref DerivedData);
                }
            }
            return this;
        }
    }
}