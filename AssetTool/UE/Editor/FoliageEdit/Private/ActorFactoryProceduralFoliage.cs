namespace AssetTool
{
    [JsonAsset("ActorFactoryProceduralFoliage")]
    public class UActorFactoryProceduralFoliage : UActorFactoryBoxVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}