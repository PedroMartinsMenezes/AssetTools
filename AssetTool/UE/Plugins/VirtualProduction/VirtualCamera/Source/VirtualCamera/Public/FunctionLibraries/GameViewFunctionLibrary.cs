namespace AssetTool
{
    [JsonAsset("GameViewFunctionLibrary")]
    public class UGameViewFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}