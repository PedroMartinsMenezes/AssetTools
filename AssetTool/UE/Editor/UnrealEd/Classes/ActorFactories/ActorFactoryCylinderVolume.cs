namespace AssetTool
{
    [JsonAsset("ActorFactoryCylinderVolume")]
    public class UActorFactoryCylinderVolume : UActorFactoryVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}