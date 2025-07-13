namespace AssetTool
{
    [JsonAsset("ActorParentDataStorageFactory")]
    public class UActorParentDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}