namespace AssetTool
{
    [JsonAsset("ActorWithReferencesInCDO")]
    public class AActorWithReferencesInCDO : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}