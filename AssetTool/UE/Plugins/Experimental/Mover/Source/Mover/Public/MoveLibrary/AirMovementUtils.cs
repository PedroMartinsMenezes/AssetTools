namespace AssetTool
{
    [JsonAsset("AirMovementUtils")]
    public class UAirMovementUtils : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}