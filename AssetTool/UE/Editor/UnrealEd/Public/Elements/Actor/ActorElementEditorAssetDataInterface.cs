namespace AssetTool
{
    [JsonAsset("ActorElementEditorAssetDataInterface")]
    public class UActorElementEditorAssetDataInterface : UActorElementAssetDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}