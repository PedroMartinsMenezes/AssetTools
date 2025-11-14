namespace AssetTool
{
    [JsonAsset("ActorWithReferencesInCDO")]
    public class AActorWithReferencesInCDO : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}