namespace AssetTool
{
    [JsonAsset("LinearTimecodeComponent")]
    public class ULinearTimecodeComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DropTimecodeToStringConversion")]
    public class UDropTimecodeToStringConversion : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}