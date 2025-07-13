namespace AssetTool
{
    [JsonAsset("ARSessionConfig")]
    public class UARSessionConfig : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}