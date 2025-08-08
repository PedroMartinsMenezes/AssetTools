namespace AssetTool
{
    [JsonAsset("ChaosVDParentDataStorageFactory")]
    public class UChaosVDParentDataStorageFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}