namespace AssetTool
{
    [JsonAsset("Character")]
    public class ACharacter : APawn
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}