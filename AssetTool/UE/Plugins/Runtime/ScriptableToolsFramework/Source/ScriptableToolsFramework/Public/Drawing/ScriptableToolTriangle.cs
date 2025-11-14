namespace AssetTool
{
    [JsonAsset("ScriptableToolTriangle")]
    public class UScriptableToolTriangle : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScriptableToolQuad")]
    public class UScriptableToolQuad : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}