namespace AssetTool
{
    [JsonAsset("ActorElementEditorAssetDataInterface")]
    public class UActorElementEditorAssetDataInterface : UActorElementAssetDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}