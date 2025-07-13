namespace AssetTool
{
    [JsonAsset("GameFeaturesSubsystem")]
    public class UGameFeaturesSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}