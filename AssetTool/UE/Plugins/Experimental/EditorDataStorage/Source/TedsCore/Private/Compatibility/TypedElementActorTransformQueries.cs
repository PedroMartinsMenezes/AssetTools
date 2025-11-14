namespace AssetTool
{
    [JsonAsset("ActorTransformDataStorageFactory")]
    public class UActorTransformDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}