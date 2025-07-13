namespace AssetTool
{
    [JsonAsset("VerseClass")]
    public class UVerseClass : UClass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}