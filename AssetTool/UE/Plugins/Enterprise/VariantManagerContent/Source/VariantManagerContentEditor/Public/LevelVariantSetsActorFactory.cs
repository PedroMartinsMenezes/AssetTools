namespace AssetTool
{
    [JsonAsset("LevelVariantSetsActorFactory")]
    public class ULevelVariantSetsActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}