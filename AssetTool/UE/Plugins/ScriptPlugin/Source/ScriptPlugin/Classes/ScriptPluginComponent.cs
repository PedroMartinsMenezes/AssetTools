namespace AssetTool
{
    [JsonAsset("ScriptPluginComponent")]
    public class UScriptPluginComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}