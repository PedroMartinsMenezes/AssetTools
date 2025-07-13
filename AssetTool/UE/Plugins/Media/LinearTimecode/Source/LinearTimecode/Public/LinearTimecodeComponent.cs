namespace AssetTool
{
    [JsonAsset("LinearTimecodeComponent")]
    public class ULinearTimecodeComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DropTimecodeToStringConversion")]
    public class UDropTimecodeToStringConversion : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}