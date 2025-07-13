namespace AssetTool
{
    [JsonAsset("VerseStruct")]
    public class UVerseStruct : UScriptStruct
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}