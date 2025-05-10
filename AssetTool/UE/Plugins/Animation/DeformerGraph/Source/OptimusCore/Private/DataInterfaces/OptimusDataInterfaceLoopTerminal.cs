namespace AssetTool
{
    [JsonAsset("OptimusLoopTerminalDataInterface")]
    public class UOptimusLoopTerminalDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusLoopTerminalDataProvider")]
    public class UOptimusLoopTerminalDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}