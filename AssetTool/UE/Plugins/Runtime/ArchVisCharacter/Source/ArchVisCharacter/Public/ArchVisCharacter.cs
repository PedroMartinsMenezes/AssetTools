namespace AssetTool
{
    [JsonAsset("ArchVisCharacter")]
    public class AArchVisCharacter : ACharacter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}