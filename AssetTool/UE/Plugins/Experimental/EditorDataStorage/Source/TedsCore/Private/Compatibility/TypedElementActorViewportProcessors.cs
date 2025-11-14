namespace AssetTool
{
    [JsonAsset("ActorViewportDataStorageFactory")]
    public class UActorViewportDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}