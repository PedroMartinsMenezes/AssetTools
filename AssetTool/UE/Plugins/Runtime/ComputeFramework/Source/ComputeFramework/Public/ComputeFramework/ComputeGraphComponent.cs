namespace AssetTool
{
    [JsonAsset("ComputeGraphComponent")]
    public class UComputeGraphComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}