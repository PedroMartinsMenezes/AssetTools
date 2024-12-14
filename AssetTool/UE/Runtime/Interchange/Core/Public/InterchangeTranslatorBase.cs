namespace AssetTool
{
    [JsonAsset("InterchangeTranslatorBase")]
    public class UInterchangeTranslatorBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}