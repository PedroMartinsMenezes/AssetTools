namespace AssetTool
{
    [JsonAsset("ActorViewportDataStorageFactory")]
    public class UActorViewportDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}