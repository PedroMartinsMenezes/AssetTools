namespace AssetTool
{
    [JsonAsset("AvaSceneSubsystem")]
    public class UAvaSceneSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}