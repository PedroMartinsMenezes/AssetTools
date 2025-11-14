namespace AssetTool
{
    [JsonAsset("TransBuffer")]
    public class UTransBuffer : UTransactor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}