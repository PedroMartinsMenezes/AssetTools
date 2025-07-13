namespace AssetTool
{
    [JsonAsset("MVVMConversionFunctionGraphSchema")]
    public class UMVVMConversionFunctionGraphSchema : UEdGraphSchema_K2
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMAsyncConversionFunctionGraphSchema")]
    public class UMVVMAsyncConversionFunctionGraphSchema : UMVVMConversionFunctionGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMFakeTestUbergraphSchema")]
    public class UMVVMFakeTestUbergraphSchema : UEdGraphSchema_K2
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMFakeTestUbergraph")]
    public class UMVVMFakeTestUbergraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMFakeTestFunctiongraph")]
    public class UMVVMFakeTestFunctiongraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}