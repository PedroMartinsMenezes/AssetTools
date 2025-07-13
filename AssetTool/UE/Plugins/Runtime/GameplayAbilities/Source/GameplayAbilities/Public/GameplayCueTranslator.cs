namespace AssetTool
{
    [JsonAsset("GameplayCueTranslator")]
    public class UGameplayCueTranslator : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameplayCueTranslator_Test")]
    public class UGameplayCueTranslator_Test : UGameplayCueTranslator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}