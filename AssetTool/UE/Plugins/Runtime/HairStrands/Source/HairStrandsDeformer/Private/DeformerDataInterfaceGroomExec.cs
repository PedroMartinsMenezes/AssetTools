namespace AssetTool
{
    [JsonAsset("OptimusGroomExecDataInterface")]
    public class UOptimusGroomExecDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusGroomExecDataProvider")]
    public class UOptimusGroomExecDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}