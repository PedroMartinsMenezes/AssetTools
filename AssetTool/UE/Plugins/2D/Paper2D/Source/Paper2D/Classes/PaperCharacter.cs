namespace AssetTool
{
    [JsonAsset("PaperCharacter")]
    public class APaperCharacter : ACharacter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}