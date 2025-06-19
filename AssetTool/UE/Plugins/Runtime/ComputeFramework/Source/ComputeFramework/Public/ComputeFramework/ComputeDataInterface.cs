namespace AssetTool
{
    [JsonAsset("ComputeDataInterface")]
    public class UComputeDataInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}