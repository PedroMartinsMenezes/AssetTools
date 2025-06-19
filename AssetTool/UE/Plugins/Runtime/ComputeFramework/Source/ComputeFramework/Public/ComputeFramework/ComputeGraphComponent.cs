namespace AssetTool
{
    [JsonAsset("ComputeGraphComponent")]
    public class UComputeGraphComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}