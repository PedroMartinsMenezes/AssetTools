namespace AssetTool
{
    [JsonAsset("BakedShallowWaterSimulationComponent")]
    public class UBakedShallowWaterSimulationComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}