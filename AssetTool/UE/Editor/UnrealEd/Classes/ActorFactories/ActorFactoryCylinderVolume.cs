namespace AssetTool
{
    [JsonAsset("ActorFactoryCylinderVolume")]
    public class UActorFactoryCylinderVolume : UActorFactoryVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}