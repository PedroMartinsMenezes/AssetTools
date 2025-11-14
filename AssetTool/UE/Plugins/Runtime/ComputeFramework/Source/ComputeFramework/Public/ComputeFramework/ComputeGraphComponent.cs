namespace AssetTool
{
    [JsonAsset("ComputeGraphComponent")]
    public class UComputeGraphComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}