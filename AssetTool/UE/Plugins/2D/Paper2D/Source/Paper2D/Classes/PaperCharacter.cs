namespace AssetTool
{
    [JsonAsset("PaperCharacter")]
    public class APaperCharacter : ACharacter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}