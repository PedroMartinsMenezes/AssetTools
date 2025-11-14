namespace AssetTool
{
    [JsonAsset("ScriptableToolPoint")]
    public class UScriptableToolPoint : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}