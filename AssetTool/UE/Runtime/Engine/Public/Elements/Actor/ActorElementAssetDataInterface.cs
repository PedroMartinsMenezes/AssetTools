namespace AssetTool
{
    [JsonAsset("ActorElementAssetDataInterface")]
    public class UActorElementAssetDataInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}