namespace AssetTool
{
    [JsonAsset("DefaultAssetEditorGizmoFactory")]
    public class UDefaultAssetEditorGizmoFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}