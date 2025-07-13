namespace AssetTool
{
    [JsonAsset("ActorBrowserConfig")]
    public class UActorBrowserConfig : UEditorConfigBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}