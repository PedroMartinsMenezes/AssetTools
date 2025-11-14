namespace AssetTool
{
    [JsonAsset("ActorBrowserConfig")]
    public class UActorBrowserConfig : UEditorConfigBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}