namespace AssetTool
{
    [JsonAsset("TransBuffer")]
    public class UTransBuffer : UTransactor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}