namespace AssetTool
{
    [JsonAsset("GameplayCueTranslator")]
    public class UGameplayCueTranslator : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameplayCueTranslator_Test")]
    public class UGameplayCueTranslator_Test : UGameplayCueTranslator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}