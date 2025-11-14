namespace AssetTool
{
    [JsonAsset("MassVelocityRandomizerTrait")]
    public class UMassVelocityRandomizerTrait : UMassEntityTraitBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassRandomVelocityInitializer")]
    public class UMassRandomVelocityInitializer : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}