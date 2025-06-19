namespace AssetTool
{
    [JsonAsset("DataLayerSubsystem")]
    public class UDataLayerSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}