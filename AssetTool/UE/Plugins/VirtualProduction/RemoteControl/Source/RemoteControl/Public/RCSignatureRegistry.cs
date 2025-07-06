namespace AssetTool
{
    [JsonAsset("RCSignatureRegistry")]
    public class URCSignatureRegistry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}