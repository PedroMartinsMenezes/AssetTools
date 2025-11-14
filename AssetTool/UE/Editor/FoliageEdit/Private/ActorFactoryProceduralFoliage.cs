namespace AssetTool
{
    [JsonAsset("ActorFactoryProceduralFoliage")]
    public class UActorFactoryProceduralFoliage : UActorFactoryBoxVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}