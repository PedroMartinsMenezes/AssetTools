namespace AssetTool
{
    [JsonAsset("BakedShallowWaterSimulationComponent")]
    public class UBakedShallowWaterSimulationComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}