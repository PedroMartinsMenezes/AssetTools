namespace AssetTool
{
    [JsonAsset("ActorLabelDataStorageFactory")]
    public class UActorLabelDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}