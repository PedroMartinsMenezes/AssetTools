namespace AssetTool
{
    [JsonAsset("InterchangeBaseNode")]
    public class UInterchangeBaseNode : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}