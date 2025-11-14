namespace AssetTool
{
    [JsonAsset("Character")]
    public class ACharacter : APawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}