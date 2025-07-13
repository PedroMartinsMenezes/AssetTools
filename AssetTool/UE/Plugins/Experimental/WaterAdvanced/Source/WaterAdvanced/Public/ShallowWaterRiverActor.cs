namespace AssetTool
{
    [JsonAsset("ShallowWaterRiverComponent")]
    public class UShallowWaterRiverComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ShallowWaterRiver")]
    public class AShallowWaterRiver : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}