namespace AssetTool
{
    [JsonAsset("MVVMBlueprintInstancedViewModelBase")]
    public class UMVVMBlueprintInstancedViewModelBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMBlueprintInstancedViewModel_PropertyBag")]
    public class UMVVMBlueprintInstancedViewModel_PropertyBag : UMVVMBlueprintInstancedViewModelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}