namespace AssetTool
{
    [JsonAsset("ScriptContextComponent")]
    public class UScriptContextComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}