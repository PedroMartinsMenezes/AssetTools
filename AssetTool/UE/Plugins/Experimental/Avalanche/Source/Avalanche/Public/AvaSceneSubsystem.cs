namespace AssetTool
{
    [JsonAsset("AvaSceneSubsystem")]
    public class UAvaSceneSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}