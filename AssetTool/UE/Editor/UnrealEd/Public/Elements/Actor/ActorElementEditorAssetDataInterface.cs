namespace AssetTool
{
    [JsonAsset("ActorElementEditorAssetDataInterface")]
    public class UActorElementEditorAssetDataInterface : UActorElementAssetDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}