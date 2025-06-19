namespace AssetTool
{
    [JsonAsset("ActorElementAssetDataInterface")]
    public class UActorElementAssetDataInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}