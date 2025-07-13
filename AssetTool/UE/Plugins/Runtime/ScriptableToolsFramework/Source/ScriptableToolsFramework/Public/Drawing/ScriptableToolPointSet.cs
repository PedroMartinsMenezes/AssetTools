namespace AssetTool
{
    [JsonAsset("ScriptableToolPointSet")]
    public class UScriptableToolPointSet : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}