namespace AssetTool
{
    [JsonAsset("MovementRecordUtils")]
    public class UMovementRecordUtils : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}