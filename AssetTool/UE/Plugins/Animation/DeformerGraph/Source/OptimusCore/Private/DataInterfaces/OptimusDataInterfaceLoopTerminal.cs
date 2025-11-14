namespace AssetTool
{
    [JsonAsset("OptimusLoopTerminalDataInterface")]
    public class UOptimusLoopTerminalDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusLoopTerminalDataProvider")]
    public class UOptimusLoopTerminalDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}