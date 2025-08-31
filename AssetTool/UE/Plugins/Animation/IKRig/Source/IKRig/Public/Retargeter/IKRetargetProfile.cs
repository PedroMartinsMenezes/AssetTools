namespace AssetTool
{
    [JsonAsset("RetargetProfileLibrary")]
    public class URetargetProfileLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}