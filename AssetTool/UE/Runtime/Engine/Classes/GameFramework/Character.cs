namespace AssetTool
{
    [JsonAsset("Character")]
    public class ACharacter : APawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}