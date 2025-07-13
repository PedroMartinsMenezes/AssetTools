namespace AssetTool
{
    [JsonAsset("PhysicsAssetEditorPhysicsHandleComponent")]
    public class UPhysicsAssetEditorPhysicsHandleComponent : UPhysicsHandleComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}