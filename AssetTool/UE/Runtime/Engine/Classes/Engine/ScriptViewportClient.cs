namespace AssetTool
{
    [JsonAsset("ScriptViewportClient")]
    public class UScriptViewportClient : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}