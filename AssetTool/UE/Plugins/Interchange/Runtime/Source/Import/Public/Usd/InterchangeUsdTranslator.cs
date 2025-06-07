namespace AssetTool
{
    [JsonAsset("InterchangeUsdTranslatorSettings")]
    public class UInterchangeUsdTranslatorSettings : UInterchangeTranslatorSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeUSDTranslator")]
    public class UInterchangeUSDTranslator : UInterchangeTranslatorBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}