namespace AssetTool
{
    [JsonAsset("VerseEnum")]
    public class UVerseEnum : UEnum
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}