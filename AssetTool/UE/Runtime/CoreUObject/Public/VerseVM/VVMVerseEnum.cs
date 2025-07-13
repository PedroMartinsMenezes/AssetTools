namespace AssetTool
{
    [JsonAsset("VerseEnum")]
    public class UVerseEnum : UEnum
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}