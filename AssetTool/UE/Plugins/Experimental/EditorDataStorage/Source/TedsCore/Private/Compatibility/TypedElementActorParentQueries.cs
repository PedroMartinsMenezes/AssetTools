namespace AssetTool
{
    [JsonAsset("ActorParentDataStorageFactory")]
    public class UActorParentDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}