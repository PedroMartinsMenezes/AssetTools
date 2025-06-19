namespace AssetTool
{
    [JsonAsset("AvaPlayableGroupSubsystem")]
    public class UAvaPlayableGroupSubsystem : UGameInstanceSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}