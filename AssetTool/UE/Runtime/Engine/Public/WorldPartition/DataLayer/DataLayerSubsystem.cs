namespace AssetTool
{
    [JsonAsset("DataLayerSubsystem")]
    public class UDataLayerSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}