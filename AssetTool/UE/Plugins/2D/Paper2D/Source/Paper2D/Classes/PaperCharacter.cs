namespace AssetTool
{
    [JsonAsset("PaperCharacter")]
    public class APaperCharacter : ACharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}