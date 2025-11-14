namespace AssetTool
{
    [JsonAsset("MVVMObjectFieldPathHelperTest")]
    public class UMVVMObjectFieldPathHelperTest : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMViewModelFieldPathHelperTestBase")]
    public class UMVVMViewModelFieldPathHelperTestBase : UMVVMObjectFieldPathHelperTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMViewModelFieldPathHelperTest")]
    public class UMVVMViewModelFieldPathHelperTest : UMVVMViewModelFieldPathHelperTestBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMWidgetFieldPathHelperTest")]
    public class UMVVMWidgetFieldPathHelperTest : UUserWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}