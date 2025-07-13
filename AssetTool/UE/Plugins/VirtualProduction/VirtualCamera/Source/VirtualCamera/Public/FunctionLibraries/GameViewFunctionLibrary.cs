namespace AssetTool
{
    [JsonAsset("GameViewFunctionLibrary")]
    public class UGameViewFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}