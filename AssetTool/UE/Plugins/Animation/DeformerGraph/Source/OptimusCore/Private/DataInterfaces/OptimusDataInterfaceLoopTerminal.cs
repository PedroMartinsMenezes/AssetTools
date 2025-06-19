namespace AssetTool
{
    [JsonAsset("OptimusLoopTerminalDataInterface")]
    public class UOptimusLoopTerminalDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusLoopTerminalDataProvider")]
    public class UOptimusLoopTerminalDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}