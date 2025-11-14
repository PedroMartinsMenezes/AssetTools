namespace AssetTool
{
    [JsonAsset("MVVMBlueprintInstancedViewModelBase")]
    public class UMVVMBlueprintInstancedViewModelBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMBlueprintInstancedViewModel_PropertyBag")]
    public class UMVVMBlueprintInstancedViewModel_PropertyBag : UMVVMBlueprintInstancedViewModelBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}