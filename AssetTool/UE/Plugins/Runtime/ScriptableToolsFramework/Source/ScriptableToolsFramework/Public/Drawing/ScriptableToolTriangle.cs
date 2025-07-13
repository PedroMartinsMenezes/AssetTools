namespace AssetTool
{
    [JsonAsset("ScriptableToolTriangle")]
    public class UScriptableToolTriangle : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScriptableToolQuad")]
    public class UScriptableToolQuad : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}