namespace AssetTool
{
    [JsonAsset("ArchVisCharacter")]
    public class AArchVisCharacter : ACharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}