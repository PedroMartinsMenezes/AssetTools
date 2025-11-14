namespace AssetTool
{
    [JsonAsset("ActorLabelDataStorageFactory")]
    public class UActorLabelDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}