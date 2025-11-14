namespace AssetTool
{
    [JsonAsset("ScriptPluginComponent")]
    public class UScriptPluginComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}