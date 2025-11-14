namespace AssetTool
{
    [JsonAsset("AnimNextRigVMAssetLibrary")]
    public class UAnimNextRigVMAssetLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimNextRigVMAssetEditorData")]
    public class UAnimNextRigVMAssetEditorData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}