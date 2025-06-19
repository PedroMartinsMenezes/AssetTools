namespace AssetTool
{
    [JsonAsset("PhysicsAssetEditorOptions")]
    public class UPhysicsAssetEditorOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}