namespace AssetTool
{
    [JsonAsset("AudioCapture")]
    public class UAudioCapture : UAudioGenerator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioCaptureFunctionLibrary")]
    public class UAudioCaptureFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}