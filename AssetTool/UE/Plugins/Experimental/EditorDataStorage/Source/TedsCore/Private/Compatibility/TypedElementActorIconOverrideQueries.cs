namespace AssetTool
{
    [JsonAsset("ActorIconOverrideDataStorageFactory")]
    public class UActorIconOverrideDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}