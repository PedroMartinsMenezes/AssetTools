namespace AssetTool
{
    [JsonAsset("ScriptableToolPointSet")]
    public class UScriptableToolPointSet : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}