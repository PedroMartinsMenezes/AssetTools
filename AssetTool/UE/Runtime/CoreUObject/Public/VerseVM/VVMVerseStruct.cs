namespace AssetTool
{
    [JsonAsset("VerseStruct")]
    public class UVerseStruct : UScriptStruct
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}