namespace AssetTool
{
    [JsonAsset("MassVelocityRandomizerTrait")]
    public class UMassVelocityRandomizerTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassRandomVelocityInitializer")]
    public class UMassRandomVelocityInitializer : UMassObserverProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}