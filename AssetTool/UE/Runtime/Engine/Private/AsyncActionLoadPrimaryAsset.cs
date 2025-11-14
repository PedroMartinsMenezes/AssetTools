namespace AssetTool
{
    [JsonAsset("AsyncActionLoadPrimaryAssetBase")]
    public class UAsyncActionLoadPrimaryAssetBase : UBlueprintAsyncActionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncActionLoadPrimaryAsset")]
    public class UAsyncActionLoadPrimaryAsset : UAsyncActionLoadPrimaryAssetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncActionLoadPrimaryAssetClass")]
    public class UAsyncActionLoadPrimaryAssetClass : UAsyncActionLoadPrimaryAssetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncActionLoadPrimaryAssetList")]
    public class UAsyncActionLoadPrimaryAssetList : UAsyncActionLoadPrimaryAssetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncActionLoadPrimaryAssetClassList")]
    public class UAsyncActionLoadPrimaryAssetClassList : UAsyncActionLoadPrimaryAssetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncActionChangePrimaryAssetBundles")]
    public class UAsyncActionChangePrimaryAssetBundles : UAsyncActionLoadPrimaryAssetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}