namespace AssetTool
{
    [JsonAsset("ActorTransformDataStorageFactory")]
    public class UActorTransformDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}