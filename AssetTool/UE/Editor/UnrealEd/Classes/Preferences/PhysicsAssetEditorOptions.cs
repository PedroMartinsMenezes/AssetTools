namespace AssetTool
{
    [JsonAsset("PhysicsAssetEditorOptions")]
    public class UPhysicsAssetEditorOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}