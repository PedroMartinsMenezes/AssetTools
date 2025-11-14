namespace AssetTool
{
    [JsonAsset("TedsMementoTranslatorBase")]
    public class UTedsMementoTranslatorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TedsDefaultMementoTranslator")]
    public class UTedsDefaultMementoTranslator : UTedsMementoTranslatorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}