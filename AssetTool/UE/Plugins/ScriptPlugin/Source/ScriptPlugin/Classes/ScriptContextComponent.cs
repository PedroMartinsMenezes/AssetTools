namespace AssetTool
{
    [JsonAsset("ScriptContextComponent")]
    public class UScriptContextComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}