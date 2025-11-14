namespace AssetTool
{
    [JsonAsset("ScriptableToolSet")]
    public class UScriptableToolSet : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}