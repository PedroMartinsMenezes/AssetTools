namespace AssetTool
{
    [JsonAsset("MVVMObjectFieldPathHelperTest")]
    public class UMVVMObjectFieldPathHelperTest : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMViewModelFieldPathHelperTestBase")]
    public class UMVVMViewModelFieldPathHelperTestBase : UMVVMObjectFieldPathHelperTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMViewModelFieldPathHelperTest")]
    public class UMVVMViewModelFieldPathHelperTest : UMVVMViewModelFieldPathHelperTestBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMWidgetFieldPathHelperTest")]
    public class UMVVMWidgetFieldPathHelperTest : UUserWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}