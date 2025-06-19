namespace AssetTool
{
    [JsonAsset("ComputeDataProvider")]
    public class UComputeDataProvider : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}