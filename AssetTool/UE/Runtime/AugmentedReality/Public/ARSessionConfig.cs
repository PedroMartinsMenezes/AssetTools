namespace AssetTool
{
    [JsonAsset("ARSessionConfig")]
    public class UARSessionConfig : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}