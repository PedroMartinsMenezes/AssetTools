namespace AssetTool
{
    [JsonAsset("LevelVariantSetsActorFactory")]
    public class ULevelVariantSetsActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}