namespace AssetTool
{
    [JsonAsset("PhysicsAssetEditorPhysicsHandleComponent")]
    public class UPhysicsAssetEditorPhysicsHandleComponent : UPhysicsHandleComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}