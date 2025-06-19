namespace AssetTool
{
    [JsonAsset("OptimusSource")]
    public class UOptimusSource : UComputeSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}