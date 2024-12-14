namespace AssetTool
{
    [JsonAsset("ParticleModuleRequired")]
    public class UParticleModuleRequired : UParticleModule
    {
        public FBool bCooked;
        public FSubUVDerivedData DerivedData;

        [Location("void UParticleModuleRequired::Serialize(FStructuredArchive::FRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.MovedParticleCutoutsToRequiredModule)
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