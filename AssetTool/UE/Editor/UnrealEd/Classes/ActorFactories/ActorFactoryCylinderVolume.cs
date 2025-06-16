namespace AssetTool
{
    [JsonAsset("ActorFactoryCylinderVolume")]
    public class UActorFactoryCylinderVolume : UActorFactoryVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}