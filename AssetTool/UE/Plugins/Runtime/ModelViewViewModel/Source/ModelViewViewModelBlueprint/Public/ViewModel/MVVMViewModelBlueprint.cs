namespace AssetTool
{
    [JsonAsset("MVVMViewModelBlueprint")]
    public class UMVVMViewModelBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}